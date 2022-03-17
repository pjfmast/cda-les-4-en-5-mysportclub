using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySportsClub.Migrations
{
    public partial class MemberWithEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Member",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "ID",
                keyValue: 1,
                column: "Email",
                value: "esther@gmail.com");

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "ID",
                keyValue: 2,
                column: "Email",
                value: "anton@gmail.com");

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "ID",
                keyValue: 3,
                column: "Email",
                value: "manon@avans.com");

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "ID",
                keyValue: 4,
                column: "Email",
                value: "joke@avd.com");

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "ID",
                keyValue: 5,
                column: "Email",
                value: "jeroen@gmail.com");

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "ID",
                keyValue: 6,
                column: "Email",
                value: "ellen@breda.nl");

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "ID",
                keyValue: 7,
                column: "Email",
                value: "eva@edu.org");

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "ID",
                keyValue: 8,
                column: "Email",
                value: "anke@bandw.com");

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "ID",
                keyValue: 9,
                column: "Email",
                value: "koen@gmail.com");

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

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 16, 10, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 16, 9, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 16, 11, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 16, 10, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 16, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 16, 19, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 17, 11, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 17, 10, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 17, 18, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 17, 17, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 18, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 18, 10, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 18, 11, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 18, 10, 30, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 18, 19, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 18, 18, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 19, 10, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 19, 9, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 20, 11, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 20, 10, 15, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Member");

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 7, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 7, 10, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 7, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 7, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 8, 11, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 8, 10, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 8, 20, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 8, 19, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 9, 10, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 9, 9, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 9, 11, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 9, 10, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 9, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 9, 19, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 10, 11, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 10, 10, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 10, 18, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 10, 17, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 11, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 11, 10, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 11, 11, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 11, 10, 30, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 11, 19, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 11, 18, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 12, 10, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 12, 9, 15, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Workout",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2022, 3, 6, 11, 15, 0, 0, DateTimeKind.Local), new DateTime(2022, 3, 6, 10, 15, 0, 0, DateTimeKind.Local) });
        }
    }
}
