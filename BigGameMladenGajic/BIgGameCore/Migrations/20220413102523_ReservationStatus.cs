using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIgGameCore.Migrations
{
    public partial class ReservationStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 20, 12, 25, 23, 284, DateTimeKind.Local).AddTicks(7770), new DateTime(2022, 4, 13, 12, 25, 23, 281, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 27, 12, 25, 23, 284, DateTimeKind.Local).AddTicks(9431), new DateTime(2022, 4, 20, 12, 25, 23, 284, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 20, 12, 25, 23, 284, DateTimeKind.Local).AddTicks(9440), new DateTime(2022, 4, 13, 12, 25, 23, 284, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 20, 12, 25, 23, 284, DateTimeKind.Local).AddTicks(9446), new DateTime(2022, 4, 13, 12, 25, 23, 284, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 20, 12, 25, 23, 284, DateTimeKind.Local).AddTicks(9454), new DateTime(2022, 4, 13, 12, 25, 23, 284, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 30, 12, 25, 23, 284, DateTimeKind.Local).AddTicks(9461), new DateTime(2022, 4, 20, 12, 25, 23, 284, DateTimeKind.Local).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 4, 15, 12, 25, 23, 285, DateTimeKind.Local).AddTicks(1552), new DateTime(2022, 4, 14, 12, 25, 23, 285, DateTimeKind.Local).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 2,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 4, 15, 12, 25, 23, 285, DateTimeKind.Local).AddTicks(1872), new DateTime(2022, 4, 14, 12, 25, 23, 285, DateTimeKind.Local).AddTicks(1861) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "Reservations");

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
    }
}
