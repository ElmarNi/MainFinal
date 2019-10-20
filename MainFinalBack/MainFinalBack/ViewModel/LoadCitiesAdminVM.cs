using MainFinalBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.ViewModel
{
    public class LoadCitiesAdminVM
    {
        public City City { get; set; }
        public IEnumerable<City> Cities { get; set; }
    }
}
