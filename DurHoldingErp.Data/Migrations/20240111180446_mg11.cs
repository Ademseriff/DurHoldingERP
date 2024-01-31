using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DurHoldingErp.Data.Migrations
{
    public partial class mg11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bathCeramics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BarcodeId = table.Column<int>(type: "int", nullable: false),
                    CeramicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CeramicPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CeramicAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bathCeramics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "closets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BarcodeId = table.Column<int>(type: "int", nullable: false),
                    ClosetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosetPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosetAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_closets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "kitchenCeramics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BarcodeId = table.Column<int>(type: "int", nullable: false),
                    CeramicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CeramicPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CeramicAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitchenCeramics", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "closets",
                columns: new[] { "Id", "BarcodeId", "ClosetAmount", "ClosetName", "ClosetPrice", "CreateTime", "IsDeleted" },
                values: new object[] { new Guid("22c56881-bbd0-4635-809a-de506cd188f7"), 1404, "2000", "Babel Rezervuarsız", "6120", new DateTime(2024, 1, 11, 21, 4, 45, 381, DateTimeKind.Local).AddTicks(5949), false });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("14b482fc-8374-40ef-9bad-53f369b30771"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 4, 45, 381, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("173bf7c5-9f43-4f2a-afbd-f2a6e15b4d41"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 4, 45, 381, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("1c30332a-d7cc-4c29-abf9-b02bc87536eb"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 4, 45, 381, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("65dcc325-b971-4979-ad4c-52fe91509d5a"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 4, 45, 381, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 4, 45, 381, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("9b930dcd-fd15-43ce-be93-91c2b314a97f"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 4, 45, 381, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("b2ecb1dd-6c51-4bd6-862d-61df780de333"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 4, 45, 381, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 4, 45, 381, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26331b"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 4, 45, 382, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26981b"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 11, 21, 4, 45, 382, DateTimeKind.Local).AddTicks(138));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bathCeramics");

            migrationBuilder.DropTable(
                name: "closets");

            migrationBuilder.DropTable(
                name: "kitchenCeramics");

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("14b482fc-8374-40ef-9bad-53f369b30771"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("173bf7c5-9f43-4f2a-afbd-f2a6e15b4d41"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("1c30332a-d7cc-4c29-abf9-b02bc87536eb"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("65dcc325-b971-4979-ad4c-52fe91509d5a"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("9b930dcd-fd15-43ce-be93-91c2b314a97f"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("b2ecb1dd-6c51-4bd6-862d-61df780de333"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 10, 1, 40, 5, 382, DateTimeKind.Local).AddTicks(8100));

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
    }
}
