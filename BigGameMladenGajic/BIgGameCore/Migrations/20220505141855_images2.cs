using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIgGameCore.Migrations
{
    public partial class images2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Images");

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Attachment",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attachment",
                table: "Images");

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Images",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Images",
                type: "nvarchar(50)",
                nullable: true);

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
    }
}
