﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Session2_DemoPart2;

#nullable disable

namespace Session2_DemoPart2.Migrations
{
    [DbContext(typeof(CompanyyContext))]
    [Migration("20250209163020_OneToOneTotal")]
    partial class OneToOneTotal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Session2_DemoPart2.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BlockNo")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Session2_DemoPart2.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 10L, 10);

                    b.Property<DateOnly>("CreattionDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Dept_Name");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId")
                        .IsUnique();

                    b.ToTable("Departments", (string)null);
                });

            modelBuilder.Entity("Session2_DemoPart2.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int>("DeatildAddresId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentDeptId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("departmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeatildAddresId");

                    b.HasIndex("departmentId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Session2_DemoPart2.Department", b =>
                {
                    b.HasOne("Session2_DemoPart2.Employee", "Manager")
                        .WithOne("ManageDepartment")
                        .HasForeignKey("Session2_DemoPart2.Department", "ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Session2_DemoPart2.Employee", b =>
                {
                    b.HasOne("Session2_DemoPart2.Address", "DeatildAddres")
                        .WithMany()
                        .HasForeignKey("DeatildAddresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Session2_DemoPart2.Department", "department")
                        .WithMany("Employees")
                        .HasForeignKey("departmentId");

                    b.Navigation("DeatildAddres");

                    b.Navigation("department");
                });

            modelBuilder.Entity("Session2_DemoPart2.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Session2_DemoPart2.Employee", b =>
                {
                    b.Navigation("ManageDepartment");
                });
#pragma warning restore 612, 618
        }
    }
}
