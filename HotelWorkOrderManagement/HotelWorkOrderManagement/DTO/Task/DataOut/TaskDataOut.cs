using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.DTO.Task.DataOut
{
    public class TaskDataOut
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CreatedById { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? FinishedOn { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Position { get; set; }
        public string Domain { get; set; }
        public int? AsigneeIndividualId { get; set; }
        public int? AsigneeGroupId { get; set; }
        public int? EquipmentToRepairId { get; set; }
        public DateTime? RepetitiveStart { get; set; }
        public string? RepetitiveSetting { get; set; }

        public TaskDataOut() { }
        public TaskDataOut(Models.Task task)
        {
            
            Name = task.Name;
            Description = task.Description;
            CreatedById = task.CreatedById;
            CreatedOn = task.CreatedOn;
            FinishedOn = task.FinishedOn;
            Priority = task.Priority;
            Status = task.Status;
            Position = task.Position;
            Domain = task.Domain;
            AsigneeIndividualId = task.AsigneeIndividualId;
            AsigneeGroupId = task.AsigneeGroupId;
            EquipmentToRepairId = task.EquipmentToRepairId;
            RepetitiveStart = task.RepetitiveStart;
            RepetitiveSetting = task.RepetitiveSetting;
        }
    }
}
