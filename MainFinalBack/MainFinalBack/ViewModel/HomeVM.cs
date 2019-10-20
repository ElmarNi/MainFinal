using MainFinalBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.ViewModel
{
    public class HomeVM
    {
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Advertisement> Advertisements { get; set; }
    }
}
