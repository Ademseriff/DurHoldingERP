using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DurHoldingErp.Data.Migrations
{
    public partial class mg98 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "closets",
                keyColumn: "Id",
                keyValue: new Guid("a95c7350-6ff8-4501-869f-4f3d6dbfb0d1"));

            migrationBuilder.DeleteData(
                table: "closets",
                keyColumn: "Id",
                keyValue: new Guid("f1a8fb6d-0deb-40fc-bcb2-b4fef807e9e2"));

            migrationBuilder.DeleteData(
                table: "kitchenCeramics",
                keyColumn: "Id",
                keyValue: new Guid("66eb2f6d-5368-41a8-90ec-9a15392d0169"));

            migrationBuilder.InsertData(
                table: "closets",
                columns: new[] { "Id", "BarcodeId", "ClosetAmount", "ClosetName", "ClosetPrice", "CreateTime", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("070f5da2-e0a7-4e73-8895-8b5c38346d01"), 3729, "1500", "Babel Rezervuar", "6400", new DateTime(2024, 1, 24, 1, 46, 14, 785, DateTimeKind.Local).AddTicks(1511), false },
                    { new Guid("adccf5a7-7091-4cc6-b839-919fc36e782c"), 7811, "2000", "Babel Rezervuarsız", "6120", new DateTime(2024, 1, 24, 1, 46, 14, 785, DateTimeKind.Local).AddTicks(1423), false }
                });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("14b482fc-8374-40ef-9bad-53f369b30771"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 24, 1, 46, 14, 785, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("173bf7c5-9f43-4f2a-afbd-f2a6e15b4d41"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 24, 1, 46, 14, 785, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("1c30332a-d7cc-4c29-abf9-b02bc87536eb"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 24, 1, 46, 14, 785, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("65dcc325-b971-4979-ad4c-52fe91509d5a"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 24, 1, 46, 14, 785, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 24, 1, 46, 14, 785, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("9b930dcd-fd15-43ce-be93-91c2b314a97f"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 24, 1, 46, 14, 785, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("b2ecb1dd-6c51-4bd6-862d-61df780de333"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 24, 1, 46, 14, 785, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 24, 1, 46, 14, 785, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.InsertData(
                table: "kitchenCeramics",
                columns: new[] { "Id", "BarcodeId", "CeramicAmount", "CeramicName", "CeramicPrice", "CreateTime", "IsDeleted" },
                values: new object[] { new Guid("d492af54-f30a-462c-9aa8-463ed8bf1c60"), 4325, "400", "xx02", "3200", new DateTime(2024, 1, 24, 1, 46, 14, 785, DateTimeKind.Local).AddTicks(3745), false });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26331b"),
                columns: new[] { "CreateTime", "Name", "Password", "Role" },
                values: new object[] { new DateTime(2024, 1, 24, 1, 46, 14, 785, DateTimeKind.Local).AddTicks(4486), "Adem", "123456", "SüperAdmin" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26981b"),
                columns: new[] { "CreateTime", "Name", "Password", "Role" },
                values: new object[] { new DateTime(2024, 1, 24, 1, 46, 14, 785, DateTimeKind.Local).AddTicks(4500), "Kerem", "123456", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "closets",
                keyColumn: "Id",
                keyValue: new Guid("070f5da2-e0a7-4e73-8895-8b5c38346d01"));

            migrationBuilder.DeleteData(
                table: "closets",
                keyColumn: "Id",
                keyValue: new Guid("adccf5a7-7091-4cc6-b839-919fc36e782c"));

            migrationBuilder.DeleteData(
                table: "kitchenCeramics",
                keyColumn: "Id",
                keyValue: new Guid("d492af54-f30a-462c-9aa8-463ed8bf1c60"));

            migrationBuilder.InsertData(
                table: "closets",
                columns: new[] { "Id", "BarcodeId", "ClosetAmount", "ClosetName", "ClosetPrice", "CreateTime", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("a95c7350-6ff8-4501-869f-4f3d6dbfb0d1"), 6134, "1500", "Babel Rezervuar", "6400", new DateTime(2024, 1, 24, 1, 24, 35, 193, DateTimeKind.Local).AddTicks(9120), false },
                    { new Guid("f1a8fb6d-0deb-40fc-bcb2-b4fef807e9e2"), 4302, "2000", "Babel Rezervuarsız", "6120", new DateTime(2024, 1, 24, 1, 24, 35, 193, DateTimeKind.Local).AddTicks(8875), false }
                });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("14b482fc-8374-40ef-9bad-53f369b30771"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 24, 1, 24, 35, 193, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("173bf7c5-9f43-4f2a-afbd-f2a6e15b4d41"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 24, 1, 24, 35, 193, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("1c30332a-d7cc-4c29-abf9-b02bc87536eb"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 24, 1, 24, 35, 193, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("65dcc325-b971-4979-ad4c-52fe91509d5a"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 24, 1, 24, 35, 193, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 24, 1, 24, 35, 193, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("9b930dcd-fd15-43ce-be93-91c2b314a97f"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 24, 1, 24, 35, 193, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("b2ecb1dd-6c51-4bd6-862d-61df780de333"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 24, 1, 24, 35, 193, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 24, 1, 24, 35, 194, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.InsertData(
                table: "kitchenCeramics",
                columns: new[] { "Id", "BarcodeId", "CeramicAmount", "CeramicName", "CeramicPrice", "CreateTime", "IsDeleted" },
                values: new object[] { new Guid("66eb2f6d-5368-41a8-90ec-9a15392d0169"), 5907, "400", "xx02", "3200", new DateTime(2024, 1, 24, 1, 24, 35, 194, DateTimeKind.Local).AddTicks(372), false });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26331b"),
                columns: new[] { "CreateTime", "Name", "Password", "Role" },
                values: new object[] { new DateTime(2024, 1, 24, 1, 24, 35, 194, DateTimeKind.Local).AddTicks(721), "Admin", "168317", "Admin" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26981b"),
                columns: new[] { "CreateTime", "Name", "Password", "Role" },
                values: new object[] { new DateTime(2024, 1, 24, 1, 24, 35, 194, DateTimeKind.Local).AddTicks(729), "SüperAdmin", "168317", "SüperAdmin" });
        }
    }
}
