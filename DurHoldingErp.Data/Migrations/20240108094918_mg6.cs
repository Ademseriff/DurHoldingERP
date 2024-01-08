using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DurHoldingErp.Data.Migrations
{
    public partial class mg6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31313132131231",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d0f21b5-c212-47d3-85ec-89ca6ed70ff7", "bc4edf67-687f-4b71-bfe8-51d7a0ab221f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31313132131238",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0512aa2a-c2cd-42ca-bb47-f42f349b7f62", "eb76d89a-0584-4408-a07e-4844a331d439" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "31313132131290", 0, "5830c36b-d59a-400e-8352-d02bc9abb609", "ademserif@gmail.com", true, false, null, null, null, "123456", "05392956006", true, "4208c3c1-905d-446e-8d8a-1298430dec98", false, "ademserif" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 8, 12, 49, 18, 242, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 8, 12, 49, 18, 242, DateTimeKind.Local).AddTicks(8942));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31313132131290");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31313132131231",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bfb13abd-8a6e-4dd2-88bf-7a26e7a59e91", "12391a36-f69b-4c73-9c68-399b4524b836" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31313132131238",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f687bda-1696-45d9-aff4-3f8a6144619e", "2c74e321-ffac-4e59-966f-97b03e952463" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 7, 22, 55, 12, 825, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 7, 22, 55, 12, 825, DateTimeKind.Local).AddTicks(7835));
        }
    }
}
