using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class OurPassionAboutUs
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string MainHeader { get; set; }
        [Required]
        public string SmallHeader { get; set; }
        public string SectionBannerImage { get; set; }
        [NotMapped]
        public IFormFile SectionPhoto { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
