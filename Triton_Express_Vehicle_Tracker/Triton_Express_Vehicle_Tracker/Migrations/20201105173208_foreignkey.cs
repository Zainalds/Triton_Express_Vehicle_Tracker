using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Triton_Express_Vehicle_Tracker.Migrations
{
    public partial class foreignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.CreateTable(
                name: "Waybill",
                columns: table => new
                {
                    WaybillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Waybill_Total_weight = table.Column<string>(type: "varchar(255)", nullable: false),
                    Waybil_Total_Parcels_Allocated = table.Column<string>(type: "varchar(255)", nullable: false),
                    Vehicle_Registration_Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waybill", x => x.WaybillId);
                    table.ForeignKey(
                        name: "FK_Waybill_Vehicles_Vehicle_Registration_Number",
                        column: x => x.Vehicle_Registration_Number,
                        principalTable: "Vehicles",
                        principalColumn: "Vehicle_Registration_Number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Waybill_Vehicle_Registration_Number",
                table: "Waybill",
                column: "Vehicle_Registration_Number");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Waybill");

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Branch_Location = table.Column<string>(type: "varchar(255)", nullable: false),
                    Branch_Name = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                });
        }
    }
}
