using HotelWorkOrderManagement.DTO.User.DataIn;
using HotelWorkOrderManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Service
{
    public interface ICRUD
    {
        public  void insertUser(UserDataIn user) { }
        public void updateUser(UserDataIn user) { }
        public  UserDataIn getUser(int id) { return null; }
        public List<UserDataIn> getAllUsers(){ return null; }
        public async Task<User> removeUserAsync(int id) { return null; }

    }
}
