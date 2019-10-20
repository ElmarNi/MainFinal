using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MainFinalBack.Areas.User.Controllers
{
    [Area("User")]
    public class OrderController : Controller
    {
        private readonly RentNowDbContext _context;
        public OrderController(RentNowDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("member"))
            {
                return View(_context.Orders.Where(o => o.ResponseDate > DateTime.Now).Include(o => o.Advertisement).Include(o => o.Advertisement.ApplicationUser).Where(o => o.Advertisement.ApplicationUser.UserName == User.Identity.Name).Include(o => o.Advertisement.Car).OrderByDescending(o => o.OrderDate).Where(o => o.IsResponded == false));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        public async Task<IActionResult> Reject(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("member"))
            {
                if (id == null || !_context.Orders.Any(o => o.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                Order order = await _context.Orders.FindAsync(id);
                SmtpClient client = new SmtpClient("smtp.office365.com", 587)
                {
                    UseDefaultCredentials = false,
                    EnableSsl = true,
                    Credentials = new NetworkCredential("rentnow@elmaribrahimli.com", "elmar1999@")
                };

                MailMessage message = new MailMessage("rentnow@elmaribrahimli.com", order.Email)
                {
                    IsBodyHtml = true,
                    Subject = "Your order is rejected",
                    Body = $"<a href='http://www.therentnow.com/Cars/Details/{order.AdvertisementId}'>Dear {order.Firstname} {order.Lastname},your order is rejected.Click for car details </a>" + 
                            "<div style='width:100%'>" +
                                "<div style='width:23%;display:inline-block;background-color:#1876D2;height:3px'></div>" +
                                "<h3 style='font-size: 1.80203rem;line-height: 36px;margin:0;margin-bottom:20px'>Elmar Ibrahimli</h3>" +
                                "<p style='color:#00D231; display:inline;font-size: 30px;font-style: italic;font-weight: bold;'>RENT</p><p style='color:black; display:inline;font-size: 30px;font-style: italic;font-weight: bold;'>NOW</p>" +
                                "<a href='tel:+994703347347' style='color: rgb(9,117,122);display:block'> +994703347347</a>" +
                                "<a href='www.therentnow.com' target='_blank' style='color: rgb(9,117,122);display:block'>therentnow.com</a>" +
                            "</div>"
                };
                await client.SendMailAsync(message);
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        public async Task<IActionResult> Confirm(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("member"))
            {
                if (id == null || !_context.Orders.Any(o => o.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                Order order = await _context.Orders.Where(o => o.Id == id).Include(o => o.Advertisement.ApplicationUser).FirstOrDefaultAsync();
                SmtpClient client = new SmtpClient("smtp.office365.com", 587)
                {
                    UseDefaultCredentials = false,
                    EnableSsl = true,
                    Credentials = new NetworkCredential("rentnow@elmaribrahimli.com", "elmar1999@")
                };

                MailMessage message = new MailMessage("rentnow@elmaribrahimli.com", order.Email)
                {
                    IsBodyHtml = true,
                    Subject = "Your order is accepted",
                    Body = $"<p> <a href='http://www.therentnow.com/Cars/Details/{order.AdvertisementId}' style='display:block'>Dear {order.Firstname} {order.Lastname},your order is accepted. Click for car details</a> <a href='mailto:{order.Advertisement.ApplicationUser.Email}' style='display:block'>Contact with mail: {order.Advertisement.ApplicationUser.Email}</a> </p>" +
                            "<div style='width:100%'>" +
                                "<div style='width:23%;display:inline-block;background-color:#1876D2;height:3px'></div>" +
                                "<h3 style='font-size: 1.80203rem;line-height: 36px;margin:0;margin-bottom:20px'>Elmar Ibrahimli</h3>" +
                                "<p style='color:#00D231; display:inline;font-size: 30px;font-style: italic;font-weight: bold;'>RENT</p><p style='color:black; display:inline;font-size: 30px;font-style: italic;font-weight: bold;'>NOW</p>" +
                                "<a href='tel:+994703347347' style='color: rgb(9,117,122);display:block'> +994703347347</a>" +
                                "<a href='www.therentnow.com' target='_blank' style='color: rgb(9,117,122);display:block'>therentnow.com</a>" +
                            "</div>"
                };
                await client.SendMailAsync(message);
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

    }
}