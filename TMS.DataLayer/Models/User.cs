using System.ComponentModel.DataAnnotations;

namespace TMS.DataLayer.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(12)]
        public string Password { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
