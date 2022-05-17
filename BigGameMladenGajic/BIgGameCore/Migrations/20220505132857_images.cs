using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIgGameCore.Migrations
{
    public partial class images : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 12, 15, 28, 56, 459, DateTimeKind.Local).AddTicks(4271), new DateTime(2022, 5, 5, 15, 28, 56, 457, DateTimeKind.Local).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 19, 15, 28, 56, 459, DateTimeKind.Local).AddTicks(5745), new DateTime(2022, 5, 12, 15, 28, 56, 459, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 12, 15, 28, 56, 459, DateTimeKind.Local).AddTicks(5753), new DateTime(2022, 5, 5, 15, 28, 56, 459, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 12, 15, 28, 56, 459, DateTimeKind.Local).AddTicks(5759), new DateTime(2022, 5, 5, 15, 28, 56, 459, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 12, 15, 28, 56, 459, DateTimeKind.Local).AddTicks(5765), new DateTime(2022, 5, 5, 15, 28, 56, 459, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 22, 15, 28, 56, 459, DateTimeKind.Local).AddTicks(5771), new DateTime(2022, 5, 12, 15, 28, 56, 459, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 5, 7, 15, 28, 56, 459, DateTimeKind.Local).AddTicks(7472), new DateTime(2022, 5, 6, 15, 28, 56, 459, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 2,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 5, 7, 15, 28, 56, 459, DateTimeKind.Local).AddTicks(7779), new DateTime(2022, 5, 6, 15, 28, 56, 459, DateTimeKind.Local).AddTicks(7768) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

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
    }
}
