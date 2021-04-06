using System;
using System.ComponentModel.DataAnnotations;

namespace RentersView.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Text { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int TenantId { get; set; }

        [Required]
        public int LandlordId { get; set; }
    }
}
