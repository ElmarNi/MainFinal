using MainFinalBack.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.ViewModel
{
    public class ContactModeratorVM
    {
        [Required, MinLength(20, ErrorMessage = "Minimum length must be greater than 20 characters")]
        public string Message { get; set; }

        public IEnumerable<Contact> Contacts { get; set; }
    }
}
