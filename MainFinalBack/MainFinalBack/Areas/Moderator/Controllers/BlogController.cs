using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static MainFinalBack.Extensions.IFormFileEx;

namespace MainFinalBack.Areas.Moderator.Controllers
{
    [Area("Moderator")]
    public class BlogController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly RentNowDbContext _context;
        public BlogController(RentNowDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                return View(_context.Blogs.OrderByDescending(b => b.UpdatedDate));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        public IActionResult Create()
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
        public async Task<IActionResult> Create(Blog blog)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (blog == null)
                {
                    return PartialView("ErrorPage");
                }
                if (!ModelState.IsValid)
                {
                    return NotFound();
                }
                if (blog.Content.Length < 300)
                {
                    ModelState.AddModelError("Content", "Content is too short");
                    return View(blog);
                }
                Blog newBlog = new Blog();
                await _context.AddAsync(newBlog);
                if (blog.MainPhoto == null)
                {
                    ModelState.AddModelError("MainPhoto", "Main image should be selected");
                    return View(blog);
                }
                if (!blog.MainPhoto.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("MainPhoto", "File type should be image");
                    return View(blog);
                }
                newBlog.MainImageUrl = await blog.MainPhoto.SavePhotoAsync(_env.WebRootPath, "blogs");
                newBlog.Header = blog.Header;
                newBlog.Content = blog.Content;
                newBlog.PublishDate = DateTime.Now;
                newBlog.UpdatedDate = DateTime.Now;
                if (blog.DetailPhotos != null)
                {
                    foreach (var photo in blog.DetailPhotos)
                    {
                        if (!photo.ContentType.Contains("image/"))
                        {
                            ModelState.AddModelError("DetailPhotos", "File type should be image");
                            return View(blog);
                        }
                    }
                    foreach (var photo in blog.DetailPhotos)
                    {
                        BlogDetailImage detailImage = new BlogDetailImage
                        {
                            BlogId = newBlog.Id,
                            ImageUrl = await photo.SavePhotoAsync(_env.WebRootPath, "blogs")
                        };
                        await _context.BlogDetailImages.AddAsync(detailImage);
                    }
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        public IActionResult Edit(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (id == null)
                {
                    return PartialView("ErrorPage");
                }
                if (!_context.Blogs.Any(b => b.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                return View(_context.Blogs.Where(b => b.Id == id).Include(b => b.BlogDetailImages).FirstOrDefault());
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Blog blog)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (blog == null)
                {
                    return PartialView("ErrorPage");
                }
                if (!ModelState.IsValid)
                {
                    return NotFound();
                }
                Blog blogFromDb = await _context.Blogs.Where(b => b.Id == blog.Id).Include(b => b.BlogDetailImages).FirstOrDefaultAsync();
                if (blog.MainPhoto != null)
                {
                    if (!blog.MainPhoto.ContentType.Contains("image/"))
                    {
                        ModelState.AddModelError("MainPhoto", "File type should be image");
                        return View(blogFromDb);
                    }
                    RemovePhoto(_env.WebRootPath, blogFromDb.MainImageUrl);
                    blogFromDb.MainImageUrl = await blog.MainPhoto.SavePhotoAsync(_env.WebRootPath, "blogs");
                }
                if (blog.DetailPhotos != null)
                {
                    foreach (var photo in blog.DetailPhotos)
                    {
                        if (!photo.ContentType.Contains("image/"))
                        {
                            ModelState.AddModelError("DetailPhotos", "File type should be image");
                            return View(blogFromDb);
                        }
                    }
                    foreach (var photo in blog.DetailPhotos)
                    {
                        BlogDetailImage detailImage = new BlogDetailImage
                        {
                            BlogId = blogFromDb.Id,
                            ImageUrl = await photo.SavePhotoAsync(_env.WebRootPath, "blogs")
                        };
                        await _context.BlogDetailImages.AddAsync(detailImage);
                    }
                }
                blogFromDb.Header = blog.Header;
                blogFromDb.Content = blog.Content;
                blogFromDb.UpdatedDate = DateTime.Now;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (id == null)
                {
                    return PartialView("ErrorPage");
                }
                if (!_context.Blogs.Any(b => b.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                Blog blog = await _context.Blogs.Where(b => b.Id == id).Include(b => b.BlogDetailImages).FirstOrDefaultAsync();
                foreach (var img in blog.BlogDetailImages)
                {
                    RemovePhoto(_env.WebRootPath, img.ImageUrl);
                }
                RemovePhoto(_env.WebRootPath, blog.MainImageUrl);
                _context.Remove(blog);
                await _context.SaveChangesAsync();
                return Redirect("/moderator/Blog");
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
    }
}