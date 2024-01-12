using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DurHoldingErp.Data.Migrations
{
    public partial class mg13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "closets",
                keyColumn: "Id",
                keyValue: new Guid("4b2865b4-8abe-40b3-83f6-40af599efd0d"));

            migrationBuilder.DeleteData(
                table: "closets",
                keyColumn: "Id",
                keyValue: new Guid("ed47c0b2-3aba-458e-b156-34f4a569f65c"));

            migrationBuilder.InsertData(
                table: "closets",
                columns: new[] { "Id", "BarcodeId", "ClosetAmount", "ClosetName", "ClosetPrice", "CreateTime", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("4e88b523-0ac5-49e8-b75e-a45ea88b5331"), 8686, "2000", "Babel Rezervuarsız", "6120", new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(5595), false },
                    { new Guid("61a18e57-523a-4256-9bf1-33ee982469cd"), 9288, "1500", "Babel Rezervuar", "6400", new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(5812), false }
                });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("14b482fc-8374-40ef-9bad-53f369b30771"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("173bf7c5-9f43-4f2a-afbd-f2a6e15b4d41"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("1c30332a-d7cc-4c29-abf9-b02bc87536eb"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("65dcc325-b971-4979-ad4c-52fe91509d5a"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("9b930dcd-fd15-43ce-be93-91c2b314a97f"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("b2ecb1dd-6c51-4bd6-862d-61df780de333"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.InsertData(
                table: "kitchenCeramics",
                columns: new[] { "Id", "BarcodeId", "CeramicAmount", "CeramicName", "CeramicPrice", "CreateTime", "IsDeleted" },
                values: new object[] { new Guid("979fc79e-f6ec-465d-968f-dda94a0b58c0"), 5429, "400", "xx02", "3200", new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(9158), false });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26331b"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 12, 14, 47, 20, 839, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26981b"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 12, 14, 47, 20, 839, DateTimeKind.Local).AddTicks(417));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "closets",
                keyColumn: "Id",
                keyValue: new Guid("4e88b523-0ac5-49e8-b75e-a45ea88b5331"));

            migrationBuilder.DeleteData(
                table: "closets",
                keyColumn: "Id",
                keyValue: new Guid("61a18e57-523a-4256-9bf1-33ee982469cd"));

            migrationBuilder.DeleteData(
                table: "kitchenCeramics",
                keyColumn: "Id",
                keyValue: new Guid("979fc79e-f6ec-465d-968f-dda94a0b58c0"));

            migrationBuilder.InsertData(
                table: "closets",
                columns: new[] { "Id", "BarcodeId", "ClosetAmount", "ClosetName", "ClosetPrice", "CreateTime", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("4b2865b4-8abe-40b3-83f6-40af599efd0d"), 1907, "2000", "Babel Rezervuarsız", "6120", new DateTime(2024, 1, 11, 21, 7, 59, 181, DateTimeKind.Local).AddTicks(589), false },
                    { new Guid("ed47c0b2-3aba-458e-b156-34f4a569f65c"), 3214, "1500", "Babel Rezervuar", "6400", new DateTime(2024, 1, 11, 21, 7, 59, 181, DateTimeKind.Local).AddTicks(729), false }
                });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("14b482fc-8374-40ef-9bad-53f369b30771"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 7, 59, 181, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("173bf7c5-9f43-4f2a-afbd-f2a6e15b4d41"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 7, 59, 181, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("1c30332a-d7cc-4c29-abf9-b02bc87536eb"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 7, 59, 181, DateTimeKind.Local).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("65dcc325-b971-4979-ad4c-52fe91509d5a"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 7, 59, 181, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 7, 59, 181, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("9b930dcd-fd15-43ce-be93-91c2b314a97f"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 7, 59, 181, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("b2ecb1dd-6c51-4bd6-862d-61df780de333"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 7, 59, 181, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 7, 59, 181, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26331b"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 7, 59, 181, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26981b"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 7, 59, 181, DateTimeKind.Local).AddTicks(3608));
        }
    }
}
