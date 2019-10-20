using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class Model
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }

        [Required]
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
