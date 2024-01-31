using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DurHoldingErp.Data.Migrations
{
    public partial class mg15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "closets",
                keyColumn: "Id",
                keyValue: new Guid("93526695-7f26-419d-b040-b2b9fed8d70f"));

            migrationBuilder.DeleteData(
                table: "closets",
                keyColumn: "Id",
                keyValue: new Guid("aac90208-cc01-4979-be3b-a28301a7002c"));

            migrationBuilder.DeleteData(
                table: "kitchenCeramics",
                keyColumn: "Id",
                keyValue: new Guid("089dc9ff-9a82-4df9-9daf-ffc202b32900"));

            migrationBuilder.CreateTable(
                name: "invoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceNumber = table.Column<int>(type: "int", nullable: false),
                    SellerInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverInformations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarcodeId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Piece = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoices", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "invoices");

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

            migrationBuilder.InsertData(
                table: "closets",
                columns: new[] { "Id", "BarcodeId", "ClosetAmount", "ClosetName", "ClosetPrice", "CreateTime", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("93526695-7f26-419d-b040-b2b9fed8d70f"), 2994, "2000", "Babel Rezervuarsız", "6120", new DateTime(2024, 1, 15, 0, 51, 6, 392, DateTimeKind.Local).AddTicks(7541), false },
                    { new Guid("aac90208-cc01-4979-be3b-a28301a7002c"), 4427, "1500", "Babel Rezervuar", "6400", new DateTime(2024, 1, 15, 0, 51, 6, 392, DateTimeKind.Local).AddTicks(7608), false }
                });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("14b482fc-8374-40ef-9bad-53f369b30771"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 15, 0, 51, 6, 392, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("173bf7c5-9f43-4f2a-afbd-f2a6e15b4d41"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 15, 0, 51, 6, 392, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("1c30332a-d7cc-4c29-abf9-b02bc87536eb"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 15, 0, 51, 6, 392, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("65dcc325-b971-4979-ad4c-52fe91509d5a"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 15, 0, 51, 6, 392, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 15, 0, 51, 6, 392, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("9b930dcd-fd15-43ce-be93-91c2b314a97f"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 15, 0, 51, 6, 392, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("b2ecb1dd-6c51-4bd6-862d-61df780de333"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 15, 0, 51, 6, 392, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 15, 0, 51, 6, 392, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.InsertData(
                table: "kitchenCeramics",
                columns: new[] { "Id", "BarcodeId", "CeramicAmount", "CeramicName", "CeramicPrice", "CreateTime", "IsDeleted" },
                values: new object[] { new Guid("089dc9ff-9a82-4df9-9daf-ffc202b32900"), 2427, "400", "xx02", "3200", new DateTime(2024, 1, 15, 0, 51, 6, 392, DateTimeKind.Local).AddTicks(8883), false });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26331b"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 15, 0, 51, 6, 392, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26981b"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 15, 0, 51, 6, 392, DateTimeKind.Local).AddTicks(9277));
        }
    }
}
