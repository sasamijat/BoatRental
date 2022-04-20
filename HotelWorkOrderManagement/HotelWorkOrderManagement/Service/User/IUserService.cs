using HotelWorkOrderManagement.DTO.User.DataIn;
using HotelWorkOrderManagement.DTO.User.DataOut;
using HotelWorkOrderManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Service
{
    public interface IUserService
    {
        public  void insertUser(User user) { }
        public void updateUser(User user) { }
        public  UserDataIn getUser(int id) { return null; }
        public List<UserDataIn> getAllUsers(){ return null; }
        public async Task<User> removeUserAsync(int id) { return null; }
        public async Task<User>AuthenticateUser(string username, string password) { return null; }

    }
}
