using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class SectionBanner
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped, Required]
        public IFormFile Photo { get; set; }
    }
}
