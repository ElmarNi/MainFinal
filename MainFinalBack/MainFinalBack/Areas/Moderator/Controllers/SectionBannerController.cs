using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using static MainFinalBack.Extensions.IFormFileEx;

namespace MainFinalBack.Areas.Moderator.Controllers
{
    [Area("Moderator")]
    public class SectionBannerController : Controller
    {
        private readonly RentNowDbContext _context;
        private readonly IHostingEnvironment _env;

        public SectionBannerController(RentNowDbContext context, IHostingEnvironment env)
        {
            _env = env;
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                return View(_context.SectionBanners.OrderBy(b => b.SectionName));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        public IActionResult Edit(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (id == null || !_context.SectionBanners.Any(b => b.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                return View(_context.SectionBanners.Find(id));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SectionBanner banner)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (banner == null)
                {
                    return PartialView("ErrorPage");
                }
                if (!ModelState.IsValid)
                {
                    return PartialView("ErrorPage");
                }
                SectionBanner bannerDb = _context.SectionBanners.Find(banner.Id);
                if (!banner.Photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photo", "Photo should be image");
                    return View(bannerDb);
                }
                RemovePhoto(_env.WebRootPath, bannerDb.ImageUrl);
                bannerDb.ImageUrl = await banner.Photo.SavePhotoAsync(_env.WebRootPath, "SectionBanners");
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
    }
}