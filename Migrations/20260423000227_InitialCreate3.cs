using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlquilerApp_Proyecto.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_DetalleAlquiler_ArticuloId",
                table: "DetalleAlquiler",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_CategoriaId",
                table: "Articulo",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_ClienteId",
                table: "Alquiler",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alquiler_Cliente_ClienteId",
                table: "Alquiler",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_Categoria_CategoriaId",
                table: "Articulo",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleAlquiler_Articulo_ArticuloId",
                table: "DetalleAlquiler",
                column: "ArticuloId",
                principalTable: "Articulo",
                principalColumn: "ArticuloId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alquiler_Cliente_ClienteId",
                table: "Alquiler");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_Categoria_CategoriaId",
                table: "Articulo");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleAlquiler_Articulo_ArticuloId",
                table: "DetalleAlquiler");

            migrationBuilder.DropIndex(
                name: "IX_DetalleAlquiler_ArticuloId",
                table: "DetalleAlquiler");

            migrationBuilder.DropIndex(
                name: "IX_Articulo_CategoriaId",
                table: "Articulo");

            migrationBuilder.DropIndex(
                name: "IX_Alquiler_ClienteId",
                table: "Alquiler");
        }
    }
}
