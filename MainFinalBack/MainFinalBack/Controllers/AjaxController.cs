using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.Models;
using MainFinalBack.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static MainFinalBack.Extensions.IFormFileEx;
namespace MainFinalBack.Controllers
{
    public class AjaxController : Controller
    {
        private readonly RentNowDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly UserManager<ApplicationUser> _userManager;

        public AjaxController(RentNowDbContext context, IWebHostEnvironment env, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _env = env;
            _userManager = userManager;
        }
        public IActionResult LoadBlogs(int skip)
        {
            var model = _context.Blogs.OrderByDescending(blog => blog.UpdatedDate).Skip(skip).Take(2);
            return PartialView("_LoadBlogsPartialView", model);
        }
        public IActionResult LoadCitiesByCountryId(int countryId)
        {
            return PartialView("_FilteredCitiesByCountryId", _context.Cities.Where(city => city.CountryId == countryId).OrderBy(c=> c.Name));
        }
        public IActionResult LoadModelsByBrandId(int brandId)
        {
            return PartialView("_FilteredModelsByBrandId", _context.Models.Where(m => m.BrandId == brandId).OrderBy(m => m.Name));
        }
        public IEnumerable<Advertisement> GetAdvertisements(int? modelId, int? cityId, int? categoryId, int skip)
        {
            if (categoryId == null && modelId == null && cityId == null)
            {
                ViewBag.SelectedAdCount = _context.Advertisements.Where(ad => ad.IsVerified).Count();
                return _context.Advertisements.Where(ad => ad.IsVerified).Include(ad => ad.Car)
                                              .Include(ad => ad.Car.CarClass)
                                              .Include(ad => ad.Car.Transmission)
                                              .Include(ad => ad.Car.City)
                                              .Include(ad => ad.Car.City.Country)
                                              .Include(ad => ad.Car.Model.Brand)
                                              .Include(ad => ad.Car.Model)
                                          .OrderBy(ad => ad.Car.Price)
                                          .OrderBy(ad => ad.Car.Model.Brand.Name).Skip(skip).Take(3);
            }
            if (modelId != null && cityId == null && categoryId == null)
            {
                ViewBag.SelectedAdCount = _context.Advertisements.Where(ad => ad.Car.ModelId == modelId && ad.IsVerified).Count();
                return _context.Advertisements.Where(ad => ad.Car.ModelId == modelId && ad.IsVerified)
                                              .Include(ad => ad.Car)
                                              .Include(ad => ad.Car.CarClass)
                                              .Include(ad => ad.Car.Transmission)
                                              .Include(ad => ad.Car.City)
                                              .Include(ad => ad.Car.City.Country)
                                              .Include(ad => ad.Car.Model.Brand)
                                              .Include(ad => ad.Car.Model)
                                          .OrderBy(ad => ad.Car.Price)
                                          .OrderBy(ad => ad.Car.Model.Brand.Name).Skip(skip).Take(3);
            }
            if (modelId != null && cityId != null && categoryId == null)
            {
                ViewBag.SelectedAdCount = _context.Advertisements.Where(ad => ad.Car.ModelId == modelId && ad.Car.CityId == cityId && ad.IsVerified).Count();
                return _context.Advertisements.Where(ad => ad.Car.ModelId == modelId && ad.Car.CityId == cityId && ad.IsVerified)
                                              .Include(ad => ad.Car)
                                              .Include(ad => ad.Car.CarClass)
                                              .Include(ad => ad.Car.Transmission)
                                              .Include(ad => ad.Car.City)
                                              .Include(ad => ad.Car.City.Country)
                                              .Include(ad => ad.Car.Model.Brand)
                                              .Include(ad => ad.Car.Model)
                                          .OrderBy(ad => ad.Car.Price)
                                          .OrderBy(ad => ad.Car.Model.Brand.Name).Skip(skip).Take(3);
            }
            if (modelId != null && cityId != null && categoryId != null)
            {
                ViewBag.SelectedAdCount = _context.Advertisements.Where(ad => ad.Car.ModelId == modelId && ad.Car.CityId == cityId && ad.Car.CarClassId == categoryId && ad.IsVerified).Count();
                return _context.Advertisements.Where(ad => ad.Car.ModelId == modelId && ad.Car.CityId == cityId && ad.Car.CarClassId == categoryId && ad.IsVerified)
                                              .Include(ad => ad.Car)
                                              .Include(ad => ad.Car.CarClass)
                                              .Include(ad => ad.Car.Transmission)
                                              .Include(ad => ad.Car.City)
                                              .Include(ad => ad.Car.City.Country)
                                              .Include(ad => ad.Car.Model.Brand)
                                              .Include(ad => ad.Car.Model)
                                          .OrderBy(ad => ad.Car.Price)
                                          .OrderBy(ad => ad.Car.Model.Brand.Name).Skip(skip).Take(3);
            }
            if (modelId == null && cityId != null && categoryId == null)
            {
                ViewBag.SelectedAdCount = _context.Advertisements.Where(ad => ad.Car.CityId == cityId && ad.IsVerified).Count();
                return _context.Advertisements.Where(ad => ad.Car.CityId == cityId && ad.IsVerified)
                                              .Include(ad => ad.Car)
                                              .Include(ad => ad.Car.CarClass)
                                              .Include(ad => ad.Car.Transmission)
                                              .Include(ad => ad.Car.City)
                                              .Include(ad => ad.Car.City.Country)
                                              .Include(ad => ad.Car.Model.Brand)
                                              .Include(ad => ad.Car.Model)
                                          .OrderBy(ad => ad.Car.Price)
                                          .OrderBy(ad => ad.Car.Model.Brand.Name).Skip(skip).Take(3);
            }
            if (modelId == null && cityId != null && categoryId != null)
            {
                ViewBag.SelectedAdCount = _context.Advertisements.Where(ad => ad.Car.CityId == cityId && ad.Car.CarClassId == categoryId && ad.IsVerified).Count();
                return _context.Advertisements.Where(ad => ad.Car.CityId == cityId && ad.Car.CarClassId == categoryId && ad.IsVerified)
                                              .Include(ad => ad.Car)
                                              .Include(ad => ad.Car.CarClass)
                                              .Include(ad => ad.Car.Transmission)
                                              .Include(ad => ad.Car.City)
                                              .Include(ad => ad.Car.City.Country)
                                              .Include(ad => ad.Car.Model.Brand)
                                              .Include(ad => ad.Car.Model)
                                          .OrderBy(ad => ad.Car.Price)
                                          .OrderBy(ad => ad.Car.Model.Brand.Name).Skip(skip).Take(3);
            }
            if (modelId == null && cityId == null && categoryId != null)
            {
                ViewBag.SelectedAdCount = _context.Advertisements.Where(ad =>ad.Car.CarClassId == categoryId && ad.IsVerified).Count();
                return _context.Advertisements.Where(ad =>ad.Car.CarClassId == categoryId && ad.IsVerified)
                                              .Include(ad => ad.Car)
                                              .Include(ad => ad.Car.CarClass)
                                              .Include(ad => ad.Car.Transmission)
                                              .Include(ad => ad.Car.City)
                                              .Include(ad => ad.Car.City.Country)
                                              .Include(ad => ad.Car.Model.Brand)
                                              .Include(ad => ad.Car.Model)
                                          .OrderBy(ad => ad.Car.Price)
                                          .OrderBy(ad => ad.Car.Model.Brand.Name).Skip(skip).Take(3);
            }
            if (modelId != null && cityId == null && categoryId != null)
            {
                ViewBag.SelectedAdCount = _context.Advertisements.Where(ad => ad.Car.ModelId == modelId && ad.Car.CarClassId == categoryId && ad.IsVerified).Count();
                return _context.Advertisements.Where(ad => ad.Car.ModelId == modelId && ad.Car.CarClassId == categoryId && ad.IsVerified)
                                              .Include(ad => ad.Car)
                                              .Include(ad => ad.Car.CarClass)
                                              .Include(ad => ad.Car.Transmission)
                                              .Include(ad => ad.Car.City)
                                              .Include(ad => ad.Car.City.Country)
                                              .Include(ad => ad.Car.Model.Brand)
                                              .Include(ad => ad.Car.Model)
                                              .OrderBy(ad => ad.Car.Price)
                                              .OrderBy(ad => ad.Car.Model.Brand.Name).Skip(skip).Take(3);
            }
            ViewBag.SelectedAdCount = _context.Advertisements.Where(ad => ad.IsVerified).Count();
            return _context.Advertisements.Where(ad => ad.IsVerified)
                                          .Include(ad => ad.Car)
                                          .Include(ad => ad.Car.CarClass)
                                          .Include(ad => ad.Car.Transmission)
                                          .Include(ad => ad.Car.City)
                                          .Include(ad => ad.Car.City.Country)
                                          .Include(ad => ad.Car.Model.Brand)
                                          .Include(ad => ad.Car.Model)
                                          .OrderBy(ad => ad.Car.Price)
                                          .OrderBy(ad => ad.Car.Model.Brand.Name).Skip(skip).Take(3);
        }
        public void DeleteDetailImage(int? id)
        {
            CarDetailImage detailImage = _context.CarDetailImages.Where(cd => cd.Id == id).FirstOrDefault();
            RemovePhoto(_env.WebRootPath, detailImage.ImageUrl);
            _context.CarDetailImages.Remove(detailImage);
            _context.SaveChanges();
        }
        public void DeleteDetailImageBlog(int? id)
        {
            BlogDetailImage detailImage = _context.BlogDetailImages.Where(cd => cd.Id == id).FirstOrDefault();
            RemovePhoto(_env.WebRootPath, detailImage.ImageUrl);
            _context.BlogDetailImages.Remove(detailImage);
            _context.SaveChanges();
        }
        public IActionResult LoadCars(int? modelId, int? cityId, int? categoryId, int skip)
        {
            return PartialView("_LoadCars", GetAdvertisements(modelId , cityId, categoryId, skip));
        }
        public IActionResult LoadCitiesTable(int id)
        {
            var model = _context.Cities.Where(c => c.CountryId == id).OrderBy(c => c.Name);
            return PartialView("_LoadCitiesTableAdmin", model);
        }
        public IActionResult LoadModelsTable(int id)
        {
            var model = _context.Models.Where(m => m.BrandId == id).OrderBy(m => m.Name);
            return PartialView("_LoadModelsTableAdmin", model);
        }
        public async Task<IActionResult> Moderators(string moderatorId)
        {
            if (moderatorId == null || !_context.Users.Any(u => u.Id == moderatorId))
            {
                return NotFound();
            }
            ApplicationUser user = _context.Users.Where(u => u.Id == moderatorId).FirstOrDefault();
            if (user.IsBlocked)
            {
                user.IsBlocked = false;
            }
            else
            {
                user.IsBlocked = true;
            }
            IList<ApplicationUser> users = await _userManager.GetUsersInRoleAsync("moderator");

            _context.SaveChanges();
            return PartialView("_LoadModerators", users);
        }
        public async Task<IActionResult> DeleteReview(int id)
        {
            Review review = await _context.Reviews.FindAsync(id);
            int adId = review.AdvertisementId;
            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();
            return PartialView("_LoadReviewsPartial", _context.Reviews.Where(r => r.AdvertisementId == adId).OrderByDescending(r => r.Date));
        }
        public IActionResult LoadBrandsAdmin(int skip)
        {
            var model = _context.Brands.OrderBy(b => b.Name).Skip(skip).Take(10);
            return PartialView("LoadBrandsAdmin", model);
        }
        public IActionResult LoadCountriesAdmin(int skip)
        {
            var model = _context.Countries.OrderBy(b => b.Name).Skip(skip).Take(10);
            return PartialView("LoadCountriesAdmin", model);
        }
    }
}