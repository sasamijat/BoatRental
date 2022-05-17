using BigGame.Models;
using BigGame.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIgGameCore.DAO
{
    public static class BoatAvailabilityDAO
    {

        public static bool addNewBoatAvailability(BoatAvailability boatAvailability) {

            try
            {
                using (var context = new BigGameContext())
                {
                    
                    context.BoatAvailabilities.Add(boatAvailability);
                    context.Boats.Where(b => b.BoatID == boatAvailability.BoatID).FirstOrDefault().boatAvailabilities.Add(boatAvailability);
                    context.SaveChanges();
                }
                return true;
            }
            catch {
                return false;
            }
        }


        public static bool deleteBoatAvailability(int id) {

            try
            {
                using (var context = new BigGameContext())
                {
                    BoatAvailability ba = context.BoatAvailabilities.Where(ba => ba.BoatAvailabilityID == id).FirstOrDefault();
                    context.BoatAvailabilities.Remove(ba);
                    context.Boats.Where(b => b.BoatID == ba.BoatID).FirstOrDefault().boatAvailabilities.Remove(ba);
                    context.SaveChanges();
                }

                return true;
            }
            catch {
                return false;
            }
        }
    }
}
