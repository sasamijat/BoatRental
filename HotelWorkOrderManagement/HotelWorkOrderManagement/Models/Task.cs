using HotelWorkOrderManagement.DTO.Task.DataIn;
using HotelWorkOrderManagement.DTO.Task.DataOut;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.Models
{
    public class Task : BaseEntity
    {
       
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("CreatedById")]
        public int? CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DueDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Position { get; set; }
        public string Domain { get; set; }
        public int? AsigneeIndividualId { get; set; }
        public User AsigneeIndividual { get; set; }
        public int? AsigneeGroupId { get; set; }
        public Group AsigneeGroup { get; set; }
        public int? EquipmentToRepairId { get; set; }
        public EquipmentPiece EquipmentToRepair { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<TaskStateChange> TaskStateChanges { get; set; }



        //Za repetitive task
        public DateTime? RepetitiveStart { get; set; }
        public string? RepetitiveSetting { get; set; }

        public Task() { }

        public Task(TaskDataIn task)
        {
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
            DueDate = task.DueDate;
        }

        public Task(TaskDataOut task)
        {
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
            DueDate = task.DueDate;
        }


    }
}
