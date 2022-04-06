using HotelWorkOrderManagement.DTO.Task.DataIn;
using HotelWorkOrderManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelWorkOrderManagement.Models;

namespace HotelWorkOrderManagement.Service.Task
{
    public class TaskService: ITaskService
    {
        private readonly ApplicationDbContext context;
        public TaskService(ApplicationDbContext _db)
        {
            context = _db;
        }
        public List<TaskDataIn> myTasks(int id) {

            List<TaskDataIn> tasks = new List<TaskDataIn>();
            List<Models.Task> list;
            using (context)
            {
                list = context.Tasks.Where(t => t.AsigneeIndividualId.Value == id).ToList();

            }
            foreach (var task in list)
            {
                tasks.Add(new TaskDataIn(task));
            }
            return tasks; 
        }

        public TaskDataIn getTask(int id) {
            TaskDataIn task;
            using (context)
            {
                task = new TaskDataIn(context.Tasks.FirstOrDefault(u => u.Id == id));

            }
            return task;
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

    }
}
