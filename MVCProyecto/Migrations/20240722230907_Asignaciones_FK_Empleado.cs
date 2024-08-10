using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCProyecto.Migrations
{
    /// <inheritdoc />
    public partial class Asignaciones_FK_Empleado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Empleado",
                table: "Asignaciones");

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoId",
                table: "Asignaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Asignaciones_EmpleadoId",
                table: "Asignaciones",
                column: "EmpleadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaciones_Empleados_EmpleadoId",
                table: "Asignaciones",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignaciones_Empleados_EmpleadoId",
                table: "Asignaciones");

            migrationBuilder.DropIndex(
                name: "IX_Asignaciones_EmpleadoId",
                table: "Asignaciones");

            migrationBuilder.DropColumn(
                name: "EmpleadoId",
                table: "Asignaciones");

            migrationBuilder.AddColumn<string>(
                name: "Empleado",
                table: "Asignaciones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
