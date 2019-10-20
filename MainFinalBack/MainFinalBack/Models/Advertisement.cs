using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class Advertisement
    {
        public int Id { get; set; }

        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        public DateTime PublishDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool IsVerified { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<AdvertisementMessage> AdvertisementMessages { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
