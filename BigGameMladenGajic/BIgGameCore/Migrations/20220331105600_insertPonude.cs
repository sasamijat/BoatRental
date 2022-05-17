using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BIgGameCore.Migrations
{
    public partial class insertPonude : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BoatAvailabilities",
                columns: new[] { "BoatAvailabilityID", "BoatID", "EndDate", "Location", "Price", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 4, 7, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(7737), "Budva", 35.5f, new DateTime(2022, 3, 31, 12, 55, 59, 556, DateTimeKind.Local).AddTicks(5506) },
                    { 2, 1, new DateTime(2022, 4, 14, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9157), "Budva", 40.5f, new DateTime(2022, 4, 7, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9141) },
                    { 3, 4, new DateTime(2022, 4, 7, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9165), "Budva", 15.5f, new DateTime(2022, 3, 31, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9162) },
                    { 4, 3, new DateTime(2022, 4, 7, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9171), "Herceg Novi", 20f, new DateTime(2022, 3, 31, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9169) },
                    { 5, 2, new DateTime(2022, 4, 7, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9177), "Herceg Novi", 37f, new DateTime(2022, 3, 31, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9174) },
                    { 6, 2, new DateTime(2022, 4, 17, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9183), "Budva", 55.2f, new DateTime(2022, 4, 7, 12, 55, 59, 558, DateTimeKind.Local).AddTicks(9180) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
