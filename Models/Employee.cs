
using System.ComponentModel.DataAnnotations;
namespace back_app.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
         [StringLength(100)]
        public string Empno { get; set; } = String.Empty;
         [StringLength(150)]
        public string Name { get; set; } = String.Empty;
         [StringLength(200)]
        public string Email { get; set; } = String.Empty;

    }
}