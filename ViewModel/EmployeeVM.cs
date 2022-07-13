using System.ComponentModel.DataAnnotations;

namespace AcrobuildEmpCrud.ViewModel
{
    public class EmployeeVM
    {
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [MaxLength(18)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Age must be numeric")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        public decimal Salary { get; set; }
    }
}
