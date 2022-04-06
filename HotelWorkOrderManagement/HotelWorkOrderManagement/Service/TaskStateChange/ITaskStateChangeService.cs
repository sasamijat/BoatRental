using HotelWorkOrderManagement.DTO.TaskStateChange.DataIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Service.TaskStateChange
{
    public interface ITaskStateChangeService
    {
        public List<TaskStateChangeDataIn> getTaskStateChange(int taskId) { return null; }
    }
}
