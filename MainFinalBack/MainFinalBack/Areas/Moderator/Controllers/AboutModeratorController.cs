using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.Models;
using MainFinalBack.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using static MainFinalBack.Extensions.IFormFileEx;

namespace MainFinalBack.Areas.Moderator.Controllers
{
    [Area("Moderator")]
    public class AboutModeratorController : Controller
    {
        private readonly RentNowDbContext _context;
        private readonly IWebHostEnvironment _env;
        public AboutModeratorController(RentNowDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                AboutUsVM model = new AboutUsVM { OurVisions = _context.OurVisions, OurPassions = _context.OurPassions.FirstOrDefault() };
                return View(model);
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        public IActionResult EditVision(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (id == null || !_context.OurVisions.Any(v => v.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                return View(_context.OurVisions.Where(v => v.Id == id).FirstOrDefault());
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditVision(OurVisionAboutUs vision)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {

                if (vision == null || !_context.OurVisions.Any(v => v.Id == vision.Id) || !ModelState.IsValid)
                {
                    return PartialView("ErrorPage");
                }
                OurVisionAboutUs visionDb = _context.OurVisions.Where(v => v.Id == vision.Id).FirstOrDefault();
                visionDb.Header = vision.Header;
                visionDb.Content = vision.Content;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        public IActionResult EditPassion(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (id == null || !_context.OurPassions.Any(p => p.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                return View(_context.OurPassions.Where(v => v.Id == id).FirstOrDefault());
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPassion(OurPassionAboutUs passion)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (passion == null || !ModelState.IsValid)
                {
                    return PartialView("ErrorPage");
                }
                OurPassionAboutUs passionDb = _context.OurPassions.Where(p => p.Id == passion.Id).FirstOrDefault();
                if (passion.Photo != null)
                {
                    if (!passion.Photo.ContentType.Contains("image/"))
                    {
                        ModelState.AddModelError("Photo", "Content photo should be image");
                        return View(passion);
                    }
                    RemovePhoto(_env.WebRootPath, passionDb.ImageUrl);
                    passionDb.ImageUrl = await passion.Photo.SavePhotoAsync(_env.WebRootPath, "AboutUs");
                }
                if (passion.SectionPhoto != null)
                {
                    if (!passion.SectionPhoto.ContentType.Contains("image/"))
                    {
                        ModelState.AddModelError("SectionPhoto", "Background photo should be image");
                        return View(passion);
                    }
                    RemovePhoto(_env.WebRootPath, passionDb.SectionBannerImage);
                    passionDb.SectionBannerImage = await passion.SectionPhoto.SavePhotoAsync(_env.WebRootPath, "AboutUs");
                }
                passionDb.SmallHeader = passion.SmallHeader;
                passionDb.MainHeader = passion.MainHeader;
                passionDb.Content = passion.Content;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

    }
}