using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DurHoldingErp.Data.Migrations
{
    public partial class mg7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31313132131231",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b5a96126-a824-4984-be17-b0e5e28b3d8f", "0b78da38-bcf2-494a-b5f2-bbcc19671db0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31313132131238",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5c8d1161-d67b-41b8-afa2-0812a4ff367d", "b8f5301a-c06e-45c6-8bad-58065e5da6c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31313132131290",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "126519dc-d60f-4b04-89f7-1e5b7d47da2b", "5100e993-c2e1-41e0-bb80-ecd2b045a5d9" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 8, 14, 51, 23, 621, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 8, 14, 51, 23, 621, DateTimeKind.Local).AddTicks(4521));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "employees");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31313132131290",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5830c36b-d59a-400e-8352-d02bc9abb609", "4208c3c1-905d-446e-8d8a-1298430dec98" });

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
    }
}
