using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MainFinalBack.Models;
using MainFinalBack.DAL;
using MainFinalBack.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MainFinalBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly RentNowDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public HomeController(RentNowDbContext context, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            if (!await _roleManager.RoleExistsAsync("admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (!await _roleManager.RoleExistsAsync("moderator"))
            {
                await _roleManager.CreateAsync(new IdentityRole("moderator"));
            }
            if (!await _roleManager.RoleExistsAsync("member"))
            {
                await _roleManager.CreateAsync(new IdentityRole("member"));
            }
            if (await _userManager.FindByEmailAsync("admin@email.com") == null)
            {
                ApplicationUser admin = new ApplicationUser
                {
                    UserName = "admin",
                    Email = "admin@email.com",
                    EmailConfirmed = true,
                    IsBlocked = false,
                    Firstname = "Elmar",
                    Lastname = "Ibrahimli"
                };
                await _userManager.CreateAsync(admin, "admin1999");
                await _userManager.AddToRoleAsync(admin, "admin");
            }
            if (_context.Cars.Any(c => c.CarClassId == 1) && _context.Cars.Any(c => c.CarClassId == 2) && _context.Cars.Any(c => c.CarClassId == 3))
            {
                ViewBag.LowestStandart = Math.Truncate(_context.Cars.Where(c => c.CarClassId == 2).OrderBy(c => c.Price).FirstOrDefault().Price);
                ViewBag.LowestEconom = Math.Truncate(_context.Cars.Where(c => c.CarClassId == 1).OrderBy(c => c.Price).FirstOrDefault().Price);
                ViewBag.LowestPremium = Math.Truncate(_context.Cars.Where(c => c.CarClassId == 3).OrderBy(c => c.Price).FirstOrDefault().Price);
            }
            ViewBag.VipCarsCount = _context.Cars.Where(c => c.IsVip == true).Count();
            ViewBag.Banner = _context.SectionBanners.Where(b => b.SectionName == "Home").FirstOrDefault().ImageUrl;
            HomeVM viewModel = new HomeVM
            {
                Blogs = _context.Blogs.OrderByDescending(blog => blog.UpdatedDate).Take(3),
                Advertisements = _context.Advertisements.Where(ad => ad.Car.IsVip && ad.IsVerified).Include(ad => ad.Car)
                                                                                   .Include(ad => ad.Car.City)
                                                                                   .Include(ad => ad.Car.Transmission)
                                                                                   .Include(ad => ad.Car.City.Country)
                                                                                   .Include(ad => ad.Car.Color).OrderByDescending(ad => ad.UpdatedDate)
            };
            return View(viewModel);
        }
    }
}
