using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceCore.Migrations
{
    public partial class ChangedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[] { 201, "Trance", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[] { 202, "PsychoTrance", 201 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Album", "Artist", "CategoryId", "Description", "Genre", "Price", "Quantity", "ReleaseDate", "Title" },
                values: new object[] { 101, "Summer Vibes", "Electric Samurai", 201, "Chill music", "Trance", 5.0, 12, new DateTime(2019, 11, 29, 13, 58, 9, 2, DateTimeKind.Local).AddTicks(9027), "Electric Samurai —  Mix Jan 2019" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[] { 1, "Trance", null });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Album", "Artist", "CategoryId", "Description", "Genre", "Price", "Quantity", "ReleaseDate", "Title" },
                values: new object[] { 1, "Summer Vibes", "Electric Samurai", null, "Chill music", "Trance", 5.0, 12, new DateTime(2019, 11, 29, 11, 35, 12, 362, DateTimeKind.Local).AddTicks(834), "Electric Samurai —  Mix Jan 2019" });
        }
    }
}
