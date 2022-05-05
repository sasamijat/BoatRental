using HotelWorkOrderManagement.DTO.Comment;
using HotelWorkOrderManagement.DTO.Task.DataIn;
using HotelWorkOrderManagement.DTO.Task.DataOut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Service.Task
{
    public interface ITaskService
    {
        public List<TaskDataOut> myTasks(int id,bool team) { return null; }
        public TaskDataOut getTask(int id) { return null; }
        public List<TaskDataIn> teamTasks(int id){ return null; }
        public void repetitiveSetting(int id, string repSetting, DateTime repStart) { }
        public void repetitiveRemove(int id) { }
        public void addNewTask(TaskDataOut task,string? uniqueFileName) { }
        public TaskDataOut getNewTask(int userId) { return null; }
        public void SubmitComment(CommentDataIn model,string? uniqueFileName) { }
        public void RemoveComment(int id) { }
        public List<TaskDataOut> GetAllTasks(bool? team) { return null; }         
        public void TakeSelectedTask(int id, int userId) { }

    }
}
