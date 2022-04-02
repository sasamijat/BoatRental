﻿// <auto-generated />
using System;
using HotelWorkOrderManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelWorkOrderManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220401133619_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HotelWorkOrderManagement.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ReplyId")
                        .HasColumnType("int");

                    b.Property<int>("TaskID")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ReplyId");

                    b.HasIndex("TaskID");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedById = 1,
                            IsDeleted = false,
                            ReplyId = 2,
                            TaskID = 1,
                            Text = "Zadatak izvrsiti sto prije"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedById = 2,
                            IsDeleted = false,
                            TaskID = 1,
                            Text = "Uredu"
                        });
                });

            modelBuilder.Entity("HotelWorkOrderManagement.Models.EquipmentPiece", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("InstalatedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("InstalationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastIntervention")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumOfInterventions")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InstalatedById");

                    b.ToTable("EquipmentPieces");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InstalatedById = 3,
                            InstalationDate = new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Klima",
                            NumOfInterventions = 0
                        });
                });

            modelBuilder.Entity("HotelWorkOrderManagement.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MembersCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Domain = "Maintaining",
                            IsDeleted = false,
                            MembersCount = 2,
                            Name = "Majstori"
                        });
                });

            modelBuilder.Entity("HotelWorkOrderManagement.Models.Member", b =>
                {
                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("TechnicianId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("Leader")
                        .HasColumnType("bit");

                    b.HasKey("GroupId", "TechnicianId");

                    b.HasIndex("TechnicianId");

                    b.ToTable("Member");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            TechnicianId = 3,
                            Id = 1,
                            IsDeleted = false,
                            Leader = true
                        });
                });

            modelBuilder.Entity("HotelWorkOrderManagement.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AsigneeGroupId")
                        .HasColumnType("int");

                    b.Property<int?>("AsigneeIndividualId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EquipmentToRepairId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FinishedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RepetitiveSetting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RepetitiveStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AsigneeGroupId");

                    b.HasIndex("AsigneeIndividualId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("EquipmentToRepairId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AsigneeGroupId = 1,
                            CreatedById = 1,
                            CreatedOn = new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Zamjena crijeva na klima uredjaju",
                            Domain = "Maintaining",
                            EquipmentToRepairId = 1,
                            IsDeleted = false,
                            Name = "Popravka Klime",
                            Position = "304",
                            Priority = "High",
                            Status = "Active"
                        },
                        new
                        {
                            Id = 2,
                            CreatedById = 1,
                            CreatedOn = new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Oprati koristenu posteljinu i postaviti novu",
                            Domain = "HouseKeeping",
                            FinishedOn = new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Pranje posteljine",
                            Position = "210",
                            Priority = "Normal",
                            Status = "Finished"
                        });
                });

            modelBuilder.Entity("HotelWorkOrderManagement.Models.TaskStateChange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ExecutorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExecutorId");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskStateChanges");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExecutorId = 3,
                            IsDeleted = false,
                            Status = "Finished",
                            TaskId = 2
                        });
                });

            modelBuilder.Entity("HotelWorkOrderManagement.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            LastName = "Krsmanovic",
                            Name = "Milomir",
                            Password = "55555",
                            Role = 2,
                            Username = "milomir"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            LastName = "Milanovic",
                            Name = "Milica",
                            Password = "123456",
                            Role = 1,
                            Username = "milic@"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            LastName = "Smiljanic",
                            Name = "Nikola",
                            Password = "4444",
                            Role = 0,
                            Username = "nikola"
                        });
                });

            modelBuilder.Entity("HotelWorkOrderManagement.Models.Comment", b =>
                {
                    b.HasOne("HotelWorkOrderManagement.Models.User", "CreatedBy")
                        .WithMany("Comments")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelWorkOrderManagement.Models.Comment", "Reply")
                        .WithMany("Comments")
                        .HasForeignKey("ReplyId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("HotelWorkOrderManagement.Models.Task", "Task")
                        .WithMany("Comments")
                        .HasForeignKey("TaskID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("Reply");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("HotelWorkOrderManagement.Models.EquipmentPiece", b =>
                {
                    b.HasOne("HotelWorkOrderManagement.Models.User", "InstalatedBy")
                        .WithMany("EquipmentPieces")
                        .HasForeignKey("InstalatedById");

                    b.Navigation("InstalatedBy");
                });

            modelBuilder.Entity("HotelWorkOrderManagement.Models.Member", b =>
                {
                    b.HasOne("HotelWorkOrderManagement.Models.Group", "Group")
                        .WithMany("Members")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelWorkOrderManagement.Models.User", "Technician")
                        .WithMany("Members")
                        .HasForeignKey("TechnicianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Technician");
                });

            modelBuilder.Entity("HotelWorkOrderManagement.Models.Task", b =>
                {
                    b.HasOne("HotelWorkOrderManagement.Models.Group", "AsigneeGroup")
                        .WithMany("Tasks")
                        .HasForeignKey("AsigneeGroupId");

                    b.HasOne("HotelWorkOrderManagement.Models.User", "AsigneeIndividual")
                        .WithMany("TaskAsignees")
                        .HasForeignKey("AsigneeIndividualId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("HotelWorkOrderManagement.Models.User", "CreatedBy")
                        .WithMany("TaskCreators")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("HotelWorkOrderManagement.Models.EquipmentPiece", "EquipmentToRepair")
                        .WithMany("Tasks")
                        .HasForeignKey("EquipmentToRepairId");

                    b.Navigation("AsigneeGroup");

                    b.Navigation("AsigneeIndividual");

                    b.Navigation("CreatedBy");

                    b.Navigation("EquipmentToRepair");
                });

            modelBuilder.Entity("HotelWorkOrderManagement.Models.TaskStateChange", b =>
                {
                    b.HasOne("HotelWorkOrderManagement.Models.User", "Executor")
                        .WithMany("TaskStateChanges")
                        .HasForeignKey("ExecutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelWorkOrderManagement.Models.Task", "Task")
                        .WithMany("TaskStateChanges")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Executor");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("HotelWorkOrderManagement.Models.Comment", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("HotelWorkOrderManagement.Models.EquipmentPiece", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("HotelWorkOrderManagement.Models.Group", b =>
                {
                    b.Navigation("Members");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("HotelWorkOrderManagement.Models.Task", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("TaskStateChanges");
                });

            modelBuilder.Entity("HotelWorkOrderManagement.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("EquipmentPieces");

                    b.Navigation("Members");

                    b.Navigation("TaskAsignees");

                    b.Navigation("TaskCreators");

                    b.Navigation("TaskStateChanges");
                });
#pragma warning restore 612, 618
        }
    }
}
