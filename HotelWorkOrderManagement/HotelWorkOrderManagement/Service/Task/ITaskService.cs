using HotelWorkOrderManagement.DTO.Task.DataIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Service.Task
{
    public interface ITaskService
    {
        public List<TaskDataIn> myTasks(int id) { return null; }
        public TaskDataIn getTask(int id) { return null; }
        public List<TaskDataIn> teamTasks(int id){ return null; }
    }
}
