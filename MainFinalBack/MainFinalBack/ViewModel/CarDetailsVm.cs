using MainFinalBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.ViewModel
{
    public class CarDetailsVm
    {
        public Advertisement Advertisement { get; set; }
        public IEnumerable<CarDetailImage> CarDetailImages { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
        public Review Review { get; set; }
    }
}
