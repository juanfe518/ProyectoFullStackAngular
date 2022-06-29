using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHeroAPI.Migrations
{
    public partial class Correcion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastaName",
                table: "SuperHeroes",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "FirstaName",
                table: "SuperHeroes",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "SuperHeroes",
                newName: "LastaName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "SuperHeroes",
                newName: "FirstaName");
        }
    }
}
