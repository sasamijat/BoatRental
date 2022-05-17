using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIgGameCore.Migrations
{
    public partial class boatUser1toN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 7, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(7737), new DateTime(2022, 3, 31, 12, 55, 59, 556, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 14, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9157), new DateTime(2022, 4, 7, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 7, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9165), new DateTime(2022, 3, 31, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 7, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9171), new DateTime(2022, 3, 31, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 7, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9177), new DateTime(2022, 3, 31, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 17, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9183), new DateTime(2022, 4, 7, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9180) });
        }
    }
}
