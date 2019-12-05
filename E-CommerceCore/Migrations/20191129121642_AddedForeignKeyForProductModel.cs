using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceCore.Migrations
{
    public partial class AddedForeignKeyForProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 101,
                column: "ReleaseDate",
                value: new DateTime(2019, 11, 29, 14, 16, 42, 244, DateTimeKind.Local).AddTicks(7556));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 101,
                column: "ReleaseDate",
                value: new DateTime(2019, 11, 29, 14, 4, 46, 259, DateTimeKind.Local).AddTicks(6179));
        }
    }
}
