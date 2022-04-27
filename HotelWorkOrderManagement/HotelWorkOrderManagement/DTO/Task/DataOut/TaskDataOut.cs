using HotelWorkOrderManagement.DTO.User.DataOut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.DTO.Task.DataOut
{
    public class TaskDataOut
    {
        public int Id { get; set; }
        public int? CreatedById { get; set; }
        public int? AsigneeIndividualId { get; set; }
        public int? AsigneeGroupId { get; set; }
        public int? EquipmentToRepairId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? CreatedByName { get; set; }
        public string? CreatedByLastName { get; set; }
        public bool? TaskSelfAsign { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DueDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Position { get; set; }
        public string Domain { get; set; }
        public string? AsigneeIndividualName { get; set; }
        public string? AsigneeIndividualLastName { get; set; }
        public string? AsigneeGroup { get; set; }
        public string? EquipmentToRepair { get; set; }
        public DateTime? RepetitiveStart { get; set; }
        public string? RepetitiveSetting { get; set; }
        public List<Models.Group>? Groups {get; set;}
        public List<Models.User>? Individuals { get; set;}
        public List<Models.EquipmentPiece>? EquipmentPieces { get; set;}
        public List<Models.Comment>? Comments { get; set; }

        public TaskDataOut()
        {

        }
        public TaskDataOut(Models.Task task)
        {
            CreatedByName = task.CreatedBy?.Name;
                    CreatedByLastName = task.CreatedBy?.LastName;
                    AsigneeIndividualName = task.AsigneeIndividual?.Name;
                    AsigneeIndividualLastName = task.AsigneeIndividual?.LastName;
                    AsigneeGroup = task.AsigneeGroup?.Name;
                    EquipmentToRepair = task.EquipmentToRepair?.Name;

                    DueDate = task.DueDate;
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

        public TaskDataOut(Models.Task task,bool taskSelfAsign): this(task)
        {
            TaskSelfAsign = taskSelfAsign;
        }



    }
}
