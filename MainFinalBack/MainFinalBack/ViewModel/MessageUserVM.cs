using MainFinalBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.ViewModel
{
    public class MessageUserVM
    {
        public IEnumerable<AdvertisementMessage> AdvertisementMessage { get; set; }
        public IEnumerable<Chat> Chats { get; set; }
    }
}
