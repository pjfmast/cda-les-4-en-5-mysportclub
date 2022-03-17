using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySportsClub.Migrations
{
    public partial class MemberWithRealMail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "ID", "Email", "Name", "StartMembership" },
                values: new object[] { 10, "pjfmast@gmail.com", "Paul", new DateTime(2014, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 21, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 21, 10, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 21, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 21, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 22, 11, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 22, 10, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 22, 19, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "ID", "MemberID", "WorkoutID" },
                values: new object[] { 12, 10, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 14, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 14, 10, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 14, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 14, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 15, 11, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 15, 10, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 15, 20, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 15, 19, 15, 0, 0, DateTimeKind.Local) });
        }
    }
}
