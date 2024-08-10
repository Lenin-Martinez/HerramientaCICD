using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCProyecto.Migrations
{
    /// <inheritdoc />
    public partial class Asignaciones_FK_Proyecto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Proyecto",
                table: "Asignaciones");

            migrationBuilder.AddColumn<int>(
                name: "ProyectoId",
                table: "Asignaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Asignaciones_ProyectoId",
                table: "Asignaciones",
                column: "ProyectoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaciones_Proyectos_ProyectoId",
                table: "Asignaciones",
                column: "ProyectoId",
                principalTable: "Proyectos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignaciones_Proyectos_ProyectoId",
                table: "Asignaciones");

            migrationBuilder.DropIndex(
                name: "IX_Asignaciones_ProyectoId",
                table: "Asignaciones");

            migrationBuilder.DropColumn(
                name: "ProyectoId",
                table: "Asignaciones");

            migrationBuilder.AddColumn<string>(
                name: "Proyecto",
                table: "Asignaciones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
