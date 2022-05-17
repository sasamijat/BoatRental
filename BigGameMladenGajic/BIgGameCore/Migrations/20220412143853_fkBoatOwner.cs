using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIgGameCore.Migrations
{
    public partial class fkBoatOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 19, 16, 38, 52, 536, DateTimeKind.Local).AddTicks(5636), new DateTime(2022, 4, 12, 16, 38, 52, 534, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 26, 16, 38, 52, 536, DateTimeKind.Local).AddTicks(7097), new DateTime(2022, 4, 19, 16, 38, 52, 536, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 19, 16, 38, 52, 536, DateTimeKind.Local).AddTicks(7106), new DateTime(2022, 4, 12, 16, 38, 52, 536, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 19, 16, 38, 52, 536, DateTimeKind.Local).AddTicks(7112), new DateTime(2022, 4, 12, 16, 38, 52, 536, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 19, 16, 38, 52, 536, DateTimeKind.Local).AddTicks(7118), new DateTime(2022, 4, 12, 16, 38, 52, 536, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 29, 16, 38, 52, 536, DateTimeKind.Local).AddTicks(7124), new DateTime(2022, 4, 19, 16, 38, 52, 536, DateTimeKind.Local).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 38, 52, 536, DateTimeKind.Local).AddTicks(9093), new DateTime(2022, 4, 13, 16, 38, 52, 536, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 2,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 38, 52, 536, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 4, 13, 16, 38, 52, 536, DateTimeKind.Local).AddTicks(9389) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 16, 57, 14, 313, DateTimeKind.Local).AddTicks(7638), new DateTime(2022, 4, 8, 16, 57, 14, 311, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 22, 16, 57, 14, 313, DateTimeKind.Local).AddTicks(9117), new DateTime(2022, 4, 15, 16, 57, 14, 313, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 16, 57, 14, 313, DateTimeKind.Local).AddTicks(9125), new DateTime(2022, 4, 8, 16, 57, 14, 313, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 16, 57, 14, 313, DateTimeKind.Local).AddTicks(9131), new DateTime(2022, 4, 8, 16, 57, 14, 313, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 16, 57, 14, 313, DateTimeKind.Local).AddTicks(9137), new DateTime(2022, 4, 8, 16, 57, 14, 313, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 25, 16, 57, 14, 313, DateTimeKind.Local).AddTicks(9143), new DateTime(2022, 4, 15, 16, 57, 14, 313, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 57, 14, 314, DateTimeKind.Local).AddTicks(920), new DateTime(2022, 4, 9, 16, 57, 14, 314, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 2,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 57, 14, 314, DateTimeKind.Local).AddTicks(1219), new DateTime(2022, 4, 9, 16, 57, 14, 314, DateTimeKind.Local).AddTicks(1209) });
        }
    }
}
