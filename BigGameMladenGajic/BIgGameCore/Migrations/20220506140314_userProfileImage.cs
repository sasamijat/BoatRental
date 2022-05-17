using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIgGameCore.Migrations
{
    public partial class userProfileImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfileImage",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 13, 16, 3, 14, 82, DateTimeKind.Local).AddTicks(1743), new DateTime(2022, 5, 6, 16, 3, 14, 79, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 20, 16, 3, 14, 82, DateTimeKind.Local).AddTicks(3973), new DateTime(2022, 5, 13, 16, 3, 14, 82, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 13, 16, 3, 14, 82, DateTimeKind.Local).AddTicks(3983), new DateTime(2022, 5, 6, 16, 3, 14, 82, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 13, 16, 3, 14, 82, DateTimeKind.Local).AddTicks(3992), new DateTime(2022, 5, 6, 16, 3, 14, 82, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 13, 16, 3, 14, 82, DateTimeKind.Local).AddTicks(4000), new DateTime(2022, 5, 6, 16, 3, 14, 82, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 23, 16, 3, 14, 82, DateTimeKind.Local).AddTicks(4009), new DateTime(2022, 5, 13, 16, 3, 14, 82, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 5, 8, 16, 3, 14, 82, DateTimeKind.Local).AddTicks(6722), new DateTime(2022, 5, 7, 16, 3, 14, 82, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 2,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 5, 8, 16, 3, 14, 82, DateTimeKind.Local).AddTicks(7287), new DateTime(2022, 5, 7, 16, 3, 14, 82, DateTimeKind.Local).AddTicks(7272) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 12, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(5548), new DateTime(2022, 5, 5, 16, 18, 54, 536, DateTimeKind.Local).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 19, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7032), new DateTime(2022, 5, 12, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 12, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7094), new DateTime(2022, 5, 5, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 12, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7101), new DateTime(2022, 5, 5, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 12, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7107), new DateTime(2022, 5, 5, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 22, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7113), new DateTime(2022, 5, 12, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 5, 7, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(8777), new DateTime(2022, 5, 6, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 2,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 5, 7, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(9077), new DateTime(2022, 5, 6, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(9067) });
        }
    }
}
