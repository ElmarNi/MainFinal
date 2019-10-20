using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class TermContent
    {
        public int Id { get; set; }
        public int TermHeaderId { get; set; }
        public virtual TermHeader TermHeader { get; set; }

        [Required, StringLength(500)]
        public string Content { get; set; }
    }
}
