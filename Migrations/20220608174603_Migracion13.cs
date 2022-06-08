using Microsoft.EntityFrameworkCore.Migrations;

namespace crmUrbano.Migrations
{
    public partial class Migracion13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagenName",
                table: "t_carrit",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenName",
                table: "t_carrit");
        }
    }
}
