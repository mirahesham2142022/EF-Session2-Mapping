using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EnityFrameWork2.Configuratios
{
    internal class DepartmentsConfig : IEntityTypeConfiguration<Departments>
    {
        public void Configure(EntityTypeBuilder<Departments> builder)
        {
            builder.ToTable("Departments").HasKey(D => D.Id);
            builder.Property(D => D.Id).UseIdentityColumn(10, 10);
            builder.Property(D => D.Name).HasColumnName("Dept_Name");
            builder.Property(D => D.CreattionDate).HasDefaultValueSql("GETDATE()");
        }
    }
}
