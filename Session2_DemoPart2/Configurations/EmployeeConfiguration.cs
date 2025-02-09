using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Session2_DemoPart2.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // Configure the relationship
            builder.HasOne(e => e.ManageDepartment)
                   .WithOne(d => d.Manager)
                   .HasForeignKey<Department>(d => d.ManagerId)
                   .IsRequired(true);
            builder.OwnsOne(e => e.DeatildAddres, Address => Address.WithOwner());
        }
    }
}
