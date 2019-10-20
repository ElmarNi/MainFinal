using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class CarDetailImage
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public int CarId { get; set; }

        public virtual Car Car { get; set; }
    }
}
