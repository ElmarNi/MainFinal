using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class TermHeader
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Header { get; set; }
        public virtual ICollection<TermContent> TermContents { get; set; }
    }
}
