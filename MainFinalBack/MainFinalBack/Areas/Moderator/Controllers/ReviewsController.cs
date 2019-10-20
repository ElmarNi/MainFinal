using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MainFinalBack.Areas.Moderator
{
    [Area("moderator")]
    public class ReviewsController : Controller
    {
        private readonly RentNowDbContext _context;
        public ReviewsController(RentNowDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                return View(_context.Advertisements.Where(ad => ad.Reviews.Count() > 0)
                                                    .Include(ad => ad.Car)
                                                    .Include(ad => ad.ApplicationUser)
                                                    .Include(ad => ad.Reviews)
                                                    .Include(ad => ad.Car.Model)
                                                    .Include(ad => ad.Car.Model.Brand).OrderByDescending(ad => ad.Reviews.Count()));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
    }
}