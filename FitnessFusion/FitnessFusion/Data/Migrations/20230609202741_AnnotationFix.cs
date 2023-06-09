using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessFusion.Data.Migrations
{
    public partial class AnnotationFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Trainings",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "ExtraGymSessions",
                newName: "StartTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Trainings",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "ExtraGymSessions",
                newName: "DateTime");
        }
    }
}
