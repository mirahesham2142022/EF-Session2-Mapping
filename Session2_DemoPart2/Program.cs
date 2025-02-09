namespace Session2_DemoPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            CompanyyContext context = new CompanyyContext();
            Employee e1 = new Employee(1, "Mira", 8000, "Prcb%4633", 21);
            Employee e2 = new Employee(2, "John", 9500, "Secure123", 30);
            Employee e3 = new Employee(3, "dina", 10000, "Sere123", 40);


            context.Set<Employee>().Add(e1);
            context.Set<Employee>().Add(e2);
            context.Set<Employee>().Add(e3);



            context.SaveChanges();

            Console.WriteLine("Employees added successfully!");

            #region OneToOne Mapping  Conevntion anadDta annotations
            //Manage RelationShips
            //1 emloyee manager 1 department and departmentmanage by 1 manager(employee)
            #endregion

            #region oneToOne FluentApis
            //fluent apis in OnmodelCreatig
            #endregion

            #region 1 to 1 Total Partciipation from 2 sides

            #endregion

        }
    }
}
