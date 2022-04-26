namespace BoatsMontenegro.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BoatsMontenegro.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BoatsMontenegro.BaseBase.BaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(BoatsMontenegro.BaseBase.BaseContext context)
        {
            #region -------------------USER------------------- 
            if (!context.Users.Any())
            {
                var users = new List<User>
                {
                    new User {UserID=1, FirstName = "Blagoje", LastName = "Jovovic", Email = "2metkazapavelica@gmail.com", Password = "1953", PersonalIdNumber = "655223984", PhoneNumber = "+38160787686767", Username="blagojej" },
                    new User {UserID=2,  FirstName = "Kristina", LastName = "Mirkovic", Email = "kristinakris@yahoo.com", Password = "4745", PersonalIdNumber = "412887564", PhoneNumber = "+3816079879+",Username="kristinam" },
                    new User {UserID=3,  FirstName = "Dijana", LastName = "Lazic", Email = "dijanalazicdiks@gmail.com", Password = "8896", PersonalIdNumber = "963365477", PhoneNumber = "+38160645646",Username="dijanal" },
                    new User {UserID=4,  FirstName = "Gavrilo", LastName = "Principovic", Email = "mladabosna@outlook.com", Password = "1914", PersonalIdNumber = "852336889", PhoneNumber = "+38160796456",Username="gavrilop" },
                    new User {UserID=5,  FirstName = "Ratko", LastName = "Mladicevic", Email = "koridor92@gmail.com", Password = "1992", PersonalIdNumber = "2144533564", PhoneNumber = "+38160789789",Username="ratkom" }
                };
                users.ForEach(user => context.Users.Add(user));
                context.SaveChanges();
            }
            #endregion
            

            #region -------------------BOAT------------------- 
            if (!context.Boats.Any())
                {
                    var boats = new List<Boat>
                    {
                        new Boat { Capacity = 11, Engine = "5.8 Disel", FuelConsumption = "25l 100km", Size = "21m" },
                        new Boat { Capacity = 6, Engine = "4.0 Petrol", FuelConsumption = "15l per 100km", Size = "11m" },
                        new Boat { Capacity = 5, Engine = "3.8 Petrol", FuelConsumption = "12l per 100km", Size = "9m" },
                        new Boat { Capacity = 3, Engine = "5.5 Diesel", FuelConsumption = "9l per 100km", Size = "6m" },
                        new Boat { Capacity = 10, Engine = "5.3 Petrol", FuelConsumption = "17l per 100km", Size = "13m" },
                        new Boat { Capacity = 15, Engine = "4.3 Petrol", FuelConsumption = "15l per 100km", Size = "14m" },
                        new Boat { Capacity = 16, Engine = "3.8 Petrol", FuelConsumption = "16l per 100km", Size = "17m" }
                    };
                    boats.ForEach(boat => context.Boats.Add(boat));
                    context.SaveChanges();
                }
                #endregion

            #region ------------------- RESERVATION------------------- 
                if (!context.Reservations.Any())
                {
                    var reservations = new List<Reservation>
                    {
                        new Reservation { DateFrom = new DateTime(2022, 08, 18), DateTo = new DateTime(2022, 09, 23), NeedCaptain = true },
                        new Reservation { DateFrom = new DateTime(2022, 04, 28), DateTo = new DateTime(2022, 07, 12), NeedCaptain = true },
                        new Reservation { DateFrom = new DateTime(2022, 03, 14), DateTo = new DateTime(2022, 08, 08), NeedCaptain = false },
                        new Reservation { DateFrom = new DateTime(2022, 02, 10), DateTo = new DateTime(2022, 06, 17), NeedCaptain = true },
                        new Reservation { DateFrom = new DateTime(2022, 05, 21), DateTo = new DateTime(2022, 04, 06), NeedCaptain = false }
                    };
                    reservations.ForEach(reservation => context.Reservations.Add(reservation));
                    context.SaveChanges();
                }
            #endregion

            #region -----------ROLE--------------
            if (!context.Roles.Any())
            {
                var roles = new List<Role>
                {
                    new Role{RoleName="Admin"},
                    new Role{RoleName="Buyer"},
                    new Role{RoleName="Seller"}
                };
                roles.ForEach(role => context.Roles.Add(role));
                context.SaveChanges();
            }
            #endregion 



        }
    }
}

