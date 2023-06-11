using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessFusion.Data.Migrations
{
    public partial class NullableFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_GymPrograms_GymProgramId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "GymProgramId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_GymPrograms_GymProgramId",
                table: "Users",
                column: "GymProgramId",
                principalTable: "GymPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_GymPrograms_GymProgramId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "GymProgramId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_GymPrograms_GymProgramId",
                table: "Users",
                column: "GymProgramId",
                principalTable: "GymPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
