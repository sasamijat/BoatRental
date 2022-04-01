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
        public Task Task { get; set; }
        public int TaskId { get; set; }
        public User Executor { get; set; }
        public int ExecutorId { get; set; }

    }
}
