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
    public static class ReservationDAO
    {

        public static bool tryReserve(User user,DateTime startDate, DateTime endDate,BBA bba) {

            using (var context = new BigGameContext()) {

                Reservation newReservation = new Reservation
                {
                    UserID = user.UserID,
                    BoatAvailabilityID = bba.BoatAvailability.BoatAvailabilityID,
                    startDateTime = startDate,
                    endDateTime = endDate
                };

                context.Reservations.Add(newReservation);
                context.Users.Where(u => u.UserID == user.UserID).FirstOrDefault().Reservations.Add(newReservation);
                
                context.SaveChanges();
                return true;
            }

            return false;
        }

        public static Reservation getReservationById(int id) {

            using (var context = new BigGameContext()) {


                return context.Reservations
                                .Include( r => r.User)
                                .Include( r => r.BoatAvailability).ThenInclude(ba => ba.Boat)
                                .Where( r => r.ReservationID == id).FirstOrDefault();
            }
        
        }

        public static void cancelReservation(int id) {
            using (var context = new BigGameContext())
            {


                context.Reservations.Where(r => r.ReservationID == id).FirstOrDefault().status = ReservationStatus.CANCELED;
                context.SaveChanges();
            }
        }
    }
}
