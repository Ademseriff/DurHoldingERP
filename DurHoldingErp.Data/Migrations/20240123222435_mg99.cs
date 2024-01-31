using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DurHoldingErp.Data.Migrations
{
    public partial class mg99 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreateTime", "Name", "Password" },
                values: new object[] { new DateTime(2024, 1, 24, 1, 24, 35, 194, DateTimeKind.Local).AddTicks(721), "Admin", "168317" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26981b"),
                columns: new[] { "CreateTime", "Name", "Password", "Role" },
                values: new object[] { new DateTime(2024, 1, 24, 1, 24, 35, 194, DateTimeKind.Local).AddTicks(729), "SüperAdmin", "168317", "SüperAdmin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreateTime", "Name", "Password" },
                values: new object[] { new DateTime(2024, 1, 22, 15, 22, 29, 58, DateTimeKind.Local).AddTicks(4805), "Adem", "123456" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26981b"),
                columns: new[] { "CreateTime", "Name", "Password", "Role" },
                values: new object[] { new DateTime(2024, 1, 22, 15, 22, 29, 58, DateTimeKind.Local).AddTicks(4814), "Kerem", "123456", "Admin" });
        }
    }
}
