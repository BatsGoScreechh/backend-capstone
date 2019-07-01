using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MCTCTicketSystem2.Models
{
    public class Platform
    {
        public Platform()
        {

        }
        [Key]
        [Display(Name = "Platform")]
        public int PlatformId { get; set; }
        [Display(Name = "Platform")]
        public string Label { get; set; }
    }
}
