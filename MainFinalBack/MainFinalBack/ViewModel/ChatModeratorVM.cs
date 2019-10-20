using MainFinalBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.ViewModel
{
    public class ChatModeratorVM
    {
        public IEnumerable<ChatMessage> ChatMessages { get; set; }
        public Message Message { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}
