using BigGame.Models;
using BigGame.Models.Context;
using BIgGameCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIgGameCore.DAO
{
    public static class BoatsDAO
    {

        public static List<Boat> getAllBoats() {

            using (var context = new BigGameContext()) {

                return context.Boats.Include(b=>b.BoatImages).ToList();
            
            }
        
        }

        public static List<Boat> getBoatsFilter(int passangersCapacity, int year,int length)
        {

            using (var context = new BigGameContext())
            {

                return context.Boats.Include(b=>b.BoatImages).Where(b => b.PassangerCapacity >= passangersCapacity && b.Year >= year && b.Length >= length).ToList();

            }

        }
        public static Boat getBoat(int id) {

            using (var context = new BigGameContext())
            {
                return context.Boats.Include(b => b.BoatImages).Where(b => b.BoatID == id).FirstOrDefault();
            }
        }
        public static List<BBA> availabilityBoats(DateTime startDate, DateTime endDate) {

            using (var context = new BigGameContext()) {

                return context.Boats.Include(b=>b.BoatImages).Join(context.BoatAvailabilities,
                                            b => b.BoatID,
                                            ba => ba.BoatID,
                                            (b, ba) => new { b, ba })
                                    .Where(o => startDate >= o.ba.StartDate && endDate <=  o.ba.EndDate  )
                                    .Select( o => new BBA { Boat = o.b , BoatAvailability = o.ba}).ToList();

            }


            return null;
        }

        public static BBA GetBoatAvailability(int id) {

            using (var context = new BigGameContext()) {

                return context.BoatAvailabilities.Join(context.Boats.Include(b=> b.BoatImages),

                    ba => ba.BoatID,
                    b => b.BoatID,
                    (ba, b) => new { ba, b })
                    .Where(o => o.ba.BoatAvailabilityID == id)
                    .Select(o => new BBA { Boat = o.b, BoatAvailability = o.ba }).FirstOrDefault();
            
            }



            return null;
        }


        public static List<Boat> getBoatsOfUser(int userID) {

            using (var context = new BigGameContext()) {

                return context.Boats
                                .Include(b => b.Owner)
                                .Include(b => b.BoatImages)
                                .Where(b => b.OwnerID == userID).ToList();
            
            }
        }

        public static List<BoatAvailability> GetBoatAvailabilities(int boatID) {

            using (var context = new BigGameContext()) {

                return context.BoatAvailabilities.Where(ba => ba.BoatID == boatID).ToList();
            }
        }

        public static List<BBA> getActiveBBAOfUser(int userID) {

            List<BBA> rez = new List<BBA>();
            foreach (Boat boat in getBoatsOfUser(userID)) {

                foreach (BoatAvailability ba in GetBoatAvailabilities(boat.BoatID)) {

                    if (ba.StartDate < DateTime.Now &&  DateTime.Now < ba.EndDate.AddHours(-1) ) {
                        rez.Add(new BBA { Boat = boat, BoatAvailability = ba });
                    }
                }
            }

            return rez;
        
        }

        public static BBA isBoatAvailable(int id, DateTime startDate, DateTime endDate) {


            using (var context = new BigGameContext())
            {

                return context.Boats.Include(b=> b.BoatImages).Join(context.BoatAvailabilities,
                                            b => b.BoatID,
                                            ba => ba.BoatID,
                                            (b, ba) => new { b, ba })
                                    .Where(o => o.b.BoatID == id && startDate >= o.ba.StartDate && endDate <= o.ba.EndDate )
                                    .Select(o => new BBA { Boat = o.b, BoatAvailability = o.ba }).FirstOrDefault();

            }


        }


        public static int AddNewBoat(Boat newBoat,User owner) {

            try
            {
                using (var context = new BigGameContext())
                {

                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Boats ON;");
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Users ON;");

                    context.Boats.Add(newBoat);
                    context.Users.Include(u => u.Boats).Where(u => u.UserID == owner.UserID).FirstOrDefault().Boats.Add(newBoat);

                    context.SaveChanges();
                    return context.Boats.Where(b => b.Name == newBoat.Name).FirstOrDefault().BoatID;
                }

            }
            catch (Exception e)
            {
                return -1;
            }

        }

        public static bool deleteBoat(int id,int ownerID,int currentUserID) {

            if (ownerID != currentUserID)
                return false;

            try
            {
                using (var context = new BigGameContext())
                {

                    Boat boat = context.Boats.Where(b => b.BoatID == id && b.OwnerID == ownerID ).FirstOrDefault();
                    context.Boats.Remove(boat);
                    context.SaveChanges();
                    return true;
                }
            }
            catch(Exception e) {
                return false;
            }
        }

        public static int EditBoat(Boat newBoat) {


            using (var context = new BigGameContext()) {


                Boat boat = context.Boats.Where(b => b.BoatID == newBoat.BoatID).FirstOrDefault();

                if (boat != null) {

                    boat.BedCount = newBoat.BedCount;
                    boat.Desctription = newBoat.Desctription;
                    boat.Name = newBoat.Name;
                    boat.Make = newBoat.Make;
                    boat.Length = newBoat.Length;
                    boat.FuelCapacity = newBoat.FuelCapacity;
                    boat.Year = newBoat.Year;
                    boat.Model = newBoat.Model;
                    boat.PassangerCapacity = newBoat.PassangerCapacity;

                    context.SaveChanges();
                    return boat.BoatID;
                }
            
            }
            return -1;
        }


        public static void DeleteImageForBoat(int id, string image) {

            using (var context = new BigGameContext()) {

                BoatImage boatImage = context.BoatImages.Where(bi => bi.Image == image).FirstOrDefault();
                if (boatImage != null)
                {
                    context.BoatImages.Remove(boatImage);
                    context.SaveChanges();
                }
            }
        
        }
        
    }
}
