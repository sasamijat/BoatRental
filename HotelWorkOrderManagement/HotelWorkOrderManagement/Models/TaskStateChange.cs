using HotelWorkOrderManagement.DTO.TaskStateChange.DataIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Models
{
    public class TaskStateChange : BaseEntity
    {
        public string Status { get; set; }
        public string Description { get; set; }
        public Task Task { get; set; }
        public int TaskId { get; set; }
        public User Executor { get; set; }
        public int ExecutorId { get; set; }
        public DateTime DateOfChange { get; set; }

        public TaskStateChange() { }

        public TaskStateChange(TaskStateChangeDataIn tsc)
        {
            Id = tsc.Id;
            DateOfChange = tsc.DateOfChange;
            Status = tsc.Status;
            Description = tsc.Description;
            ExecutorId = tsc.ExecutorId;
            TaskId = tsc.TaskId;
        }

    }
}
