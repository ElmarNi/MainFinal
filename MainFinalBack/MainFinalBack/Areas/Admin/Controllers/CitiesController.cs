using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.Models;
using MainFinalBack.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MainFinalBack.Areas.Admin.Controllers
{
    [Area("admin")]
    public class CitiesController : Controller
    {
        private readonly RentNowDbContext _context;
        public CitiesController(RentNowDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                LoadCitiesAdminVM vM = new LoadCitiesAdminVM { Cities = _context.Cities.Include(c => c.Country).OrderBy(c => c.Name) };
                ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                return View(vM);
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(City city)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (!ModelState.IsValid)
                {
                    return PartialView("ErrorPage");
                }
                if (_context.Cities.Any(c => c.Name == city.Name))
                {
                    LoadCitiesAdminVM vM = new LoadCitiesAdminVM { Cities = _context.Cities.Include(c => c.Country).OrderBy(c => c.Name) };
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ModelState.AddModelError("City.Name", "City is already exsist");
                    return View(vM);
                }
                if (!_context.Countries.Any(c => c.Id == city.CountryId))
                {
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    LoadCitiesAdminVM vM = new LoadCitiesAdminVM { Cities = _context.Cities.Include(c => c.Country).OrderBy(c => c.Name) };
                    ModelState.AddModelError("City.CountryId", "Country is not exsist");
                    return View(vM);
                }
                City newC = new City { Name = city.Name, CountryId = city.CountryId };
                await _context.Cities.AddAsync(newC);
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
                if (id == null || !_context.Cities.Any(c => c.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                return View(_context.Cities.Find(id));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(City city)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (city == null)
                {
                    return PartialView("ErrorPage");
                }
                if (!ModelState.IsValid)
                {
                    return PartialView("ErrorPage");
                }
                if (_context.Cities.Any(c => c.Name == city.Name))
                {
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ModelState.AddModelError("Name", "City is already exsist");
                    return View(city);
                }
                if (!_context.Countries.Any(c => c.Id == city.CountryId))
                {
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ModelState.AddModelError("CountryId", "Country is not exsist");
                    return View(city);
                }
                City cityDb = _context.Cities.Find(city.Id);
                cityDb.CountryId = city.CountryId;
                cityDb.Name = city.Name;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

    }
}