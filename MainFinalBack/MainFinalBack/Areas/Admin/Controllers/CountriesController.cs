using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.Models;
using MainFinalBack.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MainFinalBack.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CountriesController : Controller
    {
        private readonly RentNowDbContext _context;
        public CountriesController(RentNowDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                LoadCountriesAdminVM vM = new LoadCountriesAdminVM { Countries = _context.Countries.OrderBy(c => c.Name).Take(10)};
                ViewBag.Countries = _context.Countries.Count();
                return View(vM);
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Country country)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (!ModelState.IsValid)
                {
                    return PartialView("ErrorPage");
                }
                if (_context.Countries.Any(c => c.Name == country.Name))
                {
                    LoadCountriesAdminVM vM = new LoadCountriesAdminVM { Countries = _context.Countries.OrderBy(c => c.Name) };
                    ModelState.AddModelError("Country.Name", "Country is already exsist");
                    return View(vM);
                }
                Country newC = new Country { Name = country.Name };
                await _context.Countries.AddAsync(newC);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        public IActionResult Edit(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (id == null || !_context.Countries.Any(c => c.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                return View(_context.Countries.Where(c => c.Id == id).FirstOrDefault());
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Country country)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (country == null)
                {
                    return PartialView("ErrorPage");
                }
                if (!ModelState.IsValid)
                {
                    return PartialView("ErrorPage");
                }
                if (_context.Countries.Any(c => c.Name == country.Name))
                {
                    ModelState.AddModelError("Name", "Country is already exsist");
                    return View(country);
                }
                Country countryDb = _context.Countries.Find(country.Id);
                countryDb.Name = country.Name;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
    }
}