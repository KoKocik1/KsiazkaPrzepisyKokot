using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KsiazkaPrzepisyKokot.Migrations
{
    public partial class obraz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Obraz",
                table: "Przepisy",
                type: "BLOB",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Obraz",
                table: "Przepisy");
        }
    }
}
