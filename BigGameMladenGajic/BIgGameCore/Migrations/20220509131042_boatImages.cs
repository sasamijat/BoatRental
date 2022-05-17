using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIgGameCore.Migrations
{
    public partial class boatImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoatImage_Boats_BoatId",
                table: "BoatImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoatImage",
                table: "BoatImage");

            migrationBuilder.RenameTable(
                name: "BoatImage",
                newName: "BoatImages");

            migrationBuilder.RenameIndex(
                name: "IX_BoatImage_BoatId",
                table: "BoatImages",
                newName: "IX_BoatImages_BoatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoatImages",
                table: "BoatImages",
                column: "id");

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 16, 15, 10, 41, 467, DateTimeKind.Local).AddTicks(6996), new DateTime(2022, 5, 9, 15, 10, 41, 465, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 23, 15, 10, 41, 467, DateTimeKind.Local).AddTicks(8423), new DateTime(2022, 5, 16, 15, 10, 41, 467, DateTimeKind.Local).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 16, 15, 10, 41, 467, DateTimeKind.Local).AddTicks(8431), new DateTime(2022, 5, 9, 15, 10, 41, 467, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 16, 15, 10, 41, 467, DateTimeKind.Local).AddTicks(8437), new DateTime(2022, 5, 9, 15, 10, 41, 467, DateTimeKind.Local).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 16, 15, 10, 41, 467, DateTimeKind.Local).AddTicks(8443), new DateTime(2022, 5, 9, 15, 10, 41, 467, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 26, 15, 10, 41, 467, DateTimeKind.Local).AddTicks(8449), new DateTime(2022, 5, 16, 15, 10, 41, 467, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 5, 11, 15, 10, 41, 468, DateTimeKind.Local).AddTicks(245), new DateTime(2022, 5, 10, 15, 10, 41, 467, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 2,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 5, 11, 15, 10, 41, 468, DateTimeKind.Local).AddTicks(554), new DateTime(2022, 5, 10, 15, 10, 41, 468, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.AddForeignKey(
                name: "FK_BoatImages_Boats_BoatId",
                table: "BoatImages",
                column: "BoatId",
                principalTable: "Boats",
                principalColumn: "BoatID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoatImages_Boats_BoatId",
                table: "BoatImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoatImages",
                table: "BoatImages");

            migrationBuilder.RenameTable(
                name: "BoatImages",
                newName: "BoatImage");

            migrationBuilder.RenameIndex(
                name: "IX_BoatImages_BoatId",
                table: "BoatImage",
                newName: "IX_BoatImage_BoatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoatImage",
                table: "BoatImage",
                column: "id");

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 16, 12, 4, 13, 210, DateTimeKind.Local).AddTicks(3092), new DateTime(2022, 5, 9, 12, 4, 13, 208, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 23, 12, 4, 13, 210, DateTimeKind.Local).AddTicks(4501), new DateTime(2022, 5, 16, 12, 4, 13, 210, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 16, 12, 4, 13, 210, DateTimeKind.Local).AddTicks(4508), new DateTime(2022, 5, 9, 12, 4, 13, 210, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 16, 12, 4, 13, 210, DateTimeKind.Local).AddTicks(4515), new DateTime(2022, 5, 9, 12, 4, 13, 210, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 16, 12, 4, 13, 210, DateTimeKind.Local).AddTicks(4521), new DateTime(2022, 5, 9, 12, 4, 13, 210, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 26, 12, 4, 13, 210, DateTimeKind.Local).AddTicks(4527), new DateTime(2022, 5, 16, 12, 4, 13, 210, DateTimeKind.Local).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 5, 11, 12, 4, 13, 210, DateTimeKind.Local).AddTicks(6198), new DateTime(2022, 5, 10, 12, 4, 13, 210, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 2,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 5, 11, 12, 4, 13, 210, DateTimeKind.Local).AddTicks(6501), new DateTime(2022, 5, 10, 12, 4, 13, 210, DateTimeKind.Local).AddTicks(6491) });

            migrationBuilder.AddForeignKey(
                name: "FK_BoatImage_Boats_BoatId",
                table: "BoatImage",
                column: "BoatId",
                principalTable: "Boats",
                principalColumn: "BoatID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
