using Microsoft.EntityFrameworkCore.Migrations;

namespace crmUrbano.Migrations
{
    public partial class Migracion9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_carrito_t_catalogo_CatalogoID",
                table: "t_carrito");

            migrationBuilder.DropPrimaryKey(
                name: "PK_t_carrito",
                table: "t_carrito");

            migrationBuilder.RenameTable(
                name: "t_carrito",
                newName: "t_carrit");

            migrationBuilder.RenameIndex(
                name: "IX_t_carrito_CatalogoID",
                table: "t_carrit",
                newName: "IX_t_carrit_CatalogoID");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "t_carrit",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "t_carrit",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_t_carrit",
                table: "t_carrit",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_t_carrit_t_catalogo_CatalogoID",
                table: "t_carrit",
                column: "CatalogoID",
                principalTable: "t_catalogo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_carrit_t_catalogo_CatalogoID",
                table: "t_carrit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_t_carrit",
                table: "t_carrit");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "t_carrit");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "t_carrit");

            migrationBuilder.RenameTable(
                name: "t_carrit",
                newName: "t_carrito");

            migrationBuilder.RenameIndex(
                name: "IX_t_carrit_CatalogoID",
                table: "t_carrito",
                newName: "IX_t_carrito_CatalogoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_t_carrito",
                table: "t_carrito",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_t_carrito_t_catalogo_CatalogoID",
                table: "t_carrito",
                column: "CatalogoID",
                principalTable: "t_catalogo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
