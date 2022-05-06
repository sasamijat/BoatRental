using HotelWorkOrderManagement.DTO.TaskStateChange.DataIn;
using HotelWorkOrderManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Service.TaskStateChange
{
    public class TaskStateChangeService:ITaskStateChangeService
    {
        private readonly ApplicationDbContext context;
        public TaskStateChangeService(ApplicationDbContext db)
        {
            context = db;
        }

        public List<TaskStateChangeDataIn> getTaskStateChange(int taskId)
        {
            List<TaskStateChangeDataIn> tasks = new List<TaskStateChangeDataIn>();
            List<Models.TaskStateChange> list;
            using (context)
            {
                list = context.TaskStateChanges.Where(t=>t.TaskId==taskId).ToList();

            
            foreach (Models.TaskStateChange task in list)
            {
                string executor = context.Users.Where(u => u.Id == task.ExecutorId).First().Name + " " + context.Users.Where(u => u.Id == task.ExecutorId).First().LastName;
                tasks.Add(new TaskStateChangeDataIn(task) { Executor = executor });
            }
            }
            return tasks;
        }

        public void updateTaskStatus(TaskStateChangeDataIn taskStateChange,int id,string status) {
            using(context)
            {
                Models.Task task = context.Tasks.FirstOrDefault(t => t.Id == id);
                task.Status = status;
                context.TaskStateChanges.Add(new Models.TaskStateChange(taskStateChange));
                context.SaveChanges();
            }
        }
        public void dropTask(TaskStateChangeDataIn taskStateChange,int id) {

            using (context) {

                Models.Task task = context.Tasks.FirstOrDefault(t => t.Id == id);
                task.Status = "Dropped";
                task.AsigneeGroupId = null;
                task.AsigneeIndividualId = null;
                context.TaskStateChanges.Add(new Models.TaskStateChange(taskStateChange));
                context.SaveChanges();


            }

        }

    }
}
