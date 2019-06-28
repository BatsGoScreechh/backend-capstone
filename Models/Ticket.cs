using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MCTCTicketSystem2.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateSubmit { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateCompleted { get; set; }
        public string Description { get; set; }
        public bool isActive { get; set; }
        public string AdminComment { get; set; }
        public int UserId { get; set; }
        [Required]
        public ApplicationUser User { get; set; }

        public int CategoryId { get; set; }
        public virtual ICollection<Category> Categories { get; set; }

        public int PlatformId { get; set; }
        public virtual ICollection<Platform> Platforms { get; set; }


    }
}
