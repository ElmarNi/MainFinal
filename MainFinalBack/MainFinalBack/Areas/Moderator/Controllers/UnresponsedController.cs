using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainFinalBack.DAL;
using MainFinalBack.Models;
using MainFinalBack.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MainFinalBack.Areas.Moderator.Controllers
{
    [Area("Moderator")]
    public class UnresponsedController : Controller
    {
        private readonly RentNowDbContext _context;
        public UnresponsedController(RentNowDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                return View(_context.Orders.Where(o => o.IsResponded == false && o.ResponseDate <= DateTime.Now).Include(o => o.Advertisement.Car).Include(o => o.Advertisement.ApplicationUser));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
        public IActionResult Chat(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (id == null || !_context.Orders.Any(o => o.Id == id))
                {
                    return PartialView("ErrorPage");
                }
                if (!_context.Chats.Any(c => c.OrderId == id))
                {
                    Chat newChat = new Chat
                    {
                        OrderId = (int)id,
                        To = _context.Orders.Where(o => o.Id == id).Include(o => o.Advertisement).FirstOrDefault().Advertisement.ApplicationUserId,
                    };
                    _context.Chats.Add(newChat);
                    _context.SaveChanges();
                }
                ViewBag.Moderator = true;
                ChatModeratorVM vM = new ChatModeratorVM {
                    ApplicationUser = _context.Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault(),
                    ChatMessages = _context.ChatMessages.Where(cm => cm.Chat.OrderId == id).Include(cm => cm.Chat).Include(cm => cm.Message).Include(cm => cm.Chat.Order).OrderBy(cm => cm.Message.Date)
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
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (id == null || !_context.Orders.Any(o => o.Id == id) || message == null)
                {
                    return PartialView("ErrorPage");
                }
                Message newMessage = new Message
                {
                    From = "moderator",
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
        public async Task<IActionResult> RemoveChat(int? id)
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("moderator"))
            {
                if (id == null || !_context.Chats.Any(c => c.OrderId == id) || !_context.Orders.Any(o => o.Id == id && o.IsResponded == false && o.ReturnDate < DateTime.Now))
                {
                    return PartialView("ErrorPage");
                }
                _context.Messages.RemoveRange(_context.Messages.Where(m => m.ChatMessage.Chat.OrderId == id));
                _context.ChatMessages.RemoveRange(_context.ChatMessages.Where(cm => cm.Chat.OrderId == id));
                _context.Chats.Remove(_context.Chats.Where(c => c.OrderId == id).FirstOrDefault());
                _context.Orders.Remove(_context.Orders.Where(o => o.Id == id).FirstOrDefault());
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.IsHeaderNonVisible = true;
            return Redirect("/account/login");
        }
    }
}