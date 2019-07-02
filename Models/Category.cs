using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MCTCTicketSystem2.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "Platform")]
        public int CategoryId { get; set; }
        [Display(Name = "Category")]
        public string Label { get; set; }
        public int Rating { get; set; }

    }
}
