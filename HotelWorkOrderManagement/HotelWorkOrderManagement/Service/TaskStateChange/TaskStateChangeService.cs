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

            }
            foreach (Models.TaskStateChange task in list)
            {
                tasks.Add(new TaskStateChangeDataIn(task));
            }
            return tasks;
        }
    }
}
