using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, StringLength(100, MinimumLength = 3)]
        public string Firstname { get; set; }

        [StringLength(100)]
        public string Lastname { get; set; }

        public bool IsBlocked { get; set; }

        public virtual ICollection<Advertisement> Advertisements { get; set; }
    }
}
