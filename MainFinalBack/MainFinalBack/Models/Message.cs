using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string Body { get; set; }

        public virtual AdvertisementMessage AdvertisementMessage { get; set; }
        public virtual ChatMessage ChatMessage { get; set; }
    }
}
