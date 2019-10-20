using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.Models;
using MainFinalBack.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace MainFinalBack.Controllers
{
    public class BlogController : Controller
    {
        private readonly RentNowDbContext _context;
        public BlogController(RentNowDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.BlogTotalCunt = _context.Blogs.Count();
            //how many pages will display every page will display 2 blogs
            double PageCount = _context.Blogs.Count()/2F;
            //find page count is whole number?
            int RightSideDouble = (int)((PageCount - (int)PageCount) * 10);
            //if page count is not whole number i add 1 more pagination for display all blogs
            if (RightSideDouble > 0)
            {
                PageCount = PageCount + 0.5;
            }
            ViewBag.PageCount = PageCount;
            ViewBag.Banner = _context.SectionBanners.Where(b => b.SectionName == "Blogs").FirstOrDefault().ImageUrl;
            return View(_context.Blogs.OrderByDescending(blog => blog.UpdatedDate).Take(2).ToList());
        }
        public async Task<IActionResult> Details(int id)
        {
            if (!_context.Blogs.Any(b => b.Id == id))
            {
                return PartialView("ErrorPage");
            }
            BlogDetailsVM viewModel = new BlogDetailsVM
            {
                Blog = await _context.Blogs.FindAsync(id),
                BlogDetailImages = _context.BlogDetailImages.Where(image => image.BlogId == id)
            };
            ViewBag.Banner = _context.SectionBanners.Where(b => b.SectionName == "Blog Details").FirstOrDefault().ImageUrl;
            return View(viewModel);
        }
    }
}