namespace BoatsMontenegro.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;
    using BoatsMontenegro.BaseBase;
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
            if (!context.Reservations.Any())
            {
                var reservations = new List<Reservation>
                    {
                        new Reservation { DateFrom = new DateTime(2022, 08, 18), DateTo = new DateTime(2022, 09, 23)},
                        new Reservation { DateFrom = new DateTime(2022, 04, 28), DateTo = new DateTime(2022, 07, 12)},
                        new Reservation { DateFrom = new DateTime(2022, 03, 14), DateTo = new DateTime(2022, 08, 08)},
                        new Reservation { DateFrom = new DateTime(2022, 02, 10), DateTo = new DateTime(2022, 06, 17)},
                        new Reservation { DateFrom = new DateTime(2022, 05, 21), DateTo = new DateTime(2022, 04, 06),}
                    };
                reservations.ForEach(reservation => context.Reservations.Add(reservation));
                context.SaveChanges();
            }
            #endregion

            #region -------------------USER------------------- 
            if (!context.Users.Any())
            {
                var users = new List<User>
                {
                    new User {FirstName = "Blagoje", LastName = "Jovovic", Email = "2metkazapavelica@gmail.com", Password = "1953", PersonalIdNumber = "655223984", PhoneNumber = "+38160787686767", Username="blagojej" },
                    new User {FirstName = "Kristina", LastName = "Mirkovic", Email = "kristinakris@yahoo.com", Password = "4745", PersonalIdNumber = "412887564", PhoneNumber = "+3816079879+",Username="kristinam" },
                    new User {FirstName = "Dijana", LastName = "Lazic", Email = "dijanalazicdiks@gmail.com", Password = "8896", PersonalIdNumber = "963365477", PhoneNumber = "+38160645646",Username="dijanal" },
                    new User {FirstName = "Gavrilo", LastName = "Principovic", Email = "mladabosna@outlook.com", Password = "1914", PersonalIdNumber = "852336889", PhoneNumber = "+38160796456",Username="gavrilop" },
                    new User {FirstName = "Ratko", LastName = "Mladicevic", Email = "koridor92@gmail.com", Password = "1992", PersonalIdNumber = "2144533564", PhoneNumber = "+38160789789",Username="ratkom" }
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
                        new Boat {Capacity = 11, Engine = "5.8 Disel", FuelConsumption = "25l 100km", Size = "21m", Price=87, Category="Yacht",Name="Plavi jadran"},
                        new Boat { Capacity = 6, Engine = "4.0 Petrol", FuelConsumption = "15l per 100km", Size = "11m", Price=103, Category="Fishing",Name="Mediteran" },
                        new Boat { Capacity = 5, Engine = "3.8 Petrol", FuelConsumption = "12l per 100km", Size = "9m", Price=76, Category="Casual",Name="Atlantik"},
                        new Boat { Capacity = 3, Engine = "5.5 Diesel", FuelConsumption = "9l per 100km", Size = "6m",Price=56, Category="Fishing" ,Name="Pacifik"},
                        new Boat { Capacity = 10, Engine = "5.3 Petrol", FuelConsumption = "17l per 100km", Size = "13m", Price=59, Category="Yacht",Name="Baltik" },
                        new Boat { Capacity = 15, Engine = "4.3 Petrol", FuelConsumption = "15l per 100km", Size = "14m", Price=107, Category="Casual" ,Name="Munja"},
                        new Boat { Capacity = 16, Engine = "3.8 Petrol", FuelConsumption = "16l per 100km", Size = "17m", Price=66, Category="Yacht",Name="Ladja" },
                        new Boat {Capacity = 18, Engine = "5.8 Disel", FuelConsumption = "14l 100km", Size = "26m", Price=98, Category="Casual",Name="Grom"},
                        new Boat {Capacity = 15, Engine = "5.4 Disel", FuelConsumption = "24l 100km", Size = "25m", Price=47, Category="Yacht",Name="Morski div"},
                        new Boat {Capacity = 10, Engine = "5.7 Disel", FuelConsumption = "18l 100km", Size = "21m", Price=86, Category="Casual",Name="Egej"}
                };
                boats.ForEach(boat => context.Boats.Add(boat));
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
