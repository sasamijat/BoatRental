using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIgGameCore.Migrations
{
    public partial class addReservation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationID", "BoatAvailabilityID", "UserID", "endDateTime", "startDateTime" },
                values: new object[] { 2, 3, 2, new DateTime(2022, 4, 10, 16, 57, 14, 314, DateTimeKind.Local).AddTicks(1219), new DateTime(2022, 4, 9, 16, 57, 14, 314, DateTimeKind.Local).AddTicks(1209) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 16, 53, 39, 660, DateTimeKind.Local).AddTicks(8116), new DateTime(2022, 4, 8, 16, 53, 39, 656, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 22, 16, 53, 39, 661, DateTimeKind.Local).AddTicks(1270), new DateTime(2022, 4, 15, 16, 53, 39, 661, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 16, 53, 39, 661, DateTimeKind.Local).AddTicks(1288), new DateTime(2022, 4, 8, 16, 53, 39, 661, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 16, 53, 39, 661, DateTimeKind.Local).AddTicks(1306), new DateTime(2022, 4, 8, 16, 53, 39, 661, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 16, 53, 39, 661, DateTimeKind.Local).AddTicks(1324), new DateTime(2022, 4, 8, 16, 53, 39, 661, DateTimeKind.Local).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 25, 16, 53, 39, 661, DateTimeKind.Local).AddTicks(1342), new DateTime(2022, 4, 15, 16, 53, 39, 661, DateTimeKind.Local).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 53, 39, 661, DateTimeKind.Local).AddTicks(5415), new DateTime(2022, 4, 9, 16, 53, 39, 661, DateTimeKind.Local).AddTicks(4789) });
        }
    }
}
