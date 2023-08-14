using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasgemMicroservice.Services.Cargo.DataAccessLayer.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CargoStates",
                columns: table => new
                {
                    CargoStateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoStates", x => x.CargoStateID);
                });

            migrationBuilder.CreateTable(
                name: "CargoDetails",
                columns: table => new
                {
                    CargoDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderingID = table.Column<int>(type: "int", nullable: false),
                    CargoStateID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoDetails", x => x.CargoDetailID);
                    table.ForeignKey(
                        name: "FK_CargoDetails_CargoStates_CargoStateID",
                        column: x => x.CargoStateID,
                        principalTable: "CargoStates",
                        principalColumn: "CargoStateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CargoDetails_CargoStateID",
                table: "CargoDetails",
                column: "CargoStateID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargoDetails");

            migrationBuilder.DropTable(
                name: "CargoStates");
        }
    }
}
