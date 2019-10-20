using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.Models;
using MainFinalBack.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MainFinalBack.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ModeratorController : Controller
    {
        private readonly RentNowDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ModeratorController(UserManager<ApplicationUser> userManager, RentNowDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                IList<ApplicationUser> users = await _userManager.GetUsersInRoleAsync("moderator");
                return View(users);
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        public IActionResult Create()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                return View();
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RegisterVM model)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                ApplicationUser moderator = new ApplicationUser
                {
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    Email = model.Email,
                    UserName = model.UserName,
                    EmailConfirmed = true,
                    IsBlocked = false
                };

                IdentityResult result = await _userManager.CreateAsync(moderator, model.ConfirmPassword);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    ViewBag.IsHeaderNonVisible = true;
                    return View(model);
                }
                await _userManager.AddToRoleAsync(moderator, "moderator");
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
    }
}