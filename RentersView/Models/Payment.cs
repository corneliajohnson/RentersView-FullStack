using System;
using System.ComponentModel.DataAnnotations;

namespace RentersView.Models
{
    public class Payment
    {
        public int Id { get; set; }

        [Required]
        public int UserProfileId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public decimal PaymentAmount { get; set; }
    }
}
