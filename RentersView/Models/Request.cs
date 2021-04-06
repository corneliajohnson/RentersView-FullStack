using System;
using System.ComponentModel.DataAnnotations;

namespace RentersView.Models
{
    public class Request

    {
        public int Id { get; set; }

        [Required]
        public int PropertyId { get; set; }
        [Required]
        [MaxLength(255)]
        public string Synopsis { get; set; }
        public decimal Price { get; set; }
        [Required]
        public bool Complete { get; set; }
        public string Note { get; set; }
        public DateTime DateCompleted { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        
        public Property Property { get; set; }
    }
}
