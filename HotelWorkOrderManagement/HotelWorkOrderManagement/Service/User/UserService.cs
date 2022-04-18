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

        public void insertUser(UserDataIn user)
        {
            using(context)
            {
                context.Users.Add(new User(user));
                context.SaveChanges();

            }
        }

        public void updateUser(UserDataIn user) {
            using (context)
            {
                context.Users.Update(new User(user));
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

        



    }
}
