using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DurHoldingErp.Data.Migrations
{
    public partial class mg3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "Id", "CreateTime", "DepartmentName", "IsDeleted" },
                values: new object[] { new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"), new DateTime(2024, 1, 3, 19, 7, 40, 720, DateTimeKind.Local).AddTicks(9196), "yönetici", false });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "Age", "CreateTime", "DepartmentId", "IsDeleted", "Name", "Surname" },
                values: new object[] { new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"), 24, new DateTime(2024, 1, 3, 19, 7, 40, 721, DateTimeKind.Local).AddTicks(1291), new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"), false, "Adem Şerif", "Dur" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"));

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"));
        }
    }
}
