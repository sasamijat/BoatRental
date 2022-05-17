using BigGame.Models;
using BigGame.Models.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIgGameCore.DAO
{
    public static  class UsersDAO
    {
        public static User tryLogin(string username, string password) {

            using (var context = new BigGameContext())
            {

                int userID = 0;
                foreach (User user in context.Users)
                {
                    if ((user.Email == username && user.Password == password) || (int.TryParse(username, out userID) && user.UserID == userID && user.Password == password))
                    {
                        return user;
                        
                    }

                }
                return null;
            }
        }


        public static User getUserWithCompleteReservationsObject(int id) {

            using (var context = new BigGameContext()) {

                return context.Users
                                .Include(u => u.Reservations)
                                .ThenInclude(r => r.BoatAvailability)
                                .ThenInclude(ba => ba.Boat)
                                .ThenInclude(b => b.BoatImages)
                                .Where(u => u.UserID == id).FirstOrDefault();
            }
        }

        public static bool RemoveUser(int id) {
            try
            {
                using (var context = new BigGameContext())
                {

                    User user = context.Users.Where(u => u.UserID == id).FirstOrDefault();
                    context.Users.Remove(user);
                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception e)
            {

                return false;
            }
        }

        public static User getUserWithReservationsAndBoats(int id) {

            using (var context = new BigGameContext())
            {

                return context.Users
                    .Include(u => u.Reservations)
                    .Include(u => u.Boats)
                    .ThenInclude(b =>b.BoatImages)
                    .Where(u => u.UserID == id).FirstOrDefault();
            }
        }

        public static User getUserWithBoats(int id) {


            using (var context = new BigGameContext())
            {

                return context.Users
                    .Include(u => u.Boats)
                    .ThenInclude(b => b.BoatImages)
                    .Where(u => u.UserID == id).FirstOrDefault();
            }
        }
    }
}
