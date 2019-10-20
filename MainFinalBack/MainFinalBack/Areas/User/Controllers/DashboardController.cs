using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MainFinalBack.Areas.User.Controllers
{
    public class DashboardController : Controller
    {
        [Area("User")]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("member"))
            {
                return View();
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
    }
}