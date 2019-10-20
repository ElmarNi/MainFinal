using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.Models;
using MainFinalBack.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MainFinalBack.Areas.User.Controllers
{
    [Area("User")]
    public class MessageController : Controller
    {
        private readonly RentNowDbContext _context;
        public MessageController(RentNowDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("member"))
            {
                MessageUserVM model = new MessageUserVM
                {
                    AdvertisementMessage = _context.AdvertisementMessages.Where(adM => adM.Advertisement.ApplicationUser.UserName == User.Identity.Name)
                                                            .Include(adM => adM.Message)
                                                            .Include(adM => adM.Advertisement.Car).OrderByDescending(adM => adM.Message.Date),
                    Chats = _context.Chats.Where(cm => cm.Order.Advertisement.ApplicationUser.UserName == User.Identity.Name)
                                                        .Include(cm => cm.Order)
                                                        .Include(cm => cm.Order.Advertisement)
                                                        .Include(cm => cm.Order.Advertisement.Car)
                };
                return View(model);
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }

        public IActionResult Chat(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("member"))
            {
                if (id == null || !_context.Orders.Any(o => o.Id == id && o.Chat.To == _context.Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault().Id))
                {
                    return PartialView("ErrorPage");
                }
                ChatModeratorVM vM = new ChatModeratorVM
                {
                    ApplicationUser = _context.Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault(),
                    ChatMessages = _context.ChatMessages.Where(cm => cm.Chat.OrderId == id && cm.Chat.To == _context.Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault().Id).Include(cm => cm.Chat).Include(cm => cm.Message).Include(cm => cm.Chat.Order).OrderBy(cm => cm.Message.Date)
                };
                return View(vM);
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Chat(Message message, int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("member"))
            {
                if (id == null || !_context.Orders.Any(o => o.Id == id) || message == null)
                {
                    return PartialView("ErrorPage");
                }
                Message newMessage = new Message
                {
                    From = _context.Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault().Id,
                    To = _context.Orders.Where(o => o.Id == id).Include(o => o.Advertisement).Include(o => o.Advertisement.ApplicationUser).FirstOrDefault().Advertisement.ApplicationUserId,
                    Body = message.Body,
                    Date = DateTime.Now,
                };
                await _context.Messages.AddAsync(newMessage);

                ChatMessage newChatMessage = new ChatMessage
                {
                    ChatId = _context.Chats.Where(c => c.OrderId == id).FirstOrDefault().Id,
                    MessageId = newMessage.Id
                };
                await _context.ChatMessages.AddAsync(newChatMessage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Chat));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        public IActionResult Delete(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("member"))
            {
                if (id == null || !_context.AdvertisementMessages.Any(adM => adM.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                AdvertisementMessage advertisementMessage = _context.AdvertisementMessages.Where(adM => adM.Id == id).Include(adM => adM.Message).FirstOrDefault();
                _context.Messages.Remove(advertisementMessage.Message);
                _context.AdvertisementMessages.Remove(advertisementMessage);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
    }
}