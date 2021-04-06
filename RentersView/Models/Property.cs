using System;
using System.ComponentModel.DataAnnotations;

namespace RentersView.Models
{
    public class Property
    {
        public int Id { get; set; }
        [Required]
        public int UserProfileId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Street{ get; set; }

        [Required]
        [MaxLength(100)]
        public string City{ get; set; }

        [Required]
        [MaxLength(15)]
        public string State { get; set; }

        [Required]
        [MaxLength(5)]
        public string Zip { get; set; }

        public DateTime LeaseStateDate { get; set; }
        public DateTime LeaseEndDate { get; set; }
        public decimal RentAmount { get; set; }
        public decimal SecuirtyDeposit { get; set; }
        public string LeaseTerm { get; set; }
        public int LeaseTypeId { get; set; }
        public string Image { get; set; }
        
        [Required]
        public UserProfile Landlord { get; set; }

        public LeaseType LeaseType { get; set; }
        public DateTime DateCreated { get; set; }
        public int CurrentTenantId { get; set; }
    }
}
