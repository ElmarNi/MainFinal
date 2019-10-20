using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MainFinalBack.Areas.Moderator.Controllers
{
    [Area("Moderator")]
    public class TermsModeratorController : Controller
    {
        private readonly RentNowDbContext _context;
        public TermsModeratorController(RentNowDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                return View(_context.TermHeaders.Include(t => t.TermContents).OrderBy(t => t.Id));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        public async Task<IActionResult> DeleteContent(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (id == null)
                {
                    return PartialView("ErrorPage");
                }
                if (!_context.TermContents.Any(t => t.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                TermContent term = await _context.TermContents.Where(t => t.Id == id).FirstOrDefaultAsync();
                _context.Remove(term);
                await _context.SaveChangesAsync();
                return Redirect("/moderator/TermsModerator");
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        public async Task<IActionResult> DeleteHeader(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (id == null)
                {
                    return PartialView("ErrorPage");
                }
                if (!_context.TermHeaders.Any(t => t.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                TermHeader term = await _context.TermHeaders.Where(t => t.Id == id).Include(t => t.TermContents).FirstOrDefaultAsync();
                _context.RemoveRange(term.TermContents);
                _context.Remove(term);
                await _context.SaveChangesAsync();
                return Redirect("/moderator/TermsModerator");
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        public IActionResult CreateHeader()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                return View();
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateHeader(TermHeader term)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (!ModelState.IsValid)
                {
                    return PartialView("ErrorPage");
                }
                term.Header = term.Header.ToUpper();
                await _context.TermHeaders.AddAsync(term);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        public IActionResult CreateContent()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                ViewBag.Headers = _context.TermHeaders.OrderBy(t => t.Header);
                return View();
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateContent(TermContent term)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (!ModelState.IsValid)
                {
                    return PartialView("ErrorPage");
                }
                if (!_context.TermHeaders.Any(t => t.Id == term.TermHeaderId))
                {
                    ModelState.AddModelError("TermHeaderId", "Select a valid Term Header");
                    ViewBag.Headers = _context.TermHeaders.OrderBy(t => t.Header);
                    return View(term);
                }
                await _context.TermContents.AddAsync(term);
                await _context.SaveChangesAsync();
                return View();
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        public IActionResult EditHeader(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (id == null || !_context.TermHeaders.Any(t => t.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                return View(_context.TermHeaders.Where(t =>t.Id == id).FirstOrDefault());
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditHeader(TermHeader term)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (!ModelState.IsValid)
                {
                    return PartialView("ErrorPage");
                }
                TermHeader termfromdb = _context.TermHeaders.Where(t => t.Id == term.Id).FirstOrDefault();
                termfromdb.Header = term.Header.ToUpper(); ;
                _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        public IActionResult EditContent(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (id == null || !_context.TermContents.Any(t => t.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                ViewBag.Headers = _context.TermHeaders.OrderBy(t => t.Header);
                return View(_context.TermContents.Where(t => t.Id == id).Include(t => t.TermHeader).FirstOrDefault());
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditContent(TermContent term)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (!ModelState.IsValid)
                {
                    return PartialView("ErrorPage");
                }
                if (!_context.TermHeaders.Any(t => t.Id == term.TermHeaderId))
                {
                    ModelState.AddModelError("TermHeaderId", "Select a valid Term Header");
                    ViewBag.Headers = _context.TermHeaders.OrderBy(t => t.Header);
                    return View(term);
                }
                TermContent termfromDb = _context.TermContents.Where(t => t.Id == term.Id).Include(t => t.TermHeader).FirstOrDefault();
                termfromDb.TermHeaderId = term.TermHeaderId;
                termfromDb.Content = term.Content;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

    }
}