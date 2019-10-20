using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class ChatMessage
    {
        public int Id { get; set; }

        public virtual Chat Chat { get; set; }
        public virtual Message Message { get; set; }
        public int MessageId { get; set; }
        public int ChatId { get; set; }
    }
}
