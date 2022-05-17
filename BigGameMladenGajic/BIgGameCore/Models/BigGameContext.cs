using BIgGameCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Extensions.Configuration;

namespace BigGame.Models.Context
{
    public class BigGameContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DbSet<BoatAvailability> BoatAvailabilities { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<ImageModel> Images { get; set; }

        public DbSet<BoatImage> BoatImages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("myDb1"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //USER
            modelBuilder.Entity<User>().HasKey(u => new { u.UserID });

            modelBuilder.Entity<User>()
                .HasMany<Reservation>(u => u.Reservations)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserID);

            modelBuilder.Entity<User>()
                .HasMany<Boat>(u => u.Boats)
                .WithOne(b => b.Owner)
                .HasForeignKey(b => b.OwnerID);


            //BOAT
            modelBuilder.Entity<Boat>().HasKey(b => new { b.BoatID });

            modelBuilder.Entity<Boat>()
                .HasOne<User>(b => b.Owner)
                .WithMany(u => u.Boats)
                .HasForeignKey(b => b.OwnerID);

            modelBuilder.Entity<Boat>()
                .HasMany<BoatAvailability>(b => b.boatAvailabilities)
                .WithOne(ba => ba.Boat)
                .HasForeignKey(ba => ba.BoatID);


            modelBuilder.Entity<Boat>()
                .HasMany<BoatImage>(b => b.BoatImages)
                .WithOne(bi => bi.Boat)
                .HasForeignKey(bi => bi.BoatId);

            //BOAT AVAILABILITY
            modelBuilder.Entity<BoatAvailability>().HasKey(ba => new { ba.BoatAvailabilityID });

            modelBuilder.Entity<BoatAvailability>()
                .HasMany<Reservation>(ba => ba.Reservations)
                .WithOne(r => r.BoatAvailability)
                .HasForeignKey(r => r.BoatAvailabilityID);


            //RESERVATION
            modelBuilder.Entity<Reservation>().HasKey(r => new { r.ReservationID });

            modelBuilder.Entity<Reservation>()
                .HasOne<BoatAvailability>(r => r.BoatAvailability)
                .WithMany(ba => ba.Reservations)
                .HasForeignKey( r => r.BoatAvailabilityID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reservation>()
                .HasOne<User>(r => r.User)
                .WithMany(u => u.Reservations)
                .HasForeignKey(r => r.UserID)
                .OnDelete(DeleteBehavior.Restrict);

            //SEED 
            
            User u1 = new User { UserID = 1, FirstName = "Mladen", LastName = "Gajic", Email = "mg@gmail.com", Password = "a", Phone = "12324", Boats = null, Reservations = null };
            modelBuilder.Entity<User>().HasData(
                u1,
                new User { UserID = 2, FirstName = "Ognjen", LastName = "Gajic", Email = "og@gmail.com", Password = "a", Phone = "111111", Boats = null, Reservations = null },
                new User { UserID = 3, FirstName = "Lazar", LastName = "Lazovic", Email = "ll@gmail.com", Password = "a", Phone = "12324", Boats = null, Reservations = null }
                );

            modelBuilder.Entity<Boat>().HasData(
                new Boat { BoatID = 1, Name = "Blue-Lagun", BedCount = 1, boatAvailabilities = null, Desctription = "Lagani brodic za uzivanje za dvoje , savrsen za parove", FuelCapacity = 34, Length = 22, Make = "Suzuki", Model = "Lagun", OwnerID = 1, Year = 2012, PassangerCapacity = 5, SleepCapacity = 2 },
                new Boat { BoatID = 2, Name = "MZ-35", BedCount = 0, boatAvailabilities = null, Desctription = "Fantastican mali brzi camac za adrenalinsku voznju.", FuelCapacity = 20, Length = 10, Make = "Yamaha", Model = "M32", OwnerID = 2, Year = 2015, PassangerCapacity = 4, SleepCapacity = 0 }, 
                new Boat { BoatID = 3, Name = "HR-50", BedCount = 2, boatAvailabilities = null, Desctription = "Dizajniran od kobilice naviše, kako bi se povećao prostor i funkcionalnost, 360 Outrage pruža iskustvo plovidbe bez napora i ogromnu količinu fleksibilnosti", FuelCapacity = 20, Length = 13, Make = "BRIG", Model = "Eagle 6", OwnerID = 1, Year = 2016, PassangerCapacity = 8, SleepCapacity = 4 },
                new Boat { BoatID = 4, Name = "Commit-36", BedCount = 0, boatAvailabilities = null, Desctription = "Brig Navigator 610 projektiran je za adrenalinsku plovidbu. To je 'crossover’ koncept za one koji žele izazivati sile prirode. ", FuelCapacity = 40, Length = 10, Make = "BRIG", Model = "Navigator 610", OwnerID =3, Year = 2002, PassangerCapacity = 5, SleepCapacity = 0 },
                new Boat { BoatID = 5, Name = "ZZbot", BedCount = 3, boatAvailabilities = null, Desctription = "Zodiac SRMN 550 s BRZIM PRISTUPNIM VRATIMA maksimalizira sigurnost uz ponudu svih klasičnih prednosti pneumatskih plovila. Izvorno napravljen za vojnu upotrebu (pojačan trup, izdržljive komore iz neopren hypalona sa Zodiacovim posebnim interkomunikacijskim ventilima)", FuelCapacity = 50, Length = 15, Make = "Zodiac", Model = "SRMN 550", OwnerID = 2, Year = 2012, PassangerCapacity = 14, SleepCapacity = 6 }
                );
            modelBuilder.Entity<BoatAvailability>().HasData(
                            new BoatAvailability { BoatAvailabilityID = 1, BoatID = 1, StartDate = DateTime.Now , EndDate = DateTime.Now.AddDays(7) , Location = "Budva", Price = 35.5f  , Reservations = null },
                            new BoatAvailability { BoatAvailabilityID = 2, BoatID = 1, StartDate = DateTime.Now.AddDays(7), EndDate = DateTime.Now.AddDays(14), Location = "Budva", Price = 40.5f, Reservations = null },
                            new BoatAvailability { BoatAvailabilityID = 3, BoatID = 4, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(7), Location = "Budva", Price = 15.5f, Reservations = null },
                            new BoatAvailability { BoatAvailabilityID = 4, BoatID = 3, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(7), Location = "Herceg Novi", Price = 20, Reservations = null },
                            new BoatAvailability { BoatAvailabilityID = 5, BoatID = 2, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(7), Location = "Herceg Novi", Price = 37f, Reservations = null },
                            new BoatAvailability { BoatAvailabilityID = 6, BoatID = 2, StartDate = DateTime.Now.AddDays(7), EndDate = DateTime.Now.AddDays(17), Location = "Budva", Price = 55.2f, Reservations = null }


                            );
            

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { ReservationID = 1 ,UserID = 1, BoatAvailabilityID = 1 , startDateTime =DateTime.Now.AddDays(1), endDateTime = DateTime.Now.AddDays(2)},
                new Reservation { ReservationID = 2, UserID = 2, BoatAvailabilityID = 3, startDateTime = DateTime.Now.AddDays(1), endDateTime = DateTime.Now.AddDays(2) }
                );
            
        }
    }   
}