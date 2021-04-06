using System.ComponentModel.DataAnnotations;

namespace RentersView.Models
{
    public class LeaseType
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }
    }
}
