using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelWorkOrderManagement.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Domain", "IsDeleted", "MembersCount", "Name" },
                values: new object[] { 1, "Maintaining", false, 2, "Majstori" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsDeleted", "LastName", "Name", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1, false, "Krsmanovic", "Milomir", "55555", 2, "milomir" },
                    { 2, false, "Milanovic", "Milica", "123456", 1, "milic@" },
                    { 3, false, "Smiljanic", "Nikola", "4444", 0, "nikola" }
                });

            migrationBuilder.InsertData(
                table: "EquipmentPieces",
                columns: new[] { "Id", "InstalatedById", "InstalationDate", "IsDeleted", "LastIntervention", "Name", "NumOfInterventions" },
                values: new object[] { 1, 3, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Klima", 0 });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "GroupId", "TechnicianId", "Id", "IsDeleted", "Leader" },
                values: new object[] { 1, 3, 1, false, true });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "AsigneeGroupId", "AsigneeIndividualId", "CreatedById", "CreatedOn", "Description", "Domain", "EquipmentToRepairId", "FinishedOn", "IsDeleted", "Name", "Position", "Priority", "RepetitiveSetting", "RepetitiveStart", "Status" },
                values: new object[] { 2, null, null, 1, new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oprati koristenu posteljinu i postaviti novu", "HouseKeeping", null, new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Pranje posteljine", "210", "Normal", null, null, "Finished" });

            migrationBuilder.InsertData(
                table: "TaskStateChanges",
                columns: new[] { "Id", "ExecutorId", "IsDeleted", "Status", "TaskId" },
                values: new object[] { 1, 3, false, "Finished", 2 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "AsigneeGroupId", "AsigneeIndividualId", "CreatedById", "CreatedOn", "Description", "Domain", "EquipmentToRepairId", "FinishedOn", "IsDeleted", "Name", "Position", "Priority", "RepetitiveSetting", "RepetitiveStart", "Status" },
                values: new object[] { 1, 1, null, 1, new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zamjena crijeva na klima uredjaju", "Maintaining", 1, null, false, "Popravka Klime", "304", "High", null, null, "Active" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Created", "CreatedById", "IsDeleted", "ReplyId", "TaskID", "Text" },
                values: new object[] { 2, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, null, 1, "Uredu" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Created", "CreatedById", "IsDeleted", "ReplyId", "TaskID", "Text" },
                values: new object[] { 1, new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 2, 1, "Zadatak izvrsiti sto prije" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumns: new[] { "GroupId", "TechnicianId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "TaskStateChanges",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EquipmentPieces",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
