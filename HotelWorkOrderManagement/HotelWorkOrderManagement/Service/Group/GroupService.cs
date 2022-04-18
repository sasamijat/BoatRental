using HotelWorkOrderManagement.DTO.Group.DataIn;
using HotelWorkOrderManagement.DTO.Group.DataOut;
using HotelWorkOrderManagement.DTO.User.DataOut;
using HotelWorkOrderManagement.Models;
using Microsoft.EntityFrameworkCore;
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
        public List<GroupDataOut> getMyGroups(int id) {
            string Leader;
            List<GroupDataOut> groups = new List<GroupDataOut>();
            List<Models.Group> list=new List<Models.Group>();
            using (context)
            {
                var members=context.Members.Include(m=>m.Group).Include(x => x.User).ToList(); 
                
                list=members.Where(m=>m.UserId==id).Select(m=>m.Group).ToList();
           
            foreach (Models.Group group in list)
            {
                List<EmployeeDataOut> groupMembers=new List<EmployeeDataOut>();

                var groupMem=members.Where(m=>m.GroupId==group.Id).Select(m=>m.User).ToList();
                foreach(User user in groupMem)
                    {
                        groupMembers.Add(new EmployeeDataOut(user.Id, user.Name, user.LastName, user.Username)); 
                    }

                Leader = members.Where(m => m.GroupId == group.Id && m.Leader==true).Select(m => m.User.Name).First();
                groups.Add(new GroupDataOut(group,Leader,groupMembers));
            }
            }
            return groups;
        }

        public List<EmployeeDataOut> getAllEmployeesExceptGroupMembers(int groupId)
        {

            List<EmployeeDataOut> employees = new List<EmployeeDataOut>();
            List<User> users = new List<User>();

            using (context)
            {                
                var allUsers=context.Users.ToList();
                var members=context.Members.Where(m=>m.GroupId==groupId).Include(m=>m.User);
                users=allUsers.Where(x => !members.Any(m => x == m.User)).ToList();
            }
            foreach (User user in users)
            {
                employees.Add(new EmployeeDataOut(user.Id, user.Name, user.LastName, user.Username));
            }
            return employees;

        }

        public void addMember(int id, int groupId) {
        
            using(context)
            {
                context.Members.Add(new Models.Member(id,groupId));
                context.SaveChanges();
            }

        }

        public void removeMember(int id, int groupId)
        {
            using (context)
            {
                context.Members.Remove(new Models.Member(id,groupId));
                context.SaveChanges();
            }
        }




    }
}
