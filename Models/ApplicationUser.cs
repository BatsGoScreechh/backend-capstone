using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCTCTicketSystem2.Models
{
    public class ApplicationUser : IdentityUser
    {
<<<<<<< HEAD
        public ApplicationUser(){ }
        [HiddenInput(DisplayValue = false)]
=======
        public ApplicationUser()
        {

        }
>>>>>>> master
        public bool isAdmin { get; set; }
    }

}
