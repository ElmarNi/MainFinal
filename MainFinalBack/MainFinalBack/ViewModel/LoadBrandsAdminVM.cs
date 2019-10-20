using MainFinalBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.ViewModel
{
    public class LoadBrandsAdminVM
    {
        public Brand Brand { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
    }
}
