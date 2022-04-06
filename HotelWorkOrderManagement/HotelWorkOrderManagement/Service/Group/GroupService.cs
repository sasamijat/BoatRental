using HotelWorkOrderManagement.DTO.Group.DataIn;
using HotelWorkOrderManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Service.Group
{
    public class GroupService : IGroupService
    {
        private readonly ApplicationDbContext context;
        public GroupService(ApplicationDbContext db)
        {
            context = db;
        }

        public GroupDataIn getGroup(int id) {
            GroupDataIn group;
            using (context)
            {
                group= new GroupDataIn(context.Groups.FirstOrDefault(g=>g.Id==id));
            }
            return group;
        }

    }
}
