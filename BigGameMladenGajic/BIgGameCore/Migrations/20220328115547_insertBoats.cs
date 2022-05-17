using Microsoft.EntityFrameworkCore.Migrations;

namespace BIgGameCore.Migrations
{
    public partial class insertBoats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Boats",
                keyColumn: "BoatID",
                keyValue: 1,
                column: "Name",
                value: "Blue-Lagun");

            migrationBuilder.InsertData(
                table: "Boats",
                columns: new[] { "BoatID", "BedCount", "Desctription", "FuelCapacity", "Length", "Make", "Model", "Name", "OwnerID", "PassangerCapacity", "SleepCapacity", "Year" },
                values: new object[,]
                {
                    { 2, 0, "Fantastican mali brzi camac za adrenalinsku voznju.", 20f, 10f, "Yamaha", "M32", "MZ-35", 2, 4, 0, 2015 },
                    { 3, 2, "Dizajniran od kobilice naviše, kako bi se povećao prostor i funkcionalnost, 360 Outrage pruža iskustvo plovidbe bez napora i ogromnu količinu fleksibilnosti", 20f, 13f, "BRIG", "Eagle 6", "HR-50", 1, 8, 4, 2016 },
                    { 4, 0, "Brig Navigator 610 projektiran je za adrenalinsku plovidbu. To je 'crossover’ koncept za one koji žele izazivati sile prirode. ", 40f, 10f, "BRIG", "Navigator 610", "Commit-36", 3, 5, 0, 2002 },
                    { 5, 3, "Zodiac SRMN 550 s BRZIM PRISTUPNIM VRATIMA maksimalizira sigurnost uz ponudu svih klasičnih prednosti pneumatskih plovila. Izvorno napravljen za vojnu upotrebu (pojačan trup, izdržljive komore iz neopren hypalona sa Zodiacovim posebnim interkomunikacijskim ventilima)", 50f, 15f, "Zodiac", "SRMN 550", "ZZbot", 2, 14, 6, 2012 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "BoatID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "BoatID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "BoatID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Boats",
                keyColumn: "BoatID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Boats",
                keyColumn: "BoatID",
                keyValue: 1,
                column: "Name",
                value: "Blue Lagun");
        }
    }
}
