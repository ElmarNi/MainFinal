using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace MainFinalBack.Controllers
{
    public class ContactController : Controller
    {
        private readonly RentNowDbContext _context;
        public ContactController(RentNowDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.IsHeaderNonVisible = true;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Contact contact)
        {
            if (contact == null)
            {
                ViewBag.IsHeaderNonVisible = true;

                return PartialView("ErrorPage");
            }
            if (!ModelState.IsValid)
            {
                ViewBag.IsHeaderNonVisible = true;

                return NotFound();
            }
            Contact newContact = new Contact {
                Name = contact.Name,
                Email = contact.Email,
                Message = contact.Message,
                Date = DateTime.Now
            };
            await _context.Contacts.AddAsync(newContact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}