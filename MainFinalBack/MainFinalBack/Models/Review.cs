using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string CustomerName { get; set; }

        [EmailAddress, DataType(DataType.EmailAddress), Required]
        public string Email { get; set; }

        public DateTime Date { get; set; }

        [Required, StringLength(1000)]
        public string Comment { get; set; }

        public int AdvertisementId { get; set; }

        public virtual Advertisement Advertisement { get; set; }
    }
}
