using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MainFinalBack.Controllers
{
    public class AboutController : Controller
    {
        private readonly RentNowDbContext _context;
        public AboutController(RentNowDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Banner = _context.SectionBanners.Where(b => b.SectionName == "About Us").FirstOrDefault().ImageUrl;
            AboutUsVM model = new AboutUsVM { OurVisions = _context.OurVisions, OurPassions = _context.OurPassions.FirstOrDefault() };
            return View(model);
        }
    }
}