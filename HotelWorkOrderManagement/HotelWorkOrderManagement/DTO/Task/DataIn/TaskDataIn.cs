using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace HotelWorkOrderManagement.DTO.Task.DataIn
{
    public class TaskDataIn 
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CreatedById { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DueDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Position { get; set; }
        public string Domain { get; set; }
        public int? AsigneeIndividualId { get; set; }
        public int? AsigneeGroupId { get; set; }
        public int? EquipmentToRepairId { get; set; }
        public DateTime? RepetitiveStart { get; set; }
        public string? RepetitiveSetting { get; set; }

        public TaskDataIn() { }

        public TaskDataIn(Models.Task task)
        {
            DueDate=task.DueDate;
            Id = task.Id;
            Name = task.Name;
            Description = task.Description;
            CreatedById = task.CreatedById;
            CreatedOn = task.CreatedOn;
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
