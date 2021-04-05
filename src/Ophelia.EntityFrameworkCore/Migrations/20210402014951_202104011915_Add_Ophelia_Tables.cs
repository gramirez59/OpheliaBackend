using Microsoft.EntityFrameworkCore.Migrations;

namespace Ophelia.Migrations
{
    public partial class _202104011915_Add_Ophelia_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                schema: "ophelia",
                table: "Clientes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                schema: "ophelia",
                table: "Clientes",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cedula",
                schema: "ophelia",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Telefono",
                schema: "ophelia",
                table: "Clientes");
        }
    }
}
