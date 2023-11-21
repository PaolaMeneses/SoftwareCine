using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SotfwareCine.API.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Horarios_Teatros_IdTeatro",
                table: "Horarios");

            migrationBuilder.DropIndex(
                name: "IX_Horarios_IdTeatro",
                table: "Horarios");

            migrationBuilder.DropColumn(
                name: "IdTeatro",
                table: "Horarios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdTeatro",
                table: "Horarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_IdTeatro",
                table: "Horarios",
                column: "IdTeatro");

            migrationBuilder.AddForeignKey(
                name: "FK_Horarios_Teatros_IdTeatro",
                table: "Horarios",
                column: "IdTeatro",
                principalTable: "Teatros",
                principalColumn: "IdTeatro",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
