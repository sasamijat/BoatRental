using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIgGameCore.Migrations
{
    public partial class VirtualBoatToBA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 14, 40, 28, 235, DateTimeKind.Local).AddTicks(2246), new DateTime(2022, 4, 8, 14, 40, 28, 232, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 22, 14, 40, 28, 235, DateTimeKind.Local).AddTicks(3680), new DateTime(2022, 4, 15, 14, 40, 28, 235, DateTimeKind.Local).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 14, 40, 28, 235, DateTimeKind.Local).AddTicks(3744), new DateTime(2022, 4, 8, 14, 40, 28, 235, DateTimeKind.Local).AddTicks(3741) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 14, 40, 28, 235, DateTimeKind.Local).AddTicks(3751), new DateTime(2022, 4, 8, 14, 40, 28, 235, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 14, 40, 28, 235, DateTimeKind.Local).AddTicks(3757), new DateTime(2022, 4, 8, 14, 40, 28, 235, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 40, 28, 235, DateTimeKind.Local).AddTicks(3762), new DateTime(2022, 4, 15, 14, 40, 28, 235, DateTimeKind.Local).AddTicks(3760) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 14, 13, 55, 49, 696, DateTimeKind.Local).AddTicks(4753), new DateTime(2022, 4, 7, 13, 55, 49, 692, DateTimeKind.Local).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 21, 13, 55, 49, 696, DateTimeKind.Local).AddTicks(7354), new DateTime(2022, 4, 14, 13, 55, 49, 696, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 14, 13, 55, 49, 696, DateTimeKind.Local).AddTicks(7367), new DateTime(2022, 4, 7, 13, 55, 49, 696, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 14, 13, 55, 49, 696, DateTimeKind.Local).AddTicks(7377), new DateTime(2022, 4, 7, 13, 55, 49, 696, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 14, 13, 55, 49, 696, DateTimeKind.Local).AddTicks(7387), new DateTime(2022, 4, 7, 13, 55, 49, 696, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 24, 13, 55, 49, 696, DateTimeKind.Local).AddTicks(7397), new DateTime(2022, 4, 14, 13, 55, 49, 696, DateTimeKind.Local).AddTicks(7392) });
        }
    }
}
