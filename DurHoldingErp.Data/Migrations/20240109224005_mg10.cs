using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DurHoldingErp.Data.Migrations
{
    public partial class mg10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sallary",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "Id", "CreateTime", "DepartmentName", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("14b482fc-8374-40ef-9bad-53f369b30771"), new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(8094), "Ik", false },
                    { new Guid("173bf7c5-9f43-4f2a-afbd-f2a6e15b4d41"), new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(8103), "Worker", false },
                    { new Guid("1c30332a-d7cc-4c29-abf9-b02bc87536eb"), new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(8092), "It", false },
                    { new Guid("65dcc325-b971-4979-ad4c-52fe91509d5a"), new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(8105), "CEO or Deputy ceo", false },
                    { new Guid("9b930dcd-fd15-43ce-be93-91c2b314a97f"), new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(8097), "Security", false },
                    { new Guid("b2ecb1dd-6c51-4bd6-862d-61df780de333"), new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(8100), "Driver", false }
                });

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26331b"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26981b"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(9501));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("14b482fc-8374-40ef-9bad-53f369b30771"));

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("173bf7c5-9f43-4f2a-afbd-f2a6e15b4d41"));

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("1c30332a-d7cc-4c29-abf9-b02bc87536eb"));

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("65dcc325-b971-4979-ad4c-52fe91509d5a"));

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("9b930dcd-fd15-43ce-be93-91c2b314a97f"));

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("b2ecb1dd-6c51-4bd6-862d-61df780de333"));

            migrationBuilder.DropColumn(
                name: "Sallary",
                table: "employees");

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 9, 12, 4, 33, 801, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 9, 12, 4, 33, 801, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26331b"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 9, 12, 4, 33, 801, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26981b"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 9, 12, 4, 33, 801, DateTimeKind.Local).AddTicks(8118));
        }
    }
}
