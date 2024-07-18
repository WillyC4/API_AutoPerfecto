using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_AutoPerfecto.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vclass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cylinders = table.Column<int>(type: "int", nullable: true),
                    drive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    engid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fueltype = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
