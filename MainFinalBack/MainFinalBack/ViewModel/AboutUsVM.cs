using MainFinalBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.ViewModel
{
    public class AboutUsVM
    {
        public OurPassionAboutUs OurPassions { get; set; }
        public IEnumerable<OurVisionAboutUs> OurVisions { get; set; }
    }
}
