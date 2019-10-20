using MainFinalBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.ViewModel
{
    public class LoadModelsAdminVM
    {
        public Model Model { get; set; }
        public IEnumerable<Model> Models { get; set; }
    }
}
