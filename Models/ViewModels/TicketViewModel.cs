using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCTCTicketSystem2.Models.TicketViewModels
{
    public class TicketViewModel
    {
        public Ticket tickets { get; set; }
        public ApplicationUser applicationUser { get; set; }
    }
}
