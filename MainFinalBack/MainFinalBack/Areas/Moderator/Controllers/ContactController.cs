using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.Models;
using MainFinalBack.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MainFinalBack.Areas.Moderator.Controllers
{
    [Area("moderator")]
    public class ContactController : Controller
    {
        private readonly RentNowDbContext _context;
        public ContactController(RentNowDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                ContactModeratorVM model = new ContactModeratorVM
                {
                    Contacts = _context.Contacts.OrderByDescending(c => c.Date)
                };
                return View(model);
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactModeratorVM contact, int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (id == null || !_context.Contacts.Any(c => c.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                if (!ModelState.IsValid)
                {
                    return NotFound();
                }
                Contact contactFromDb = await _context.Contacts.FindAsync(id);
                SmtpClient client = new SmtpClient("smtp.office365.com", 587)
                {
                    UseDefaultCredentials = false,
                    EnableSsl = true,
                    Credentials = new NetworkCredential("rentnow@elmaribrahimli.com", "elmar1999@")
                };

                MailMessage message = new MailMessage("rentnow@elmaribrahimli.com", contactFromDb.Email)
                {
                    IsBodyHtml = true,
                    Subject = "Your message ansewered",
                    Body = contact.Message +
                            "<div style='width:100%'>" +
                                "<div style='width:23%;display:inline-block;background-color:#1876D2;height:3px'></div>" +
                                "<h3 style='font-size: 1.80203rem;line-height: 36px;margin:0;margin-bottom:20px'>Elmar Ibrahimli</h3>" +
                                "<p style='color:#00D231; display:inline;font-size: 30px;font-style: italic;font-weight: bold;'>RENT</p><p style='color:black; display:inline;font-size: 30px;font-style: italic;font-weight: bold;'>NOW</p>" +
                                "<a href='tel:+994703347347' style='color: rgb(9,117,122);display:block'> +994703347347</a>" +
                                "<a href='www.therentnow.com' target='_blank' style='color: rgb(9,117,122);display:block'>therentnow.com</a>" +
                            "</div>"
                };
                await client.SendMailAsync(message);
                _context.Contacts.Remove(contactFromDb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
    }
}