using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MCTCTicketSystem2.Models
{
    public class Platform
    {
        [Key]
        public int PlatformId { get; set; }
        public string Label { get; set; }
    }
}
