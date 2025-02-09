using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2_DemoPart2
{
    internal class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Column(TypeName = "varchar(50)")]
        [MaxLength(50)]
        public string Name { get; set; } = null!; // Nullable reference type

        [DataType(DataType.Currency)]
        public double Salary { get; set; }

        [Range(20, 23, ErrorMessage = "Age must be between 20 and 23")]
        public int? Age { get; set; } // Nullable integer

        [RegularExpression(@"^(?=.[A-Za-z])(?=.\d)[A-Za-z\d]{8,}$",
            ErrorMessage = "Password must be at least 8 characters  and contain letters , numbers.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; } // Nullable string

        [NotMapped] // Not stored in the database
        public double NetSalary => Salary - (Salary * 0.2);
        public String address { get; set; }
        public Employee()
        {

        }
        public Employee(int id, string name, double salary, string password, int age)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Password = password;
            Age = age;

        }
        [InverseProperty(nameof(Department.Employees))]
        public Department? department { get; set; }  //navigational
        [ForeignKey(nameof(Department))]
        public int? DepartmentDeptId { get; set; } //Foregin Key

        //navigation 1  manager manager 1 deptarment
        [InverseProperty(nameof(Department.Manager))]
        public   Department ? ManageDepartment   {get;set ;}
        public Address DeatildAddres { get; set; }
    }
}
