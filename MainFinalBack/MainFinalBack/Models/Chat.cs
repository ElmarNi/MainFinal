using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public virtual Order Order { get; set; }
        public int OrderId { get; set; }
        public virtual ICollection<ChatMessage> ChatMessages { get; set; }
        public string To { get; set; }
    }
}
