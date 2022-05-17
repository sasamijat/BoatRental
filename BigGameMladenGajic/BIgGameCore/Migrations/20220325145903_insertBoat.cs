using Microsoft.EntityFrameworkCore.Migrations;

namespace BIgGameCore.Migrations
{
    public partial class insertBoat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Boats",
                columns: new[] { "BoatID", "BedCount", "Desctription", "FuelCapacity", "Length", "Make", "Model", "Name", "OwnerID", "PassangerCapacity", "SleepCapacity", "Year" },
                values: new object[] { 1, 1, "Lagani brodic za uzivanje za dvoje , savrsen za parove", 34f, 22f, "Suzuki", "Lagun", "Blue Lagun", 1, 5, 2, 2012 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "BoatID",
                keyValue: 1);
        }
    }
}
