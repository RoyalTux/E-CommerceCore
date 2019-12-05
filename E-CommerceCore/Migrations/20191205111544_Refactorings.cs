using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceCore.Migrations
{
    public partial class Refactorings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product");

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

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Product",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Product",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
                values: new object[] { 101, "Summer Vibes", "Electric Samurai", 201, "Chill music", "Trance", 5.0, 12, new DateTime(2019, 11, 29, 14, 21, 43, 13, DateTimeKind.Local).AddTicks(5606), "Electric Samurai —  Mix Jan 2019" });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
