using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMJP.MasterDataServices.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompaniesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyID", "CompanyAddress", "CompanyEmail", "CompanyName", "CompanyPhone", "CreatedBy", "CreatedDate", "Latitude", "LogoUrl", "Longitude", "ModifiedBy", "ModifiedDate", "ProvinceID" },
                values: new object[] { 1, "Jl. M.H.Thamrin No.10", "pertamina@example.com", "Pertamina", "1234567890", 1, new DateTime(2024, 5, 21, 3, 27, 27, 179, DateTimeKind.Utc).AddTicks(2882), "40.7128", "https://pertamina.com/logo1.png", "-74.0060", 1, new DateTime(2024, 5, 21, 3, 27, 27, 179, DateTimeKind.Utc).AddTicks(2885), 1 });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "ShiftID", "CreatedBy", "CreatedDate", "EndAt", "ModifiedBy", "ModifiedDate", "StartAt", "Title" },
                values: new object[] { 1, 1, new DateTime(2024, 5, 21, 3, 27, 27, 179, DateTimeKind.Utc).AddTicks(3252), new DateTime(2024, 5, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 5, 21, 3, 27, 27, 179, DateTimeKind.Utc).AddTicks(3252), new DateTime(2024, 5, 21, 7, 0, 0, 0, DateTimeKind.Unspecified), "Morning" });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionID", "CompanyID", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "RegionLatitude", "RegionLongitude", "RegionName" },
                values: new object[] { 1, 1, 1, new DateTime(2024, 5, 21, 3, 27, 27, 179, DateTimeKind.Utc).AddTicks(3010), 1, new DateTime(2024, 5, 21, 3, 27, 27, 179, DateTimeKind.Utc).AddTicks(3011), "40.7128", "-74.0060", "Jakarta Pusat" });

            migrationBuilder.InsertData(
                table: "Sites",
                columns: new[] { "SiteID", "CompanyID", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "RegionID", "SiteDesc", "SiteLatitude", "SiteLongitude", "SiteName" },
                values: new object[] { 1, 1, 1, new DateTime(2024, 5, 21, 3, 27, 27, 179, DateTimeKind.Utc).AddTicks(3042), 1, new DateTime(2024, 5, 21, 3, 27, 27, 179, DateTimeKind.Utc).AddTicks(3043), 1, "Description of Pertamina Site", "48.8584", "2.2945", "Pertamina Training & Consulting" });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "ScheduleID", "CompanyID", "CreatedBy", "CreatedDate", "Date", "ModifiedBy", "ModifiedDate", "RegionID", "ShiftID", "SiteID" },
                values: new object[] { 1, 1, 1, new DateTime(2024, 5, 21, 10, 27, 27, 179, DateTimeKind.Local).AddTicks(3138), new DateTime(2024, 5, 21, 10, 27, 27, 179, DateTimeKind.Local).AddTicks(3126), 1, new DateTime(2024, 5, 21, 10, 27, 27, 179, DateTimeKind.Local).AddTicks(3139), 1, 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ScheduleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "ShiftID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sites",
                keyColumn: "SiteID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1);
        }
    }
}
