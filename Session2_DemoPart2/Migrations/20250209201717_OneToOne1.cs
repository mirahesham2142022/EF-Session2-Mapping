using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session2_DemoPart2.Migrations
{
    /// <inheritdoc />
    public partial class OneToOne1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Address_DeatildAddresId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Employee_DeatildAddresId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "DeatildAddresId",
                table: "Employee",
                newName: "DeatildAddres_Id");

            migrationBuilder.AddColumn<int>(
                name: "DeatildAddres_BlockNo",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DeatildAddres_City",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeatildAddres_Country",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeatildAddres_Street",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeatildAddres_BlockNo",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DeatildAddres_City",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DeatildAddres_Country",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DeatildAddres_Street",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "DeatildAddres_Id",
                table: "Employee",
                newName: "DeatildAddresId");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockNo = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DeatildAddresId",
                table: "Employee",
                column: "DeatildAddresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Address_DeatildAddresId",
                table: "Employee",
                column: "DeatildAddresId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
