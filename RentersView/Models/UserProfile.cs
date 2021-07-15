using System;
using System.ComponentModel.DataAnnotations;

namespace RentersView.Models
{
    public class UserProfile
    {
        public int Id { get; set; }

        [Required]
        public string FirebaseId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        public string Image { get; set; }

        [Required]
        public bool IsLandlord { get; set; }

        public int LandlordId { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }
    }
}
