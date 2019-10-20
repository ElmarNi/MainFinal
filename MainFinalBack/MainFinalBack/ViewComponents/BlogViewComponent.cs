using MainFinalBack.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private RentNowDbContext _context;
        public BlogViewComponent(RentNowDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Blogs.OrderByDescending(blog => blog.UpdatedDate).Take(3).ToListAsync());
        }
    }
}
