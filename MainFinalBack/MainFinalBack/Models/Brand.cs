using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class Brand
    {
        public int Id { get; set; }

        [Required, StringLength(200, MinimumLength = 2)]
        public string Name { get; set; }

        public virtual ICollection<Model> Models { get; set; }
    }
}
