using Microsoft.EntityFrameworkCore;
using Session2_DemoPart2.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Session2_DemoPart2
{
    internal class CompanyyContext:DbContext
    {
        public CompanyyContext():base()
        {

        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=.;Database=Companyy;Trusted_Connection=True;TrustServerCertificate=True;");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //abd2 bay heta lw 3aml 2 navigation property

            //modelBuilder.Entity<Department>()
            //    .HasMany(d => d.Employees)
            //    .WithOne(e => e.department).HasForeignKey(e => e.DepartmentDeptId)
            //    .IsRequired(false);

            // .HasForeignKey("DepartmentId");

            //modelBuilder.Entity<Employee>()
            //    .HasOne(d => d.department)
            //    .WithMany(e => e.Employees);
           

            //modelBuilder.Entity<Department>()
            //   .HasOne(d => d.Manager)
            //   .WithOne(e => e.ManageDepartment);
            // Alternative: Apply all configurations from assembly
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
      
        }
     
    }
}
