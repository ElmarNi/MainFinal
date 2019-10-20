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

namespace MainFinalBack.Areas.User.Controllers
{
    [Area("User")]
    public class AdvertisementController : Controller
    {
        private readonly RentNowDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHostingEnvironment _env;

        public AdvertisementController(UserManager<ApplicationUser> userManager, RentNowDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _userManager = userManager;
            _env = environment;
        }
        public async Task<IActionResult> Index()
        {
            ApplicationUser user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                ViewBag.IsHeaderNonVisible = true;
                return Redirect("/account/login");
            }
            if (!User.IsInRole("member"))
            {
                ViewBag.IsHeaderNonVisible = true;
                return Redirect("/account/login");
            }
            return View(_context.Advertisements.Where(ad => ad.ApplicationUserId == user.Id)
                                                .Include(ad => ad.Car)
                                                .Include(ad => ad.Car.Model)
                                                .Include(ad => ad.Car.Model.Brand)
                                                .Include(ad => ad.Car.Transmission)
                                                .Include(ad => ad.Car.City.Country)
                                                .Include(ad => ad.Car.City)
                                                .Include(ad => ad.Car.Color)
                                                .Include(ad => ad.Car.FuelType));
        }

        public IActionResult Edit(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("member"))
            {
                if (id == null)
                {
                    return PartialView("ErrorPage");
                }
                if (!_context.Advertisements.Any(ad => ad.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                if (!_context.Advertisements.Where(ad => ad.Id == id).Any(ad => ad.ApplicationUser.UserName == User.Identity.Name))
                {
                    return PartialView("ErrorPage");
                }
                ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                ViewBag.Categories = _context.CarClasses;
                ViewBag.BodyTypes = _context.BodyTypes;
                ViewBag.Transmissons = _context.Transmissions;
                ViewBag.FuelTypes = _context.FuelTypes;
                ViewBag.Colors = _context.Colors;
                ViewBag.WheelDrives = _context.WheelDrives;
                var vievModel = _context.Advertisements.Where(ad => ad.Id == id)
                                                    .Include(ad => ad.Car)
                                                    .Include(ad => ad.Car.CarDetailImages)
                                                    .Include(ad => ad.Car.Transmission)
                                                    .Include(ad => ad.Car.FuelType)
                                                    .Include(ad => ad.Car.Color)
                                                    .Include(ad => ad.Car.Model)
                                                    .Include(ad => ad.Car.Model.Brand)
                                                    .Include(ad => ad.Car.City)
                                                    .Include(ad => ad.Car.City.Country)
                                                    .Include(ad => ad.Car.BodyType)
                                                    .Include(ad => ad.Car.CarClass)
                                                    .Include(ad => ad.Car.WheelDrive).FirstOrDefault();
                return View(vievModel);
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Advertisement advertisement)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("member"))
            {
                if (advertisement == null)
                {
                    return PartialView("ErrorPage");
                }
                if (!ModelState.IsValid)
                {
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    return NotFound();
                }
                if (!_context.Models.Any(m => m.Id == advertisement.Car.ModelId))
                {
                    ModelState.AddModelError("Car.ModelId", "Model is not accessible");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    advertisement.Car.CarDetailImages = _context.CarDetailImages.Where(c => c.Car.Advertisement.Id == advertisement.Id).ToList();
                    advertisement.Car = await _context.Cars.Where(c => c.Advertisement.Id == advertisement.Id).FirstOrDefaultAsync();
                    return View(advertisement);
                }
                if (!_context.Cities.Any(c => c.Id == advertisement.Car.CityId))
                {
                    ModelState.AddModelError("Car.CityId", "City is not accessible");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    advertisement.Car.CarDetailImages = _context.CarDetailImages.Where(c => c.Car.Advertisement.Id == advertisement.Id).ToList();
                    advertisement.Car = await _context.Cars.Where(c => c.Advertisement.Id == advertisement.Id).FirstOrDefaultAsync();
                    return View(advertisement);
                }
                if (!_context.BodyTypes.Any(b => b.Id == advertisement.Car.BodyTypeId))
                {
                    ModelState.AddModelError("Car.BodyTypeId", "Body type is not accessible");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    advertisement.Car.CarDetailImages = _context.CarDetailImages.Where(c => c.Car.Advertisement.Id == advertisement.Id).ToList();
                    advertisement.Car = await _context.Cars.Where(c => c.Advertisement.Id == advertisement.Id).FirstOrDefaultAsync();
                    return View(advertisement);
                }
                if (!_context.Transmissions.Any(t => t.Id == advertisement.Car.TransmissionId))
                {
                    ModelState.AddModelError("Car.TransmissionId", "Transmission is not accessible");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    advertisement.Car.CarDetailImages = _context.CarDetailImages.Where(c => c.Car.Advertisement.Id == advertisement.Id).ToList();
                    advertisement.Car = await _context.Cars.Where(c => c.Advertisement.Id == advertisement.Id).FirstOrDefaultAsync();
                    return View(advertisement);
                }
                if (!_context.FuelTypes.Any(f => f.Id == advertisement.Car.FuelTypeId))
                {
                    ModelState.AddModelError("Car.FuelTypeId", "Fuel type is not accessible");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    advertisement.Car.CarDetailImages = _context.CarDetailImages.Where(c => c.Car.Advertisement.Id == advertisement.Id).ToList();
                    advertisement.Car = await _context.Cars.Where(c => c.Advertisement.Id == advertisement.Id).FirstOrDefaultAsync();
                    return View(advertisement);
                }
                if (!_context.Colors.Any(c => c.Id == advertisement.Car.ColorId))
                {
                    ModelState.AddModelError("Car.ColorId", "Color is not accessible");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    advertisement.Car.CarDetailImages = _context.CarDetailImages.Where(c => c.Car.Advertisement.Id == advertisement.Id).ToList();
                    advertisement.Car = await _context.Cars.Where(c => c.Advertisement.Id == advertisement.Id).FirstOrDefaultAsync();
                    return View(advertisement);
                }
                if (!_context.WheelDrives.Any(w => w.Id == advertisement.Car.WheelDriveId))
                {
                    ModelState.AddModelError("Car.WheelDriveId", "Wheel drive class is not accessible");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    advertisement.Car.CarDetailImages = _context.CarDetailImages.Where(c => c.Car.Advertisement.Id == advertisement.Id).ToList();
                    advertisement.Car = await _context.Cars.Where(c => c.Advertisement.Id == advertisement.Id).FirstOrDefaultAsync();
                    return View(advertisement);
                }
                if (advertisement.Car.ManufactureYear < 1900 || advertisement.Car.ManufactureYear > DateTime.Now.Year)
                {
                    ModelState.AddModelError("Car.ManufactureYear", $"Manufacture year must be between 1900 and {DateTime.Now.Year}");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    advertisement.Car.CarDetailImages = _context.CarDetailImages.Where(c => c.Car.Advertisement.Id == advertisement.Id).ToList();
                    advertisement.Car = await _context.Cars.Where(c => c.Advertisement.Id == advertisement.Id).FirstOrDefaultAsync();
                    return View(advertisement);
                }

                Advertisement adFromDb = await _context.Advertisements.Where(ad => ad.Id == advertisement.Id)
                                                                        .Include(ad => ad.Car)
                                                                        .Include(ad => ad.Car.CarDetailImages)
                                                                        .Include(ad => ad.Car.Transmission)
                                                                        .Include(ad => ad.Car.FuelType)
                                                                        .Include(ad => ad.Car.Color)
                                                                        .Include(ad => ad.Car.Model)
                                                                        .Include(ad => ad.Car.Model.Brand)
                                                                        .Include(ad => ad.Car.City)
                                                                        .Include(ad => ad.Car.City.Country)
                                                                        .Include(ad => ad.Car.BodyType)
                                                                        .Include(ad => ad.Car.CarClass)
                                                                        .Include(ad => ad.Car.WheelDrive).FirstOrDefaultAsync();
                if (advertisement.Car.Photo != null)
                {
                    if (!advertisement.Car.Photo.ContentType.Contains("image/"))
                    {
                        ModelState.AddModelError("Car.Photo", "File type should be image");
                        ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                        ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                        ViewBag.Categories = _context.CarClasses;
                        ViewBag.BodyTypes = _context.BodyTypes;
                        ViewBag.Transmissons = _context.Transmissions;
                        ViewBag.FuelTypes = _context.FuelTypes;
                        ViewBag.Colors = _context.Colors;
                        ViewBag.WheelDrives = _context.WheelDrives;
                        advertisement.Car.CarDetailImages = _context.CarDetailImages.Where(c => c.Car.Advertisement.Id == advertisement.Id).ToList();
                        advertisement.Car = await _context.Cars.Where(c => c.Advertisement.Id == advertisement.Id).FirstOrDefaultAsync();
                        return View(advertisement);
                    }
                    RemovePhoto(_env.WebRootPath, _context.Cars.Where(c => c.Advertisement.Id == advertisement.Id).FirstOrDefault().MainImageUrl);
                    adFromDb.Car.MainImageUrl = await advertisement.Car.Photo.SavePhotoAsync(_env.WebRootPath, "advertisements");
                }
                if (advertisement.Car.DetailPhotos != null)
                {
                    foreach (var photo in advertisement.Car.DetailPhotos)
                    {
                        if (!photo.ContentType.Contains("image/"))
                        {
                            ModelState.AddModelError("Car.DetailPhotos", "File type should be image");
                            ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                            ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                            ViewBag.Categories = _context.CarClasses;
                            ViewBag.BodyTypes = _context.BodyTypes;
                            ViewBag.Transmissons = _context.Transmissions;
                            ViewBag.FuelTypes = _context.FuelTypes;
                            ViewBag.Colors = _context.Colors;
                            ViewBag.WheelDrives = _context.WheelDrives;
                            advertisement.Car.CarDetailImages = _context.CarDetailImages.Where(c => c.Car.Advertisement.Id == advertisement.Id).ToList();
                            advertisement.Car = await _context.Cars.Where(c => c.Advertisement.Id == advertisement.Id).FirstOrDefaultAsync();
                            return View(advertisement);
                        }

                        //await _context.SaveChangesAsync();
                    }
                    foreach (var photo in advertisement.Car.DetailPhotos)
                    {
                        CarDetailImage detailImage = new CarDetailImage
                        {
                            CarId = adFromDb.CarId,
                            ImageUrl = await photo.SavePhotoAsync(_env.WebRootPath, "advertisements")
                        };
                        await _context.CarDetailImages.AddAsync(detailImage);
                    }
                }
                if (advertisement.Car.Price <= 100)
                {
                    adFromDb.Car.CarClassId = 1;
                }
                if (advertisement.Car.Price > 100 && advertisement.Car.Price <= 200)
                {
                    adFromDb.Car.CarClassId = 2;
                }
                if (advertisement.Car.Price > 200)
                {
                    adFromDb.Car.CarClassId = 3;
                }
                adFromDb.Car.ModelId = advertisement.Car.ModelId;
                adFromDb.Car.ColorId = advertisement.Car.ColorId;
                adFromDb.Car.Description = advertisement.Car.Description;
                adFromDb.Car.FuelTypeId = advertisement.Car.FuelTypeId;
                adFromDb.Car.IsVip = advertisement.Car.IsVip;
                adFromDb.Car.ManufactureYear = advertisement.Car.ManufactureYear;
                adFromDb.Car.Milage = advertisement.Car.Milage;
                adFromDb.Car.Engine = advertisement.Car.Engine;
                adFromDb.Car.Price = advertisement.Car.Price;
                adFromDb.Car.TransmissionId = advertisement.Car.TransmissionId;
                adFromDb.Car.CityId = advertisement.Car.CityId;
                adFromDb.Car.BodyTypeId = advertisement.Car.BodyTypeId;
                adFromDb.Car.WheelDriveId = advertisement.Car.WheelDriveId;
                adFromDb.UpdatedDate = DateTime.Now;

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        public IActionResult Create()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("member"))
            {
                ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                ViewBag.Categories = _context.CarClasses;
                ViewBag.BodyTypes = _context.BodyTypes;
                ViewBag.Transmissons = _context.Transmissions;
                ViewBag.FuelTypes = _context.FuelTypes;
                ViewBag.Colors = _context.Colors;
                ViewBag.WheelDrives = _context.WheelDrives;
                return View();
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Advertisement advertisement)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("member"))
            {
                if (advertisement == null)
                {
                    return PartialView("ErrorPage");
                }
                if (!ModelState.IsValid)
                {
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    return NotFound();
                }
                if (!_context.Models.Any(m => m.Id == advertisement.Car.ModelId))
                {
                    ModelState.AddModelError("Car.ModelId", "Model is not accessible");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    return View(advertisement);
                }
                if (!_context.Cities.Any(c => c.Id == advertisement.Car.CityId))
                {
                    ModelState.AddModelError("Car.CityId", "City is not accessible");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    return View(advertisement);
                }
                if (!_context.BodyTypes.Any(b => b.Id == advertisement.Car.BodyTypeId))
                {
                    ModelState.AddModelError("Car.BodyTypeId", "Body type is not accessible");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    return View(advertisement);
                }
                if (!_context.Transmissions.Any(t => t.Id == advertisement.Car.TransmissionId))
                {
                    ModelState.AddModelError("Car.TransmissionId", "Transmission is not accessible");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    return View(advertisement);
                }
                if (!_context.FuelTypes.Any(f => f.Id == advertisement.Car.FuelTypeId))
                {
                    ModelState.AddModelError("Car.FuelTypeId", "Fuel type is not accessible");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    return View(advertisement);
                }
                if (!_context.Colors.Any(c => c.Id == advertisement.Car.ColorId))
                {
                    ModelState.AddModelError("Car.ColorId", "Color is not accessible");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    return View(advertisement);
                }
                if (!_context.WheelDrives.Any(w => w.Id == advertisement.Car.WheelDriveId))
                {
                    ModelState.AddModelError("Car.WheelDriveId", "Wheel drive class is not accessible");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    return View(advertisement);
                }
                if (advertisement.Car.ManufactureYear < 1900 || advertisement.Car.ManufactureYear > DateTime.Now.Year)
                {
                    ModelState.AddModelError("Car.ManufactureYear", $"Manufacture year must be between 1900 and {DateTime.Now.Year}");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    return View(advertisement);
                }
                Car newCar = new Car
                {
                    BodyTypeId = advertisement.Car.BodyTypeId,
                    CityId = advertisement.Car.CityId,
                    ColorId = advertisement.Car.ColorId,
                    Description = advertisement.Car.Description,
                    Engine = advertisement.Car.Engine,
                    FuelTypeId = advertisement.Car.FuelTypeId,
                    IsVip = advertisement.Car.IsVip,
                    ManufactureYear = advertisement.Car.ManufactureYear,
                    Milage = advertisement.Car.Milage,
                    ModelId = advertisement.Car.ModelId,
                    Price = advertisement.Car.Price,
                    TransmissionId = advertisement.Car.TransmissionId,
                    WheelDriveId = advertisement.Car.WheelDriveId
                };
                if (advertisement.Car.Price <= 100)
                {
                    newCar.CarClassId = 1;
                }
                if (advertisement.Car.Price > 100 && advertisement.Car.Price <=200)
                {
                    newCar.CarClassId = 2;
                }
                if (advertisement.Car.Price > 200)
                {
                    newCar.CarClassId = 3;
                }
                await _context.AddAsync(newCar);
                if (advertisement.Car.Photo == null)
                {
                    ModelState.AddModelError("Car.Photo", "Main image should be selected");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    return View(advertisement);
                }
                if (!advertisement.Car.Photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Car.Photo", "File type should be image");
                    ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                    ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                    ViewBag.Categories = _context.CarClasses;
                    ViewBag.BodyTypes = _context.BodyTypes;
                    ViewBag.Transmissons = _context.Transmissions;
                    ViewBag.FuelTypes = _context.FuelTypes;
                    ViewBag.Colors = _context.Colors;
                    ViewBag.WheelDrives = _context.WheelDrives;
                    return View(advertisement);
                }
                newCar.MainImageUrl = await advertisement.Car.Photo.SavePhotoAsync(_env.WebRootPath, "advertisements");
                if (advertisement.Car.DetailPhotos != null)
                {
                    foreach (var photo in advertisement.Car.DetailPhotos)
                    {
                        if (!photo.ContentType.Contains("image/"))
                        {
                            ModelState.AddModelError("Car.DetailPhotos", "File type should be image");
                            ViewBag.Brands = _context.Brands.OrderBy(b => b.Name);
                            ViewBag.Countries = _context.Countries.OrderBy(c => c.Name);
                            ViewBag.Categories = _context.CarClasses;
                            ViewBag.BodyTypes = _context.BodyTypes;
                            ViewBag.Transmissons = _context.Transmissions;
                            ViewBag.FuelTypes = _context.FuelTypes;
                            ViewBag.Colors = _context.Colors;
                            ViewBag.WheelDrives = _context.WheelDrives;
                            return View(advertisement);
                        }
                    }
                    foreach (var photo in advertisement.Car.DetailPhotos)
                    {
                        CarDetailImage detailImage = new CarDetailImage
                        {
                            CarId = newCar.Id,
                            ImageUrl = await photo.SavePhotoAsync(_env.WebRootPath, "advertisements")
                        };
                        await _context.CarDetailImages.AddAsync(detailImage);
                    }
                }
                Advertisement newAd = new Advertisement
                {
                    CarId = newCar.Id,
                    ApplicationUserId = _userManager.GetUserId(User),
                    PublishDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    IsVerified = false
                };
                await _context.AddAsync(newAd);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("member"))
            {
                if (id == null)
                {
                    return PartialView("ErrorPage");
                }
                if (!_context.Advertisements.Any(ad => ad.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                if (!_context.Advertisements.Where(ad => ad.Id == id).Any(ad => ad.ApplicationUser.UserName == User.Identity.Name))
                {
                    return PartialView("ErrorPage");
                }
                Advertisement advertisement = await _context.Advertisements.Where(ad => ad.Id == id).FirstOrDefaultAsync();
                Car car = await _context.Cars.Where(c => c.Id == advertisement.CarId).Include(c => c.CarDetailImages).FirstOrDefaultAsync();
                foreach (var img in car.CarDetailImages)
                {
                    RemovePhoto(_env.WebRootPath, img.ImageUrl);
                }
                RemovePhoto(_env.WebRootPath, car.MainImageUrl);
                _context.Remove(car);
                _context.Remove(advertisement);
                await _context.SaveChangesAsync();
                return Redirect("/user/Advertisement");
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

    }
}