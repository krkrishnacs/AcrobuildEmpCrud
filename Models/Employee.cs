using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AcrobuildEmpCrud.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(minimum: 18, maximum: 100)]
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }
}
