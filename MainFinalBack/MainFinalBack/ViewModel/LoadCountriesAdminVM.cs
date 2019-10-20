using MainFinalBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.ViewModel
{
    public class LoadCountriesAdminVM
    {
        public Country Country { get; set; }
        public IEnumerable<Country> Countries { get; set; }
    }
}
