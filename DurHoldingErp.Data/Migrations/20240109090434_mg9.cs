using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DurHoldingErp.Data.Migrations
{
    public partial class mg9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "CreateTime", "Email", "IsDeleted", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26331b"), new DateTime(2024, 1, 9, 12, 4, 33, 801, DateTimeKind.Local).AddTicks(8091), "ademserifd@gmail.com", false, "Adem", "123456", "Admin" },
                    { new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26981b"), new DateTime(2024, 1, 9, 12, 4, 33, 801, DateTimeKind.Local).AddTicks(8118), "ademserifd@gmail.com", false, "Kerem", "123456", "Admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 9, 1, 12, 27, 659, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"),
                column: "CreateTime",
                value: new DateTime(2024, 1, 9, 1, 12, 27, 659, DateTimeKind.Local).AddTicks(1872));
        }
    }
}
