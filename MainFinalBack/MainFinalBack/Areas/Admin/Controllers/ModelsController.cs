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
    public class ModelsController : Controller
    {
        private readonly RentNowDbContext _context;
        public ModelsController(RentNowDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                LoadModelsAdminVM vM = new LoadModelsAdminVM { Models = _context.Models.Include(m => m.Brand).OrderBy(c => c.Name) };
                return View(vM);
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Model model)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (!ModelState.IsValid)
                {
                    return NotFound();
                }
                if (_context.Models.Any(m => m.Name == model.Name))
                {
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ModelState.AddModelError("Model.Name", "Model is already exsist");
                    LoadModelsAdminVM vM = new LoadModelsAdminVM { Models = _context.Models.Include(m => m.Brand).OrderBy(c => c.Name) };
                    return View(vM);
                }
                Model newM = new Model { Name = model.Name, BrandId = model.BrandId };
                await _context.Models.AddAsync(newM);
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
                if (id == null || !_context.Models.Any(c => c.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                return View(_context.Models.Find(id));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Model model)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (model == null)
                {
                    return PartialView("ErrorPage");
                }
                if (!ModelState.IsValid)
                {
                    return PartialView("ErrorPage");
                }
                if (_context.Models.Any(b => b.Name == model.Name))
                {
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ModelState.AddModelError("Name", "Model is already exsist");
                    return View(model);
                }
                if (!_context.Brands.Any(b => b.Id == model.BrandId))
                {
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ModelState.AddModelError("BrandId", "Brand is not exsist");
                    return View(model);
                }
                Model modelDb = _context.Models.Find(model.Id);
                modelDb.BrandId = model.BrandId;
                modelDb.Name = model.Name;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
    }
}