using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required, StringLength(200, MinimumLength = 3)]
        public string Name { get; set; }

        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, MinLength(20, ErrorMessage = "Minimum length must be greater than 20 characters")]
        public string Message { get; set; }

        public DateTime Date { get; set; }
    }
}
