using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.Models;
using MainFinalBack.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MainFinalBack.Areas.Moderator.Controllers
{
    [Area("Moderator")]
    public class AdvertisementController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly RentNowDbContext _context;
        public AdvertisementController(RentNowDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                return View(_context.Advertisements.Where(ad => ad.IsVerified == false)
                                                    .Include(ad => ad.Car)
                                                    .Include(ad => ad.Car.Model)
                                                    .Include(ad => ad.Car.Model.Brand)
                                                    .Include(ad => ad.ApplicationUser));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        public IActionResult Details(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (id == null || !_context.Advertisements.Any(ad => ad.Id == id))
                {
                    return NotFound();
                }
                ModeratorAdDetailsVM vM = new ModeratorAdDetailsVM
                {
                    Advertisement = _context.Advertisements.Where(ad => ad.Id == id)
                                                    .Include(ad => ad.Car)
                                                    .Include(ad => ad.Car.Model.Brand)
                                                    .Include(ad => ad.Car.Model)
                                                    .Include(ad => ad.Car.Color)
                                                    .Include(ad => ad.Car.BodyType)
                                                    .Include(ad => ad.Car.Transmission)
                                                    .Include(ad => ad.Car.WheelDrive)
                                                    .Include(ad => ad.Car.FuelType)
                                                    .Include(ad => ad.Car.City)
                                                    .Include(ad => ad.Car.City.Country)
                                                    .Include(ad => ad.Car.CarClass)
                                                    .Include(ad => ad.Car.CarDetailImages)
                                                    .FirstOrDefault()
                };
                return View(vM);
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(int? id, Message message)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (id == null || !_context.Advertisements.Any(ad => ad.Id == id))
                {
                    return NotFound();
                }
                if (!ModelState.IsValid)
                {
                    return NotFound();
                }
                Message newMessage = new Message
                {
                    Body = message.Body,
                    Title = "Your advertisement is not accepted",
                    From = _context.Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault().Id,
                    To = _context.Advertisements.Where(ad => ad.Id == id).FirstOrDefault().ApplicationUserId,
                    Date = DateTime.Now
                };
                await _context.Messages.AddAsync(newMessage);
                AdvertisementMessage advertisementMessage = new AdvertisementMessage {
                    MessageId = newMessage.Id,
                    AdvertisementId = (int)id
                };
                await _context.AdvertisementMessages.AddAsync(advertisementMessage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        public async Task<IActionResult> Accept(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (id == null || !_context.Advertisements.Any(ad => ad.Id == id))
                {
                    return NotFound();
                }
                _context.Advertisements.Where(ad => ad.Id == id).FirstOrDefault().IsVerified = true;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
    }
}