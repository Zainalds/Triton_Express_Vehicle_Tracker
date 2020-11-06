using Microsoft.EntityFrameworkCore.Migrations;

namespace Triton_Express_Vehicle_Tracker.Migrations
{
    public partial class vehiclemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vehicle_Model",
                table: "Vehicles",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "integer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vehicle_Model",
                table: "Vehicles",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)");
        }
    }
}
