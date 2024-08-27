using System.ComponentModel.DataAnnotations;

namespace DevExtremeAspNetCoreApp1.Models
{
    public class Employee
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }
        [MaxLength(100, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Email { get; set; }
    }
}
