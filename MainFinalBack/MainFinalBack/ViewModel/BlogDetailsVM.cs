using MainFinalBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.ViewModel
{
    public class BlogDetailsVM
    {
        public Blog Blog { get; set; }
        public IEnumerable<BlogDetailImage> BlogDetailImages { get; set; }
    }
}
