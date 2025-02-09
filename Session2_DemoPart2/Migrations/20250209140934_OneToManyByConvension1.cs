using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session2_DemoPart2.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyByConvension1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentDeptId",
                table: "Employee",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentDeptId",
                table: "Employee");
        }
    }
}
