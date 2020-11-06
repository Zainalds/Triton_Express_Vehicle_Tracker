using Microsoft.EntityFrameworkCore.Migrations;

namespace Triton_Express_Vehicle_Tracker.Migrations
{
    public partial class svd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Vehicle_Number_Plate",
                table: "Waybill",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vehicle_Number_Plate",
                table: "Waybill");
        }
    }
}
