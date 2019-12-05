using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceCore.Migrations
{
    public partial class AdditionsInSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[] { 1, "Trance", null });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Album", "Artist", "CategoryId", "Description", "Genre", "Price", "Quantity", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Summer Vibes", "Electric Samurai", null, "Chill music", "Trance", 5.0, 12, new DateTime(2019, 12, 5, 14, 22, 58, 659, DateTimeKind.Local).AddTicks(3034), "Electric Samurai —  Mix Jan 2019" },
                    { 2, "Summer Vibes", "SHIVA BLEZE", null, "Psy trance music", "Trance", 6.0, 14, new DateTime(2019, 12, 5, 14, 22, 58, 661, DateTimeKind.Local).AddTicks(2620), "SHIVA MANTRA VS PSY TRANCE BY SHIVA BLEZE" },
                    { 3, "Trippy Experience", "Electric Samurai", null, "Psychedelic Progressive", "Trance", 7.0, 16, new DateTime(2019, 12, 5, 14, 22, 58, 661, DateTimeKind.Local).AddTicks(2637), "Trippy Experience | Psychedelic Progressive Psy Trance Mix" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
