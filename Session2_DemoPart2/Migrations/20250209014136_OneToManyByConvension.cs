using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session2_DemoPart2.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyByConvension : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_departmentId",
                table: "Employee",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Departments_departmentId",
                table: "Employee",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Departments_departmentId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_departmentId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "Employee");
        }
    }
}
