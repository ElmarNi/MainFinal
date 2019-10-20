using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class OurVisionAboutUs
    {
        public int Id { get; set; }

        [Required]
        public string Header { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
