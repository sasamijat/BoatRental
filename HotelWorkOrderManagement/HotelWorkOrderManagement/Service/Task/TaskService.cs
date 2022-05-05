using HotelWorkOrderManagement.DTO.Task.DataIn;
using HotelWorkOrderManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelWorkOrderManagement.Models;
using HotelWorkOrderManagement.DTO.Task.DataOut;
using Microsoft.EntityFrameworkCore;
using HotelWorkOrderManagement.DTO.Comment;

namespace HotelWorkOrderManagement.Service.Task
{
    public class TaskService: ITaskService
    {
        private readonly ApplicationDbContext context;
        public TaskService(ApplicationDbContext _db)
        {
            context = _db;
        }

        public List<TaskDataOut> GetAllTasks(bool team)
        {
            List<TaskDataOut> tasksDO = new List<TaskDataOut>();
            List<Models.Task> tasks = new List<Models.Task>();
            using (context)
            {
                if(team==null || team==false)
                tasks = context.Tasks.Where(t => t.AsigneeIndividualId != null).Include(x => x.AsigneeGroup).Include(x => x.AsigneeIndividual).Include(x => x.EquipmentToRepair).ToList();
                else
                tasks = context.Tasks.Where(t => t.AsigneeGroupId != null).Include(x => x.AsigneeGroup).Include(x => x.AsigneeIndividual).Include(x => x.EquipmentToRepair).ToList();
            }

            foreach (var task in tasks)
            {
                tasksDO.Add(new TaskDataOut(task));
            }
            return tasksDO;

        }
        public List<TaskDataOut> myTasks(int id,bool team) {

            List<Models.Task> list=new List<Models.Task>();

            List<TaskDataOut> tasks = new List<TaskDataOut>();
            using (context)
            {
                if (team == false)
                {
                    list = context.Tasks.Where(t => t.AsigneeIndividualId == id).Include(x => x.AsigneeGroup).Include(x => x.AsigneeIndividual).Include(x => x.EquipmentToRepair).ToList();

                    foreach (var task in list)
                    {
                        tasks.Add(new TaskDataOut(task));
                    }
                }
                else
                {
                    var members = context.Members.Where(m=>m.UserId==id).Include(m => m.Group).ToList();
                    var groups=members.Select(m=>m.Group).ToList();
                    foreach (var group in groups)
                    {
                        var groupTasks = context.Tasks.Where(t => t.AsigneeGroupId == group.Id);
                        foreach (Models.Task task in groupTasks)
                        {
                            tasks.Add(new TaskDataOut(task,group.SelfTaskAssign));
                        }
                    }
                    

                }


            
            }
            return tasks; 
        }

        public TaskDataOut getTask(int id) {
            Models.Task task;
            using (context)
            {
                task = context.Tasks.Where(t=>t.Id==id).Include(t => t.AsigneeGroup).Include(t => t.AsigneeIndividual).Include(t => t.CreatedBy).Include(t => t.EquipmentToRepair).First();
                List<Comment> comments=context.Comments.Where(c=>c.TaskID==id).Include(x=>x.CreatedBy).ToList();
                if (task == null)
                    return null;
                TaskDataOut taskDO=new TaskDataOut(task)
                {
                    Comments = comments
                };
                return taskDO;
            }
            
          
;
        }

        public List<TaskDataIn> teamTasks(int id) {
            List<TaskDataIn> tasks = new List<TaskDataIn>();
            List<Models.Task> list;
            using (context)
            {
                list = context.Tasks.Where(t=>t.AsigneeGroupId.Value==id).ToList();

            }
            foreach (var task in list)
            {
                tasks.Add(new TaskDataIn(task));
            }
            return tasks;
        }

        public void repetitiveSetting(int id,string repSetting,DateTime repStart) {
        
            using(context)
            {
                Models.Task task = context.Tasks.FirstOrDefault(t => t.Id == id);
                task.RepetitiveSetting=repSetting;
                task.RepetitiveStart=repStart;
                context.SaveChanges();
            }

        }

        public void repetitiveRemove(int id) {
            
            using (context)
            {
                Models.Task task = context.Tasks.FirstOrDefault(t => t.Id == id);
                task.RepetitiveSetting = null;
                task.RepetitiveStart = null;
                context.SaveChanges();
            }

        }

        public void addNewTask(TaskDataOut taskDO,string? uniqueFileName) {
            Models.Task task = new Models.Task(taskDO);
            task.Attachment = uniqueFileName;
            using (context) {
                
                context.Tasks.Add(task);
                context.SaveChanges();

            }

        }

        public TaskDataOut getNewTask(int userId)
        {
            using (context)
            {
                var currentUser = context.Users.Where(u => u.Id == userId).First().Name +" "+ context.Users.Where(u => u.Id == userId).First().LastName;
                var users = context.Users.ToList();
                var groups = context.Groups.ToList();
                var equipmentPieces = context.EquipmentPieces.ToList();

                return new TaskDataOut()
                {
                    CurrentUser = currentUser,
                    Individuals = users,
                    Groups = groups,
                    EquipmentPieces = equipmentPieces,
                };
            }
          
        }

        public void SubmitComment(CommentDataIn model,string? uniqueFileName) {

            Comment comment = new Comment(model);
            comment.CommentImage = uniqueFileName;
            using (context) {
                context.Comments.Add(comment);

                context.SaveChanges();

            }
        
        }

        public void RemoveComment(int id) {

            using (context) {
            
                Comment comment = context.Comments.FirstOrDefault(c => c.Id == id);
                context.Comments.Remove(comment);
                context.SaveChanges();
            
            }


        }

        public void TakeSelectedTask(int id,int userId) {
            Models.Task task;
            using (context) {

                task = context.Tasks.FirstOrDefault(t => t.Id == id);
                task.AsigneeGroupId = null;
                task.AsigneeIndividualId = userId;
                context.SaveChanges();
            }

        
        }





    }
}
