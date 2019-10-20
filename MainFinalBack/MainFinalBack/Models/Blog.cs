using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required, StringLength(200, MinimumLength = 20)]
        public string Header { get; set; }

        [Required, MinLength(100)]
        public string Content { get; set; }

        public DateTime PublishDate { get; set; }
        
        public DateTime UpdatedDate { get; set; }

        public string MainImageUrl { get; set; }

        [NotMapped]
        public IFormFile MainPhoto { get; set; }

        [NotMapped]
        public ICollection<IFormFile> DetailPhotos { get; set; }

        public virtual ICollection<BlogDetailImage> BlogDetailImages { get; set; }
    }
}
