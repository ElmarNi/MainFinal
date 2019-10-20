using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class BlogDetailImage
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
