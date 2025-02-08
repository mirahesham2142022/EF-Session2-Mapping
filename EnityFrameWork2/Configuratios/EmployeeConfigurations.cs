using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EnityFrameWork2.Configuratios
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>

    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
                    builder
                   .Property<String>("Address")
                   .HasColumnType("varchar")
                 .HasMaxLength(50).IsRequired();

        }
    }
}
