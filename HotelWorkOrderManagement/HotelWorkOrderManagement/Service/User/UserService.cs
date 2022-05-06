using HotelWorkOrderManagement.DTO.User.DataIn;
using HotelWorkOrderManagement.DTO.User.DataOut;
using HotelWorkOrderManagement.Models;
using HotelWorkOrderManagement.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Service
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext context;
        public UserService(ApplicationDbContext _db)
        {
            context = _db;
        }

        public void insertUser(User user)
        {
            using(context)
            {
                try
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    
                }

                

            }
        }

        public void updateUser(User user) {
            using (context)
            {
                context.Users.Update(user);
                context.SaveChanges();

            }
        }


        public UserDataIn getUser(int id)
        {
            UserDataIn user;
            using (context )
            {
                user = new UserDataIn(context.Users.FirstOrDefault(u => u.Id == id));

            }
            return user;
        }

        public List<UserDataIn> getAllUsers()
        {
            List<UserDataIn> users = new List<UserDataIn>();
            List<User> list;
            using (context)
            {
                list= context.Users.ToList();

            }
            foreach (User user in list)
            {
                users.Add(new UserDataIn(user));
            }
            return users;
        }

        public async Task<User> removeUserAsync(int id)
        {
            User user;
            using (context)
            {
               user=await context.Users.FirstOrDefaultAsync(u => u.Id == id);
                if (user == null)
                    return null;
                else
                {
                    context.Users.Remove(user);
                    await context.SaveChangesAsync();
                    return user;
                }
            }
        }

        public async Task<User> AuthenticateUser(string username, string password) {

            User user;
            using (context)
            {
                user=await context.Users.FirstOrDefaultAsync(u=>u.Username == username & u.Password==password);
            }
            return user;
        }

        public bool IsUsernameAvailable(string Username)
        {
            User user = null;
            using (context)
            {
                user=context.Users.FirstOrDefault(u=>u.Username == Username);
            }
            if(user==null)
                return true;
            else return false;
        }





    }
}
