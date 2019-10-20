using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int AdvertisementId { get; set; }
        public virtual Advertisement Advertisement { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime PickDate { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }

        [Required, StringLength(200)]
        public string Firstname { get; set; }

        [StringLength(200)]
        public string Lastname { get; set; }

        [Required, DataType(DataType.EmailAddress), EmailAddress]
        public string Email { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ResponseDate { get; set; }
        public bool IsResponded { get; set; }

        public virtual Chat Chat { get; set; }

    }
}
