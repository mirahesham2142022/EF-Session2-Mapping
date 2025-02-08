using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Employee
{
    [Key]// primary key
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")] 
    [Column(TypeName = "varchar(50)")] 
    [MaxLength(50)] 
    public string Name { get; set; } = null!; // Nullable reference type

    [DataType(DataType.Currency)] 
    public double Salary { get; set; } 

    [Range(20, 23, ErrorMessage = "Age must be between 20 and 23")]
    public int? Age { get; set; } // Nullable integer

    [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$",
        ErrorMessage = "Password must be at least 8 characters  and contain letters , numbers.")]
    [DataType(DataType.Password)]
    public string? Password { get; set; } // Nullable string

    [NotMapped] // Not stored in the database
    public double NetSalary => Salary - (Salary * 0.2); 
}
