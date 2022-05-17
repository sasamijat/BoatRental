﻿// <auto-generated />
using System;
using BigGame.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BIgGameCore.Migrations
{
    [DbContext(typeof(BigGameContext))]
    [Migration("20220505141855_images2")]
    partial class images2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BIgGameCore.Models.ImageModel", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Attachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("BigGame.Models.Boat", b =>
                {
                    b.Property<int>("BoatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BedCount")
                        .HasColumnType("int");

                    b.Property<string>("Desctription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("FuelCapacity")
                        .HasColumnType("real");

                    b.Property<float>("Length")
                        .HasColumnType("real");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerID")
                        .HasColumnType("int");

                    b.Property<int>("PassangerCapacity")
                        .HasColumnType("int");

                    b.Property<int>("SleepCapacity")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("BoatID");

                    b.HasIndex("OwnerID");

                    b.ToTable("Boats");

                    b.HasData(
                        new
                        {
                            BoatID = 1,
                            BedCount = 1,
                            Desctription = "Lagani brodic za uzivanje za dvoje , savrsen za parove",
                            FuelCapacity = 34f,
                            Length = 22f,
                            Make = "Suzuki",
                            Model = "Lagun",
                            Name = "Blue-Lagun",
                            OwnerID = 1,
                            PassangerCapacity = 5,
                            SleepCapacity = 2,
                            Year = 2012
                        },
                        new
                        {
                            BoatID = 2,
                            BedCount = 0,
                            Desctription = "Fantastican mali brzi camac za adrenalinsku voznju.",
                            FuelCapacity = 20f,
                            Length = 10f,
                            Make = "Yamaha",
                            Model = "M32",
                            Name = "MZ-35",
                            OwnerID = 2,
                            PassangerCapacity = 4,
                            SleepCapacity = 0,
                            Year = 2015
                        },
                        new
                        {
                            BoatID = 3,
                            BedCount = 2,
                            Desctription = "Dizajniran od kobilice naviše, kako bi se povećao prostor i funkcionalnost, 360 Outrage pruža iskustvo plovidbe bez napora i ogromnu količinu fleksibilnosti",
                            FuelCapacity = 20f,
                            Length = 13f,
                            Make = "BRIG",
                            Model = "Eagle 6",
                            Name = "HR-50",
                            OwnerID = 1,
                            PassangerCapacity = 8,
                            SleepCapacity = 4,
                            Year = 2016
                        },
                        new
                        {
                            BoatID = 4,
                            BedCount = 0,
                            Desctription = "Brig Navigator 610 projektiran je za adrenalinsku plovidbu. To je 'crossover’ koncept za one koji žele izazivati sile prirode. ",
                            FuelCapacity = 40f,
                            Length = 10f,
                            Make = "BRIG",
                            Model = "Navigator 610",
                            Name = "Commit-36",
                            OwnerID = 3,
                            PassangerCapacity = 5,
                            SleepCapacity = 0,
                            Year = 2002
                        },
                        new
                        {
                            BoatID = 5,
                            BedCount = 3,
                            Desctription = "Zodiac SRMN 550 s BRZIM PRISTUPNIM VRATIMA maksimalizira sigurnost uz ponudu svih klasičnih prednosti pneumatskih plovila. Izvorno napravljen za vojnu upotrebu (pojačan trup, izdržljive komore iz neopren hypalona sa Zodiacovim posebnim interkomunikacijskim ventilima)",
                            FuelCapacity = 50f,
                            Length = 15f,
                            Make = "Zodiac",
                            Model = "SRMN 550",
                            Name = "ZZbot",
                            OwnerID = 2,
                            PassangerCapacity = 14,
                            SleepCapacity = 6,
                            Year = 2012
                        });
                });

            modelBuilder.Entity("BigGame.Models.BoatAvailability", b =>
                {
                    b.Property<int>("BoatAvailabilityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BoatID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BoatAvailabilityID");

                    b.HasIndex("BoatID");

                    b.ToTable("BoatAvailabilities");

                    b.HasData(
                        new
                        {
                            BoatAvailabilityID = 1,
                            BoatID = 1,
                            EndDate = new DateTime(2022, 5, 12, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(5548),
                            Location = "Budva",
                            Price = 35.5f,
                            StartDate = new DateTime(2022, 5, 5, 16, 18, 54, 536, DateTimeKind.Local).AddTicks(2448)
                        },
                        new
                        {
                            BoatAvailabilityID = 2,
                            BoatID = 1,
                            EndDate = new DateTime(2022, 5, 19, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7032),
                            Location = "Budva",
                            Price = 40.5f,
                            StartDate = new DateTime(2022, 5, 12, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7018)
                        },
                        new
                        {
                            BoatAvailabilityID = 3,
                            BoatID = 4,
                            EndDate = new DateTime(2022, 5, 12, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7094),
                            Location = "Budva",
                            Price = 15.5f,
                            StartDate = new DateTime(2022, 5, 5, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7091)
                        },
                        new
                        {
                            BoatAvailabilityID = 4,
                            BoatID = 3,
                            EndDate = new DateTime(2022, 5, 12, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7101),
                            Location = "Herceg Novi",
                            Price = 20f,
                            StartDate = new DateTime(2022, 5, 5, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7099)
                        },
                        new
                        {
                            BoatAvailabilityID = 5,
                            BoatID = 2,
                            EndDate = new DateTime(2022, 5, 12, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7107),
                            Location = "Herceg Novi",
                            Price = 37f,
                            StartDate = new DateTime(2022, 5, 5, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7105)
                        },
                        new
                        {
                            BoatAvailabilityID = 6,
                            BoatID = 2,
                            EndDate = new DateTime(2022, 5, 22, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7113),
                            Location = "Budva",
                            Price = 55.2f,
                            StartDate = new DateTime(2022, 5, 12, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(7110)
                        });
                });

            modelBuilder.Entity("BigGame.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BoatAvailabilityID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("endDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("startDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("ReservationID");

                    b.HasIndex("BoatAvailabilityID");

                    b.HasIndex("UserID");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            ReservationID = 1,
                            BoatAvailabilityID = 1,
                            UserID = 1,
                            endDateTime = new DateTime(2022, 5, 7, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(8777),
                            startDateTime = new DateTime(2022, 5, 6, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(8469),
                            status = 0
                        },
                        new
                        {
                            ReservationID = 2,
                            BoatAvailabilityID = 3,
                            UserID = 2,
                            endDateTime = new DateTime(2022, 5, 7, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(9077),
                            startDateTime = new DateTime(2022, 5, 6, 16, 18, 54, 538, DateTimeKind.Local).AddTicks(9067),
                            status = 0
                        });
                });

            modelBuilder.Entity("BigGame.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Email = "mg@gmail.com",
                            FirstName = "Mladen",
                            LastName = "Gajic",
                            Password = "a",
                            Phone = "12324"
                        },
                        new
                        {
                            UserID = 2,
                            Email = "og@gmail.com",
                            FirstName = "Ognjen",
                            LastName = "Gajic",
                            Password = "a",
                            Phone = "111111"
                        },
                        new
                        {
                            UserID = 3,
                            Email = "ll@gmail.com",
                            FirstName = "Lazar",
                            LastName = "Lazovic",
                            Password = "a",
                            Phone = "12324"
                        });
                });

            modelBuilder.Entity("BigGame.Models.Boat", b =>
                {
                    b.HasOne("BigGame.Models.User", "Owner")
                        .WithMany("Boats")
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("BigGame.Models.BoatAvailability", b =>
                {
                    b.HasOne("BigGame.Models.Boat", "Boat")
                        .WithMany("boatAvailabilities")
                        .HasForeignKey("BoatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Boat");
                });

            modelBuilder.Entity("BigGame.Models.Reservation", b =>
                {
                    b.HasOne("BigGame.Models.BoatAvailability", "BoatAvailability")
                        .WithMany("Reservations")
                        .HasForeignKey("BoatAvailabilityID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BigGame.Models.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BoatAvailability");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BigGame.Models.Boat", b =>
                {
                    b.Navigation("boatAvailabilities");
                });

            modelBuilder.Entity("BigGame.Models.BoatAvailability", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("BigGame.Models.User", b =>
                {
                    b.Navigation("Boats");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
