using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required, Column(TypeName = "NCHAR"), StringLength(50)]
        public string StudentName { get; set; } 
        [Required]
        public DateTime DateOfBirth { get; set; }
        public decimal? Height { get; set; }
        [Column(TypeName = "FLOAT")]
        public float? Weight { get; set; }
    }
}
