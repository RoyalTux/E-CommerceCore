using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: false),
                    Genre = table.Column<string>(maxLength: 60, nullable: false),
                    Artist = table.Column<string>(maxLength: 60, nullable: false),
                    Album = table.Column<string>(maxLength: 60, nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Album", "Artist", "Description", "Genre", "Price", "Quantity", "ReleaseDate", "Title" },
                values: new object[] { 1, "Summer Vibes", "Electric Samurai", "Chill music", "Trance", 5.0, 12, new DateTime(2019, 11, 28, 16, 47, 7, 251, DateTimeKind.Local).AddTicks(1953), "Electric Samurai —  Mix Jan 2019" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
