using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMJP.MasterDataServices.API.Migrations
{
    /// <inheritdoc />
    public partial class AddSitesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    SiteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    RegionID = table.Column<int>(type: "int", nullable: false),
                    SiteName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SiteDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteLatitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteLongitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.SiteID);
                    table.ForeignKey(
                        name: "FK_Sites_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sites_Regions_RegionID",
                        column: x => x.RegionID,
                        principalTable: "Regions",
                        principalColumn: "RegionID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sites_CompanyID",
                table: "Sites",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_RegionID",
                table: "Sites",
                column: "RegionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sites");
        }
    }
}
