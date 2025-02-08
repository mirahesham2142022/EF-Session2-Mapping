using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

using System.Threading.Tasks;
using EnityFrameWork2.Configuratios;
using System.Reflection;

namespace EnityFrameWork2
{
    //static class SqlServerDataTypes
    //{
    //    //Most probbaly fe libary w bimport libarary
    //    public static string varchar => "varchar";
    //}
    internal class CompanyContext:DbContext
    {
        public CompanyContext() :base()
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=.;Database=Company;Trusted_Connection=True;TrustServerCertificate=True;");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            // shadow Property(like derived attrubie salary)
            //modelBuilder.Entity<Employee>()
            //        .Property<String>("Address")
            //        .HasColumnType("varchar")
            //      .HasMaxLength(50).IsRequired();
            modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations());
            modelBuilder.ApplyConfiguration<Departments>(new DepartmentsConfig());
            //alternative 
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //check on everyClass implemnts     IenttyConfig and applyConfig to it by reflection
            #region Topics
          //  Reflection (metaData)
            #endregion

            //2 benfits (1 is tat i can rename table second I can chose schmea and I canmap to  view (must have a view i db holds same name)
            //in case schmea doesnit exits he create another ne and check firslty its exts or nt 
            //  modelBuilder.Entity<Departments>().ToTable("departments", "dbo");
            //  modelBuilder.Entity<Departments>().HasKey(nameof(Departments.Id));
            //modelBuilder.Entity<Departments>().HasKey(D => D.Id);
            //As it is so Ridciulous to do same code muiltple times we need to craete like above( build design better)
            //modelBuilder.Entity<Departments>().ToTable("Departments").HasKey(D => D.Id);
            //modelBuilder.Entity<Departments>().Property(D=>D.Id).UseIdentityColumn(10,10);
            //modelBuilder.Entity<Departments>().Property(D => D.Name).HasColumnName("Dept_Name");
            //modelBuilder.Entity<Departments>().Property(D => D.CreattionDate).HasDefaultValueSql("GETDATE()");
            //[HAS DEFAULT/COMPUTED DEF]
            //hasDefault Stored in the database as a fixed value,Only at INSERT,Default timestamp, GUID, status
            //compyted":Not stored, recalculated dynamically,	Cannot be manually modified 	Tax calculation, net salary
            //now is constanct once i created a migration
            //must return same thing
        }
        public DbSet<Employee> Employees { get; set; }   //New Table
        public DbSet<Departments>Departments { get; set; }

    }
}
