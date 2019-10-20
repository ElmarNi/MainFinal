using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.Models;
using MainFinalBack.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MainFinalBack.Controllers
{
    public class AccountController : Controller
    {
        private readonly RentNowDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RentNowDbContext context)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Login()
        {
            ViewBag.IsHeaderNonVisible = true;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.IsHeaderNonVisible = true;
                return View(login);
            }
            ApplicationUser logedUser = await _userManager.FindByEmailAsync(login.Email);
            if (logedUser == null)
            {
                ViewBag.IsHeaderNonVisible = true;
                ModelState.AddModelError("", "Email or Password is invalid");
                return View(login);
            }
            if (!logedUser.EmailConfirmed)
            {
                ViewBag.IsHeaderNonVisible = true;
                ModelState.AddModelError("", "Please confirm your email");
                return View(login);
            }
            if (logedUser.IsBlocked)
            {
                ViewBag.IsHeaderNonVisible = true;
                ModelState.AddModelError("Email", "Your email is blocked");
                return View(login);
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(logedUser, login.Password, false, true);
            if (!result.Succeeded)
            {
                ViewBag.IsHeaderNonVisible = true;
                ModelState.AddModelError("", "Email or Password is invalid");
                return View(login);
            }
            if (await _userManager.IsInRoleAsync(logedUser, "member"))
            {
                return Redirect("/user");
            }
            if (await _userManager.IsInRoleAsync(logedUser, "moderator"))
            {
                return Redirect("/moderator");
            }
            return Redirect("/admin");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/");
        }
        public async Task<IActionResult> ConfirmEmail(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ApplicationUser confirmedUser = await _userManager.FindByIdAsync(id);
            if (confirmedUser == null)
            {
                return NotFound();
            }
            confirmedUser.EmailConfirmed = true;
            await _context.SaveChangesAsync();
            return View(confirmedUser);
        }
        public IActionResult Register()
        {
            ViewBag.IsHeaderNonVisible = true;
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) {
                ViewBag.IsHeaderNonVisible = true;
                return View(registerVM);
            };
            if (registerVM.TermsCheck == false)
            {
                ViewBag.IsHeaderNonVisible = true;
                ModelState.AddModelError("TermsCheck", "Please check terms");
                return View(registerVM);
            }
            ApplicationUser newUser = new ApplicationUser
            {
                Firstname = registerVM.Firstname,
                Lastname = registerVM.Lastname,
                Email = registerVM.Email,
                UserName = registerVM.UserName
            };
            IdentityResult result = await _userManager.CreateAsync(newUser, registerVM.ConfirmPassword);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                ViewBag.IsHeaderNonVisible = true;
                return View(registerVM);
            }
            await _userManager.AddToRoleAsync(newUser, "member");
            SmtpClient client = new SmtpClient("smtp.office365.com", 587)
            {
                UseDefaultCredentials = false,
                EnableSsl = true,
                Credentials = new NetworkCredential("rentnow@elmaribrahimli.com", "elmar1999@")
            };

            MailMessage message = new MailMessage("rentnow@elmaribrahimli.com", registerVM.Email)
            {
                IsBodyHtml = true,
                Subject = "Confirm Email",
                Body = $"<a href='http://www.therentnow.com/Account/ConfirmEmail/{newUser.Id}'>Dear {newUser.Firstname} {newUser.Lastname},please confirm your email </a>"+
                            "<div style='width:100%'>" +
                                "<div style='width:23%;display:inline-block;background-color:#1876D2;height:3px'></div>" +
                                "<h3 style='font-size: 1.80203rem;line-height: 36px;margin:0;margin-bottom:20px'>Elmar Ibrahimli</h3>" +
                                "<p style='color:#00D231; display:inline;font-size: 30px;font-style: italic;font-weight: bold;'>RENT</p><p style='color:black; display:inline;font-size: 30px;font-style: italic;font-weight: bold;'>NOW</p>" +
                                "<a href='tel:+994703347347' style='color: rgb(9,117,122);display:block'> +994703347347</a>" +
                                "<a href='www.therentnow.com' target='_blank' style='color: rgb(9,117,122);display:block'>therentnow.com</a>" +
                            "</div>"
            };
            await client.SendMailAsync(message);
            return RedirectToAction(nameof(Login));
        }

        public IActionResult ForgotPassword()
        {
            ViewBag.IsHeaderNonVisible = true;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordVM model)
        {
            if (model == null)
            {
                return PartialView("ErrorPage");
            }
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            ApplicationUser user = await _userManager.FindByEmailAsync(model.Email);
            SmtpClient client = new SmtpClient("smtp.office365.com", 587)
            {
                UseDefaultCredentials = false,
                EnableSsl = true,
                Credentials = new NetworkCredential("rentnow@elmaribrahimli.com", "elmar1999@")
            };

            MailMessage message = new MailMessage("rentnow@elmaribrahimli.com", model.Email)
            {
                IsBodyHtml = true,
                Subject = "Change password",
                Body = $"<a href='http://www.therentnow.com/Account/ChangePassword/{user.Id}'>Dear {user.Firstname} {user.Lastname},click for change password</a>" +
                            "<div style='width:100%'>" +
                                "<div style='width:23%;display:inline-block;background-color:#1876D2;height:3px'></div>" +
                                "<h3 style='font-size: 1.80203rem;line-height: 36px;margin:0;margin-bottom:20px'>Elmar Ibrahimli</h3>" +
                                "<p style='color:#00D231; display:inline;font-size: 30px;font-style: italic;font-weight: bold;'>RENT</p><p style='color:black; display:inline;font-size: 30px;font-style: italic;font-weight: bold;'>NOW</p>" +
                                "<a href='tel:+994703347347' style='color: rgb(9,117,122);display:block'> +994703347347</a>" +
                                "<a href='www.therentnow.com' target='_blank' style='color: rgb(9,117,122);display:block'>therentnow.com</a>" +
                            "</div>"
            };
            await client.SendMailAsync(message);
            return PartialView("CheckEmailForgotPassword");
        }

        public async Task<IActionResult> ChangePassword(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ChangePasswordVM model = new ChangePasswordVM { User = user };
            ViewBag.IsHeaderNonVisible = true;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(string id, ChangePasswordVM model)
        {
            if (id == null || model == null || !ModelState.IsValid)
            {
                return NotFound();
            }
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
            await _userManager.ResetPasswordAsync(user, token, model.ConfirmPassword);
            await _context.SaveChangesAsync();
            ViewBag.IsHeaderNonVisible = true;
            return PartialView("PasswordChanged");
        }
    }
}