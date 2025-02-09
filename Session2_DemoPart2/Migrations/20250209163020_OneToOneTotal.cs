using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session2_DemoPart2.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneTotal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeatildAddresId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockNo = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Address_DeatildAddresId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Employee_DeatildAddresId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DeatildAddresId",
                table: "Employee");
        }
    }
}
