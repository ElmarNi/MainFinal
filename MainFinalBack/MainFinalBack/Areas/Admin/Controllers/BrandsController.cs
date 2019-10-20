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
    [Area("admin")]
    public class BrandsController : Controller
    {
        private readonly RentNowDbContext _context;
        public BrandsController(RentNowDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                ViewBag.Brands = _context.Brands.Count();
                LoadBrandsAdminVM vM = new LoadBrandsAdminVM { Brands = _context.Brands.OrderBy(c => c.Name).Take(10) };
                return View(vM);
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Brand brand)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (!ModelState.IsValid)
                {
                    return NotFound();
                }
                if (_context.Brands.Any(b => b.Name == brand.Name))
                {
                    ModelState.AddModelError("Brand.Name", "Brand is already exsist");
                    LoadBrandsAdminVM vM = new LoadBrandsAdminVM { Brands = _context.Brands.OrderBy(c => c.Name) };
                    return View(vM);
                }
                Brand newB = new Brand { Name = brand.Name };
                await _context.Brands.AddAsync(newB);
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
                if (id == null || !_context.Brands.Any(c => c.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                return View(_context.Brands.Find(id));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Brand brand)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (brand == null)
                {
                    return PartialView("ErrorPage");
                }
                if (!ModelState.IsValid)
                {
                    return PartialView("ErrorPage");
                }
                if (_context.Brands.Any(c => c.Name == brand.Name))
                {
                    ModelState.AddModelError("Name", "Brand is already exsist");
                    return View(brand);
                }
                Brand brandDb = _context.Brands.Find(brand.Id);
                brandDb.Name = brand.Name;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
    }
}