using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySportsClub.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    StartMembership = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instructor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapacityLeft = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberID = table.Column<int>(type: "int", nullable: false),
                    WorkoutID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Enrollments_Members_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Members",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Workouts_WorkoutID",
                        column: x => x.WorkoutID,
                        principalTable: "Workouts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "ID", "Name", "StartMembership" },
                values: new object[,]
                {
                    { 1, "Esther", new DateTime(2014, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Anton", new DateTime(2018, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Manon", new DateTime(2016, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Joke", new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Jeroen", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Ellen", new DateTime(2010, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Eva", new DateTime(2012, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Anke", new DateTime(2015, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Koen", new DateTime(2015, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "ID", "CapacityLeft", "EndTime", "Instructor", "Location", "StartTime", "Title" },
                values: new object[,]
                {
                    { 1, 35, new DateTime(2022, 2, 21, 11, 0, 0, 0, DateTimeKind.Local), "Marcel", "Yoga studio", new DateTime(2022, 2, 21, 10, 15, 0, 0, DateTimeKind.Local), "Yin Yoga" },
                    { 2, 30, new DateTime(2022, 2, 21, 18, 0, 0, 0, DateTimeKind.Local), "Babs", "Yoga studio", new DateTime(2022, 2, 21, 17, 0, 0, 0, DateTimeKind.Local), "Pilates" },
                    { 3, 35, new DateTime(2022, 2, 22, 11, 15, 0, 0, DateTimeKind.Local), "Silvia", "Yoga studio", new DateTime(2022, 2, 22, 10, 15, 0, 0, DateTimeKind.Local), "Hot Yoga" },
                    { 4, 30, new DateTime(2022, 2, 22, 20, 15, 0, 0, DateTimeKind.Local), "Marie Jose", "Room 1", new DateTime(2022, 2, 22, 19, 15, 0, 0, DateTimeKind.Local), "Club Power" },
                    { 5, 25, new DateTime(2022, 2, 23, 10, 15, 0, 0, DateTimeKind.Local), "Eva", "Room 2", new DateTime(2022, 2, 23, 9, 15, 0, 0, DateTimeKind.Local), "XCO" },
                    { 6, 16, new DateTime(2022, 2, 23, 11, 15, 0, 0, DateTimeKind.Local), "Emilio", "Boxing Area", new DateTime(2022, 2, 23, 10, 15, 0, 0, DateTimeKind.Local), "B&K Training" },
                    { 7, 35, new DateTime(2022, 2, 23, 20, 0, 0, 0, DateTimeKind.Local), "Babette", "Room 1", new DateTime(2022, 2, 23, 19, 15, 0, 0, DateTimeKind.Local), "Callanetics" },
                    { 8, 18, new DateTime(2022, 2, 24, 11, 15, 0, 0, DateTimeKind.Local), "Jeroen", "Room 4", new DateTime(2022, 2, 24, 10, 15, 0, 0, DateTimeKind.Local), "Spinning" },
                    { 9, 30, new DateTime(2022, 2, 24, 18, 15, 0, 0, DateTimeKind.Local), "Silvia", "Yoga studio", new DateTime(2022, 2, 24, 17, 15, 0, 0, DateTimeKind.Local), "Vinyasa Yoga" },
                    { 10, 35, new DateTime(2022, 2, 25, 11, 0, 0, 0, DateTimeKind.Local), "Anke", "Room 1", new DateTime(2022, 2, 25, 10, 15, 0, 0, DateTimeKind.Local), "TBW" },
                    { 11, 12, new DateTime(2022, 2, 25, 11, 15, 0, 0, DateTimeKind.Local), "Emilio", "Room 2", new DateTime(2022, 2, 25, 10, 30, 0, 0, DateTimeKind.Local), "Shred and Burn" },
                    { 12, 8, new DateTime(2022, 2, 25, 19, 15, 0, 0, DateTimeKind.Local), "Mirjam", "Cycle Area", new DateTime(2022, 2, 25, 18, 15, 0, 0, DateTimeKind.Local), "Cycle Interval" },
                    { 13, 12, new DateTime(2022, 2, 26, 10, 15, 0, 0, DateTimeKind.Local), "Ronn", "Cycle Area", new DateTime(2022, 2, 26, 9, 15, 0, 0, DateTimeKind.Local), "Spinning" },
                    { 14, 6, new DateTime(2022, 2, 27, 11, 15, 0, 0, DateTimeKind.Local), "Lonneke", "Cycle Area", new DateTime(2022, 2, 27, 10, 15, 0, 0, DateTimeKind.Local), "SoulRide" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "ID", "MemberID", "WorkoutID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 4 },
                    { 3, 2, 2 },
                    { 4, 2, 5 },
                    { 5, 2, 14 },
                    { 6, 3, 4 },
                    { 7, 3, 8 },
                    { 8, 4, 1 },
                    { 9, 4, 4 },
                    { 10, 4, 10 },
                    { 11, 4, 13 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_MemberID",
                table: "Enrollments",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_WorkoutID",
                table: "Enrollments",
                column: "WorkoutID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Workouts");
        }
    }
}
