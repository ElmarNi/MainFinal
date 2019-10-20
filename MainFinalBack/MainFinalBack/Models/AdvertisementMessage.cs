using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class AdvertisementMessage
    {
        public int Id { get; set; }
        public int AdvertisementId { get; set; }
        public virtual Advertisement Advertisement { get; set; }
        public virtual Message Message { get; set; }
        public int MessageId { get; set; }
    }
}
