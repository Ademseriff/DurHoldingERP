using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DurHoldingErp.Data.Migrations
{
    public partial class mg16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "closets",
                keyColumn: "Id",
                keyValue: new Guid("7f72a223-0530-4f5c-b537-17ee6cb62f3b"));

            migrationBuilder.DeleteData(
                table: "closets",
                keyColumn: "Id",
                keyValue: new Guid("a85d5494-6e97-4645-b360-3190b54875b2"));

            migrationBuilder.DeleteData(
                table: "kitchenCeramics",
                keyColumn: "Id",
                keyValue: new Guid("8db1d1b7-a44e-40f1-b480-1934b76648ee"));

            migrationBuilder.AddColumn<string>(
                name: "EMail",
                table: "invoices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "closets",
                columns: new[] { "Id", "BarcodeId", "ClosetAmount", "ClosetName", "ClosetPrice", "CreateTime", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("4fe2d2ca-325f-4785-8712-beae3aa8e6ac"), 3948, "2000", "Babel Rezervuarsız", "6120", new DateTime(2024, 1, 22, 15, 22, 29, 58, DateTimeKind.Local).AddTicks(2719), false },
                    { new Guid("71a17421-ebd3-4cf1-8c57-916ae1448aa6"), 8859, "1500", "Babel Rezervuar", "6400", new DateTime(2024, 1, 22, 15, 22, 29, 58, DateTimeKind.Local).AddTicks(2851), false }
                });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("14b482fc-8374-40ef-9bad-53f369b30771"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 22, 15, 22, 29, 58, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("173bf7c5-9f43-4f2a-afbd-f2a6e15b4d41"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 22, 15, 22, 29, 58, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("1c30332a-d7cc-4c29-abf9-b02bc87536eb"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 22, 15, 22, 29, 58, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("65dcc325-b971-4979-ad4c-52fe91509d5a"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 22, 15, 22, 29, 58, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 22, 15, 22, 29, 58, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("9b930dcd-fd15-43ce-be93-91c2b314a97f"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 22, 15, 22, 29, 58, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("b2ecb1dd-6c51-4bd6-862d-61df780de333"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 22, 15, 22, 29, 58, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 22, 15, 22, 29, 58, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.InsertData(
                table: "kitchenCeramics",
                columns: new[] { "Id", "BarcodeId", "CeramicAmount", "CeramicName", "CeramicPrice", "CreateTime", "IsDeleted" },
                values: new object[] { new Guid("5aed8bca-48b8-430f-bdf6-fc0ec9c22b90"), 5402, "400", "xx02", "3200", new DateTime(2024, 1, 22, 15, 22, 29, 58, DateTimeKind.Local).AddTicks(4409), false });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26331b"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 22, 15, 22, 29, 58, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26981b"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 22, 15, 22, 29, 58, DateTimeKind.Local).AddTicks(4814));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "closets",
                keyColumn: "Id",
                keyValue: new Guid("4fe2d2ca-325f-4785-8712-beae3aa8e6ac"));

            migrationBuilder.DeleteData(
                table: "closets",
                keyColumn: "Id",
                keyValue: new Guid("71a17421-ebd3-4cf1-8c57-916ae1448aa6"));

            migrationBuilder.DeleteData(
                table: "kitchenCeramics",
                keyColumn: "Id",
                keyValue: new Guid("5aed8bca-48b8-430f-bdf6-fc0ec9c22b90"));

            migrationBuilder.DropColumn(
                name: "EMail",
                table: "invoices");

            migrationBuilder.InsertData(
                table: "closets",
                columns: new[] { "Id", "BarcodeId", "ClosetAmount", "ClosetName", "ClosetPrice", "CreateTime", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("7f72a223-0530-4f5c-b537-17ee6cb62f3b"), 2619, "1500", "Babel Rezervuar", "6400", new DateTime(2024, 1, 16, 2, 30, 0, 881, DateTimeKind.Local).AddTicks(2122), false },
                    { new Guid("a85d5494-6e97-4645-b360-3190b54875b2"), 6335, "2000", "Babel Rezervuarsız", "6120", new DateTime(2024, 1, 16, 2, 30, 0, 881, DateTimeKind.Local).AddTicks(1980), false }
                });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("14b482fc-8374-40ef-9bad-53f369b30771"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 16, 2, 30, 0, 881, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("173bf7c5-9f43-4f2a-afbd-f2a6e15b4d41"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 16, 2, 30, 0, 881, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("1c30332a-d7cc-4c29-abf9-b02bc87536eb"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 16, 2, 30, 0, 881, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("65dcc325-b971-4979-ad4c-52fe91509d5a"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 16, 2, 30, 0, 881, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 16, 2, 30, 0, 881, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("9b930dcd-fd15-43ce-be93-91c2b314a97f"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 16, 2, 30, 0, 881, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("b2ecb1dd-6c51-4bd6-862d-61df780de333"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 16, 2, 30, 0, 881, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 16, 2, 30, 0, 881, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.InsertData(
                table: "kitchenCeramics",
                columns: new[] { "Id", "BarcodeId", "CeramicAmount", "CeramicName", "CeramicPrice", "CreateTime", "IsDeleted" },
                values: new object[] { new Guid("8db1d1b7-a44e-40f1-b480-1934b76648ee"), 9289, "400", "xx02", "3200", new DateTime(2024, 1, 16, 2, 30, 0, 881, DateTimeKind.Local).AddTicks(6501), false });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26331b"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 16, 2, 30, 0, 881, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26981b"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 16, 2, 30, 0, 881, DateTimeKind.Local).AddTicks(7624));
        }
    }
}
