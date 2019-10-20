using MainFinalBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.ViewModel
{
    public class EditAdVM
    {
        public Advertisement Advertisement { get; set; }
        public IEnumerable<CarDetailImage> CarDetailImages { get; set; }
    }
}
