using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2_DemoPart2
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly CreattionDate { get; set; }
        //navigotal (many)(ma2drsh add delete etc)
        //  public List<Employee> Employees { get; set; }
        //  public IEnumerable<Employee> Employees { get; set; }  (
        [InverseProperty(nameof(Employee.department))]  
    public ICollection<Employee> Employees { get; set; }

        public Department()
        {
            Employees = new HashSet<Employee>();
            //HASHSET BEC large data
            //use array internaally 
            //now i have to implent equal/gethashcode bec employee now works on reference 
            //the only way i dont have to override equal/gthashcode is data from db
        }
        [ForeignKey(nameof(Manager))]
        public int ManagerId {  get; set; }
        #region 1 to 1 mapping
        //navigation propert (1)
        [InverseProperty(nameof(Employee.ManageDepartment))]
        public Employee  Manager {  get; set; } //Not nullable
        #endregion
    }

}
