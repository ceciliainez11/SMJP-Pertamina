using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMJP.MasterDataServices.API.Migrations
{
    /// <inheritdoc />
    public partial class AddSchedulesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    RegionID = table.Column<int>(type: "int", nullable: false),
                    SiteID = table.Column<int>(type: "int", nullable: false),
                    ShiftID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ScheduleID);
                    table.ForeignKey(
                        name: "FK_Schedules_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Regions_RegionID",
                        column: x => x.RegionID,
                        principalTable: "Regions",
                        principalColumn: "RegionID");
                    table.ForeignKey(
                        name: "FK_Schedules_Sites_SiteID",
                        column: x => x.SiteID,
                        principalTable: "Sites",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_CompanyID",
                table: "Schedules",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_RegionID",
                table: "Schedules",
                column: "RegionID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_SiteID",
                table: "Schedules",
                column: "SiteID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");
        }
    }
}
