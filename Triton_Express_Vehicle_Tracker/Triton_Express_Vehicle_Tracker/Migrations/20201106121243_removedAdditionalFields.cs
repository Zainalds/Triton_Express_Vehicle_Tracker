using Microsoft.EntityFrameworkCore.Migrations;

namespace Triton_Express_Vehicle_Tracker.Migrations
{
    public partial class removedAdditionalFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Entry_Date",
                table: "Waybill");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "Waybill");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Entry_Date",
                table: "Waybill",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Reference",
                table: "Waybill",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "");
        }
    }
}
