using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIgGameCore.Migrations
{
    public partial class addReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_BoatAvailabilities_BoatAvailabilityID",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Users_UserID",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "Reservations");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_UserID",
                table: "Reservations",
                newName: "IX_Reservations_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_BoatAvailabilityID",
                table: "Reservations",
                newName: "IX_Reservations_BoatAvailabilityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "ReservationID");


            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 53, 39, 661, DateTimeKind.Local).AddTicks(5415), new DateTime(2022, 4, 9, 16, 53, 39, 661, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_BoatAvailabilities_BoatAvailabilityID",
                table: "Reservations",
                column: "BoatAvailabilityID",
                principalTable: "BoatAvailabilities",
                principalColumn: "BoatAvailabilityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_UserID",
                table: "Reservations",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_BoatAvailabilities_BoatAvailabilityID",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_UserID",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.DeleteData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BoatAvailabilities",
                keyColumn: "BoatAvailabilityID",
                keyValue: 6);

            migrationBuilder.RenameTable(
                name: "Reservations",
                newName: "Reservation");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_UserID",
                table: "Reservation",
                newName: "IX_Reservation_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_BoatAvailabilityID",
                table: "Reservation",
                newName: "IX_Reservation_BoatAvailabilityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                column: "ReservationID");

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "endDateTime", "startDateTime" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 52, 25, 225, DateTimeKind.Local).AddTicks(8149), new DateTime(2022, 4, 9, 16, 52, 25, 223, DateTimeKind.Local).AddTicks(5266) });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_BoatAvailabilities_BoatAvailabilityID",
                table: "Reservation",
                column: "BoatAvailabilityID",
                principalTable: "BoatAvailabilities",
                principalColumn: "BoatAvailabilityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Users_UserID",
                table: "Reservation",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
