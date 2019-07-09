using Microsoft.AspNetCore.Mvc.Rendering;
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
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Submission Date")]
        public DateTime DateSubmit { get; set; }

        public DateTime? DateCompleted { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public bool isActive { get; set; }
        [Display(Name = "Ticket Status")]
        public string activeMessage
        { get; set; }
        public string AdminComment { get; set; }
        public string UserId { get; set; }
        [Required]
        public ApplicationUser User { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [NotMapped]
        public SelectList Categories { get; set; }
        [Display(Name = "Platform")]
        public int PlatformId { get; set; }
        [NotMapped]
        public SelectList Platforms { get; set; }
        public Platform currentPlatform { get; set; }
        public Category currentCategory { get; set; }

    }
}
