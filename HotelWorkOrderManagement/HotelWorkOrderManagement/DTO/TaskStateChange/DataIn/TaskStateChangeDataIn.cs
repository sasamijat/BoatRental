using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.DTO.TaskStateChange.DataIn
{
    public class TaskStateChangeDataIn
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public int TaskId { get; set; }
        public int ExecutorId { get; set; }
        public DateTime DateOfChange { get; set; }
        public string? Executor { get; set; }

        public TaskStateChangeDataIn() { }

        public TaskStateChangeDataIn(Models.TaskStateChange tsc) { 
            Id = tsc.Id;
            DateOfChange = tsc.DateOfChange;
            Status = tsc.Status;
            Description = tsc.Description;
            ExecutorId = tsc.ExecutorId;
            TaskId = tsc.TaskId;
        }
    }


}
