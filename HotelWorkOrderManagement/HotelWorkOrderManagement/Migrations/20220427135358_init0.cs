﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelWorkOrderManagement.Migrations
{
    public partial class init0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MembersCount = table.Column<int>(type: "int", nullable: false),
                    SelfTaskAssign = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentPieces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumOfInterventions = table.Column<int>(type: "int", nullable: false),
                    InstalationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastIntervention = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InstalatedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentPieces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipmentPieces_Users_InstalatedById",
                        column: x => x.InstalatedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    Leader = table.Column<bool>(type: "bit", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => new { x.GroupId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Members_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Members_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AsigneeIndividualId = table.Column<int>(type: "int", nullable: true),
                    AsigneeGroupId = table.Column<int>(type: "int", nullable: true),
                    EquipmentToRepairId = table.Column<int>(type: "int", nullable: true),
                    RepetitiveStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RepetitiveSetting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_EquipmentPieces_EquipmentToRepairId",
                        column: x => x.EquipmentToRepairId,
                        principalTable: "EquipmentPieces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tasks_Groups_AsigneeGroupId",
                        column: x => x.AsigneeGroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tasks_Users_AsigneeIndividualId",
                        column: x => x.AsigneeIndividualId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tasks_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskID = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    CommentImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Tasks_TaskID",
                        column: x => x.TaskID,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskStateChanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    ExecutorId = table.Column<int>(type: "int", nullable: false),
                    DateOfChange = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskStateChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskStateChanges_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskStateChanges_Users_ExecutorId",
                        column: x => x.ExecutorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Domain", "IsDeleted", "MembersCount", "Name", "SelfTaskAssign" },
                values: new object[] { 1, "Maintaining", false, 2, "Majstori", true });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsDeleted", "LastName", "Name", "Password", "ProfileImage", "Role", "Username" },
                values: new object[,]
                {
                    { 1, false, "Krsmanovic", "Milomir", "55555", null, 2, "milomir" },
                    { 2, false, "Milanovic", "Milica", "123456", null, 1, "milic@" },
                    { 3, false, "Smiljanic", "Nikola", "4444", null, 0, "nikola" }
                });

            migrationBuilder.InsertData(
                table: "EquipmentPieces",
                columns: new[] { "Id", "InstalatedById", "InstalationDate", "IsDeleted", "LastIntervention", "Name", "NumOfInterventions" },
                values: new object[] { 1, 3, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Klima", 0 });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "GroupId", "UserId", "Id", "IsDeleted", "Leader" },
                values: new object[] { 1, 3, 1, false, true });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "AsigneeGroupId", "AsigneeIndividualId", "CreatedById", "CreatedOn", "Description", "Domain", "DueDate", "EquipmentToRepairId", "IsDeleted", "Name", "Position", "Priority", "RepetitiveSetting", "RepetitiveStart", "Status" },
                values: new object[] { 2, null, 2, 1, new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oprati koristenu posteljinu i postaviti novu", "HouseKeeping", new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Pranje posteljine", "210", "Normal", null, null, "Finished" });

            migrationBuilder.InsertData(
                table: "TaskStateChanges",
                columns: new[] { "Id", "DateOfChange", "Description", "ExecutorId", "IsDeleted", "Status", "TaskId" },
                values: new object[] { 1, new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Promjenu izvrsio po zavrsetku zadatka", 3, false, "Finished", 2 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "AsigneeGroupId", "AsigneeIndividualId", "CreatedById", "CreatedOn", "Description", "Domain", "DueDate", "EquipmentToRepairId", "IsDeleted", "Name", "Position", "Priority", "RepetitiveSetting", "RepetitiveStart", "Status" },
                values: new object[,]
                {
                    { 1, 1, null, 1, new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zamjena crijeva na klima uredjaju", "Maintaining", new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "Popravka Klime", "304", "High", null, null, "Active" },
                    { 3, null, 3, 1, new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Popraviti ili zamijeniti vodokotlic", "Maintaining", new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "Popravka Vodokotlica", "304", "High", null, null, "Active" },
                    { 4, 1, null, 1, new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zamjena pokvarene sijalice", "Maintaining", new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, "Zamjena sijalice", "304", "High", null, null, "Active" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentImage", "Created", "CreatedById", "IsDeleted", "TaskID", "Text" },
                values: new object[] { 1, null, new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 1, "Zadatak izvrsiti sto prije" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentImage", "Created", "CreatedById", "IsDeleted", "TaskID", "Text" },
                values: new object[] { 2, null, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, 1, "Uredu" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CreatedById",
                table: "Comments",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TaskID",
                table: "Comments",
                column: "TaskID");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentPieces_InstalatedById",
                table: "EquipmentPieces",
                column: "InstalatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Members_UserId",
                table: "Members",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AsigneeGroupId",
                table: "Tasks",
                column: "AsigneeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AsigneeIndividualId",
                table: "Tasks",
                column: "AsigneeIndividualId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CreatedById",
                table: "Tasks",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_EquipmentToRepairId",
                table: "Tasks",
                column: "EquipmentToRepairId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskStateChanges_ExecutorId",
                table: "TaskStateChanges",
                column: "ExecutorId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskStateChanges_TaskId",
                table: "TaskStateChanges",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "TaskStateChanges");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "EquipmentPieces");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}