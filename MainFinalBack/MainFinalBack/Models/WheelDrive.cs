using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class WheelDrive
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Drive { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
