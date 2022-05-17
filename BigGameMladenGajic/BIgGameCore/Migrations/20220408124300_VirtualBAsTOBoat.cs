using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIgGameCore.Migrations
{
    public partial class VirtualBAsTOBoat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 14, 42, 59, 921, DateTimeKind.Local).AddTicks(2867), new DateTime(2022, 4, 8, 14, 42, 59, 917, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 22, 14, 42, 59, 921, DateTimeKind.Local).AddTicks(5148), new DateTime(2022, 4, 15, 14, 42, 59, 921, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 14, 42, 59, 921, DateTimeKind.Local).AddTicks(5159), new DateTime(2022, 4, 8, 14, 42, 59, 921, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 14, 42, 59, 921, DateTimeKind.Local).AddTicks(5168), new DateTime(2022, 4, 8, 14, 42, 59, 921, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 15, 14, 42, 59, 921, DateTimeKind.Local).AddTicks(5177), new DateTime(2022, 4, 8, 14, 42, 59, 921, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 42, 59, 921, DateTimeKind.Local).AddTicks(5186), new DateTime(2022, 4, 15, 14, 42, 59, 921, DateTimeKind.Local).AddTicks(5182) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
