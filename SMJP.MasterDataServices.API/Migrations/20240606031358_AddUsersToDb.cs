using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMJP.MasterDataServices.API.Migrations
{
    /// <inheritdoc />
    public partial class AddUsersToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 3, 13, 57, 173, DateTimeKind.Utc).AddTicks(8066), new DateTime(2024, 6, 6, 3, 13, 57, 173, DateTimeKind.Utc).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "RegionID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 3, 13, 57, 173, DateTimeKind.Utc).AddTicks(8298), new DateTime(2024, 6, 6, 3, 13, 57, 173, DateTimeKind.Utc).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ScheduleID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 10, 13, 57, 173, DateTimeKind.Local).AddTicks(8451), new DateTime(2024, 6, 6, 10, 13, 57, 173, DateTimeKind.Local).AddTicks(8432), new DateTime(2024, 6, 6, 10, 13, 57, 173, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ShiftID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 3, 13, 57, 173, DateTimeKind.Utc).AddTicks(8660), new DateTime(2024, 6, 6, 3, 13, 57, 173, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 3, 13, 57, 173, DateTimeKind.Utc).AddTicks(8366), new DateTime(2024, 6, 6, 3, 13, 57, 173, DateTimeKind.Utc).AddTicks(8368) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 3, 10, 6, 302, DateTimeKind.Utc).AddTicks(190), new DateTime(2024, 6, 6, 3, 10, 6, 302, DateTimeKind.Utc).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "RegionID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 3, 10, 6, 302, DateTimeKind.Utc).AddTicks(255), new DateTime(2024, 6, 6, 3, 10, 6, 302, DateTimeKind.Utc).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "ScheduleID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 10, 10, 6, 302, DateTimeKind.Local).AddTicks(418), new DateTime(2024, 6, 6, 10, 10, 6, 302, DateTimeKind.Local).AddTicks(399), new DateTime(2024, 6, 6, 10, 10, 6, 302, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "ShiftID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 3, 10, 6, 302, DateTimeKind.Utc).AddTicks(625), new DateTime(2024, 6, 6, 3, 10, 6, 302, DateTimeKind.Utc).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "SiteID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 3, 10, 6, 302, DateTimeKind.Utc).AddTicks(330), new DateTime(2024, 6, 6, 3, 10, 6, 302, DateTimeKind.Utc).AddTicks(332) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "ActiveDate", "AvatarUrl", "CompanyID", "CreatedBy", "CreatedByIpAddress", "CreatedDate", "Email", "FullName", "IsActive", "IsAdmin", "ModifiedBy", "ModifiedDate", "Password", "Phone", "RegionID", "RoleID", "SiteID", "SyncTime", "UserCode", "Username" },
                values: new object[] { 1, new DateTime(2024, 6, 6, 3, 10, 6, 301, DateTimeKind.Utc).AddTicks(9905), "https://example.com/avatar1.png", 1, 1, "127.0.0.1", new DateTime(2024, 6, 6, 3, 10, 6, 301, DateTimeKind.Utc).AddTicks(9910), "johndoe@example.com", "John Doe", 1, 0, 1, new DateTime(2024, 6, 6, 3, 10, 6, 301, DateTimeKind.Utc).AddTicks(9913), "hashed_password", "1234567890", 1, 1, 1, 1, "USER001", "johndoe" });
        }
    }
}
