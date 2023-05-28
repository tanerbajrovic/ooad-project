using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessFusion.Data.Migrations
{
    public partial class Version1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GymActivities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DifficultyLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymActivities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GymPrograms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Overview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymPrograms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Parameters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameters", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CardioParameters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    SprintRunning = table.Column<double>(type: "float", nullable: false),
                    Running = table.Column<double>(type: "float", nullable: false),
                    VerticalJump = table.Column<double>(type: "float", nullable: false),
                    HorizontalJump = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardioParameters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CardioParameters_Parameters_ID",
                        column: x => x.ID,
                        principalTable: "Parameters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HybridParameters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    BenchPress = table.Column<double>(type: "float", nullable: false),
                    Squat = table.Column<double>(type: "float", nullable: false),
                    AbsTest = table.Column<int>(type: "int", nullable: false),
                    PushUps = table.Column<int>(type: "int", nullable: false),
                    SprintRunning = table.Column<double>(type: "float", nullable: false),
                    Running = table.Column<double>(type: "float", nullable: false),
                    VerticalJump = table.Column<double>(type: "float", nullable: false),
                    HorizontalJump = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HybridParameters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HybridParameters_Parameters_ID",
                        column: x => x.ID,
                        principalTable: "Parameters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StrengthParameters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    BenchPress = table.Column<double>(type: "float", nullable: false),
                    Squat = table.Column<double>(type: "float", nullable: false),
                    AbsTest = table.Column<int>(type: "int", nullable: false),
                    PushUps = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrengthParameters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StrengthParameters_Parameters_ID",
                        column: x => x.ID,
                        principalTable: "Parameters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDTrainer = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Schedules_Trainers_IDTrainer",
                        column: x => x.IDTrainer,
                        principalTable: "Trainers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExtraGymSessions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDSchedule = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false),
                    BurnedCalories = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraGymSessions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExtraGymSessions_Schedules_IDSchedule",
                        column: x => x.IDSchedule,
                        principalTable: "Schedules",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstimatedDuration = table.Column<int>(type: "int", nullable: false),
                    IDGymProgram = table.Column<int>(type: "int", nullable: false),
                    IDSchedule = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false),
                    BurnedCalories = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Trainings_GymPrograms_IDGymProgram",
                        column: x => x.IDGymProgram,
                        principalTable: "GymPrograms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trainings_Schedules_IDSchedule",
                        column: x => x.IDSchedule,
                        principalTable: "Schedules",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityCoefficient = table.Column<double>(type: "float", nullable: false),
                    IDSchedule = table.Column<int>(type: "int", nullable: false),
                    IDGymProgram = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_GymPrograms_IDGymProgram",
                        column: x => x.IDGymProgram,
                        principalTable: "GymPrograms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Schedules_IDSchedule",
                        column: x => x.IDSchedule,
                        principalTable: "Schedules",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GymActivityChoices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDTraining = table.Column<int>(type: "int", nullable: true),
                    IDExtraGymSession = table.Column<int>(type: "int", nullable: false),
                    IDGymActivity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymActivityChoices", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GymActivityChoices_ExtraGymSessions_IDExtraGymSession",
                        column: x => x.IDExtraGymSession,
                        principalTable: "ExtraGymSessions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GymActivityChoices_GymActivities_IDGymActivity",
                        column: x => x.IDGymActivity,
                        principalTable: "GymActivities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GymActivityChoices_Trainings_IDTraining",
                        column: x => x.IDTraining,
                        principalTable: "Trainings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDUser = table.Column<int>(type: "int", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CVC = table.Column<int>(type: "int", nullable: false),
                    ExpirationDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CreditCards_Users_IDUser",
                        column: x => x.IDUser,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDGymProgram = table.Column<int>(type: "int", nullable: false),
                    IDUser = table.Column<int>(type: "int", nullable: true),
                    RatingValue = table.Column<double>(type: "float", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rating_GymPrograms_IDGymProgram",
                        column: x => x.IDGymProgram,
                        principalTable: "GymPrograms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rating_Users_IDUser",
                        column: x => x.IDUser,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDUser = table.Column<int>(type: "int", nullable: true),
                    IDTrainer = table.Column<int>(type: "int", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mass = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    WaistCircumference = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Results_Trainers_IDTrainer",
                        column: x => x.IDTrainer,
                        principalTable: "Trainers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Results_Users_IDUser",
                        column: x => x.IDUser,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParametersChoices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDResult = table.Column<int>(type: "int", nullable: false),
                    IDParameters = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametersChoices", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ParametersChoices_Parameters_IDParameters",
                        column: x => x.IDParameters,
                        principalTable: "Parameters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParametersChoices_Results_IDResult",
                        column: x => x.IDResult,
                        principalTable: "Results",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreditCards_IDUser",
                table: "CreditCards",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraGymSessions_IDSchedule",
                table: "ExtraGymSessions",
                column: "IDSchedule");

            migrationBuilder.CreateIndex(
                name: "IX_GymActivityChoices_IDExtraGymSession",
                table: "GymActivityChoices",
                column: "IDExtraGymSession");

            migrationBuilder.CreateIndex(
                name: "IX_GymActivityChoices_IDGymActivity",
                table: "GymActivityChoices",
                column: "IDGymActivity");

            migrationBuilder.CreateIndex(
                name: "IX_GymActivityChoices_IDTraining",
                table: "GymActivityChoices",
                column: "IDTraining");

            migrationBuilder.CreateIndex(
                name: "IX_ParametersChoices_IDParameters",
                table: "ParametersChoices",
                column: "IDParameters");

            migrationBuilder.CreateIndex(
                name: "IX_ParametersChoices_IDResult",
                table: "ParametersChoices",
                column: "IDResult");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_IDGymProgram",
                table: "Rating",
                column: "IDGymProgram");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_IDUser",
                table: "Rating",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_Results_IDTrainer",
                table: "Results",
                column: "IDTrainer");

            migrationBuilder.CreateIndex(
                name: "IX_Results_IDUser",
                table: "Results",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_IDTrainer",
                table: "Schedules",
                column: "IDTrainer");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_IDGymProgram",
                table: "Trainings",
                column: "IDGymProgram");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_IDSchedule",
                table: "Trainings",
                column: "IDSchedule");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IDGymProgram",
                table: "Users",
                column: "IDGymProgram");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IDSchedule",
                table: "Users",
                column: "IDSchedule");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardioParameters");

            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.DropTable(
                name: "GymActivityChoices");

            migrationBuilder.DropTable(
                name: "HybridParameters");

            migrationBuilder.DropTable(
                name: "ParametersChoices");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "StrengthParameters");

            migrationBuilder.DropTable(
                name: "ExtraGymSessions");

            migrationBuilder.DropTable(
                name: "GymActivities");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Parameters");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "GymPrograms");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Trainers");
        }
    }
}
