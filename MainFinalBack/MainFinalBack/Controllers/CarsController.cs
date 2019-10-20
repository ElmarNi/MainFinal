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
    public class CarsController : Controller
    {
        private readonly RentNowDbContext _context;
        public CarsController(RentNowDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
            ViewBag.CarClases = _context.CarClasses;
            ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
            ViewBag.CarCount = _context.Advertisements.Where(ad => ad.IsVerified).Count();
            ViewBag.Banner = _context.SectionBanners.Where(b => b.SectionName == "Cars").FirstOrDefault().ImageUrl;
            return View(_context.Advertisements.Where(ad => ad.IsVerified).Include(ad => ad.Car)
                                               .Include(ad => ad.Car.CarClass)
                                               .Include(ad => ad.Car.Transmission)
                                               .Include(ad => ad.Car.City)
                                               .Include(ad => ad.Car.City.Country)
                                               .Include(ad => ad.Car.Model.Brand)
                                               .Include(ad => ad.Car.Model)
                                               .OrderBy(ad => ad.Car.Price)
                                               .OrderBy(ad => ad.Car.Model.Brand.Name).Take(3));
        }
        public IActionResult Details(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                if (id == null || !_context.Advertisements.Any(ad => ad.Id == id && ad.IsVerified))
                {
                    return PartialView("ErrorPage");
                }
            }
            CarDetailsVm viewModel = new CarDetailsVm
            {
                Advertisement = _context.Advertisements.Where(ad => ad.Id == id)
                                                .Include(ad => ad.Car)
                                                .Include(ad => ad.Car.Model)
                                                .Include(ad => ad.Car.Model.Brand)
                                                .Include(ad => ad.Car.City)
                                                .Include(ad => ad.Car.City.Country)
                                                .Include(ad => ad.Car.CarClass)
                                                .Include(ad => ad.Car.BodyType)
                                                .Include(ad => ad.Car.FuelType)
                                                .Include(ad => ad.Car.Transmission)
                                                .Include(ad => ad.Car.Color)
                                                .Include(ad => ad.Reviews)
                                                .Include(ad => ad.Car.WheelDrive)
                                                .Include(ad => ad.Car.CarDetailImages).FirstOrDefault(),
                Reviews = _context.Reviews.Where(r => r.AdvertisementId == id),
                CarDetailImages = _context.CarDetailImages.Where(c => c.Car.Advertisement.Id == id)
            };
            if (User.Identity.IsAuthenticated)
            {
                if (_context.Advertisements.Where(ad => ad.Id == id).FirstOrDefault().IsVerified == false)
                {
                    if (_context.Advertisements.Where(ad => ad.Id == id).Include(ad => ad.ApplicationUser).FirstOrDefault().ApplicationUser.UserName != User.Identity.Name)
                    {
                        return PartialView("ErrorPage");
                    }
                }
            }
            ViewBag.Banner = _context.SectionBanners.Where(b => b.SectionName == "Car Details").FirstOrDefault().ImageUrl;
            return View(viewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Details")]
        public IActionResult DetailsPost(int id, Review review)
        {
            if (!_context.Advertisements.Any(ad => ad.Id == id && ad.IsVerified))
            {
                return PartialView("ErrorPage");
            }
            if (!ModelState.IsValid)
            {
                return PartialView("ErrorPage");
            }
            Review newReview = new Review
            {
                Date = DateTime.Now,
                CustomerName = review.CustomerName,
                Email = review.Email,
                AdvertisementId = id,
                Comment = review.Comment
            };
            _context.Reviews.Add(newReview);
            _context.SaveChanges();
            
            return RedirectToAction(nameof(Details));
        }

        public IActionResult Book(int? id)
        {
            if (id == null || !_context.Advertisements.Any(ad => ad.Id == id))
            {
                return PartialView("ErrorPage");
            }
            BookVM vM = new BookVM
            {
                Advertisement = _context.Advertisements.Where(ad => ad.Id == id).Include(ad => ad.Car).Include(ad => ad.Car.Model).Include(ad => ad.Car.Model.Brand).FirstOrDefault()
            };
            ViewBag.Banner = _context.SectionBanners.Where(b => b.SectionName == "Booking").FirstOrDefault().ImageUrl;
            ViewBag.Price = _context.Cars.Where(c => c.Advertisement.Id == id).FirstOrDefault().Price;
            return View(vM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Book(Order order, int? id)
        {
            if (order == null)
            {
                return PartialView("ErrorPage");
            }

            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            BookVM vM = new BookVM
            {
                Advertisement = _context.Advertisements.Where(ad => ad.Id == id).Include(ad => ad.Car).Include(ad => ad.Car.Model).Include(ad => ad.Car.Model.Brand).FirstOrDefault(),
                Order = order
            };
            if (order.PickDate < DateTime.Now.AddDays(2))
            {
                ModelState.AddModelError("Order.PickDate", "Pick up date must be larger than 3 days from now");
                ViewBag.Banner = _context.SectionBanners.Where(b => b.SectionName == "Booking").FirstOrDefault().ImageUrl;
                ViewBag.Price = _context.Cars.Where(c => c.Advertisement.Id == id).FirstOrDefault().Price;
                return View(vM);
            }
            if (order.ReturnDate <= order.PickDate)
            {
                ModelState.AddModelError("Order.ReturnDate", "Return date is not valid");
                ViewBag.Price = _context.Cars.Where(c => c.Advertisement.Id == id).FirstOrDefault().Price;
                ViewBag.Banner = _context.SectionBanners.Where(b => b.SectionName == "Booking").FirstOrDefault().ImageUrl;
                return View(vM);
            }
            Order newOrder = new Order
            {
                AdvertisementId = (int)id,
                PickDate = order.PickDate,
                ReturnDate = order.ReturnDate,
                Firstname = order.Firstname,
                Lastname = order.Lastname,
                Email = order.Email,
                OrderDate = DateTime.Now,
                ResponseDate = DateTime.Now.AddDays(3),
                IsResponded = false
            };
            await _context.Orders.AddAsync(newOrder);
            await _context.SaveChangesAsync();
            return PartialView("OrderCheckedPartial");
        }
    }
}