using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MainFinalBack.Controllers
{
    public class TermsController : Controller
    {
        private readonly RentNowDbContext _context;
        public TermsController(RentNowDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Banner = _context.SectionBanners.Where(b => b.SectionName == "Terms").FirstOrDefault().ImageUrl;
            return View(_context.TermHeaders.Include(t => t.TermContents));
        }
    }
}