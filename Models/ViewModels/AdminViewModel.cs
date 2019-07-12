using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCTCTicketSystem2.Models.TicketViewModels
{
    public class AdminViewModel
    {
        public ApplicationUser applicationUser { get; set; }
        public Ticket ticket { get; set; }
        public Platform platform { get; set; }
        public IEnumerable<Ticket> tickets { get; set; }
        public int countTrue { get { return tickets.Count(i => i.isActive == true); } }

    }
}
