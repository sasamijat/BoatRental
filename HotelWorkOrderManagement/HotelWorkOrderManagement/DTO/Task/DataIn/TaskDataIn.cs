using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWorkOrderManagement.DTO.Task.DataIn
{
    public class TaskDataIn 
    {
        public int? Id { get; set; }
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

        
    }
}
