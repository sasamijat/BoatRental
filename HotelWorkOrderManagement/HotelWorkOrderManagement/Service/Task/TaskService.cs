using HotelWorkOrderManagement.DTO.Task.DataIn;
using HotelWorkOrderManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelWorkOrderManagement.Models;
using HotelWorkOrderManagement.DTO.Task.DataOut;
using Microsoft.EntityFrameworkCore;

namespace HotelWorkOrderManagement.Service.Task
{
    public class TaskService: ITaskService
    {
        private readonly ApplicationDbContext context;
        public TaskService(ApplicationDbContext _db)
        {
            context = _db;
        }
        public List<TaskDataOut> myTasks(int id,bool team) {

            List<Models.Task> list=new List<Models.Task>();

            List<TaskDataOut> tasks = new List<TaskDataOut>();
            using (context)
            {
                if (team == false)
                {
                    list = context.Tasks.Where(t => t.AsigneeIndividualId == id).Include(x => x.AsigneeGroup).Include(x => x.AsigneeIndividual).Include(x => x.EquipmentToRepair).ToList();
                
                }else
                {
                    var members = context.Members.Where(m=>m.UserId==id).Include(m => m.Group).ToList();
                    var groups=members.Select(m=>m.Group).ToList();
                    foreach (var group in groups)
                    {
                        var groupTasks = context.Tasks.Where(t => t.AsigneeGroupId == group.Id);
                        foreach (Models.Task task in groupTasks)
                        {

                            list.Add(task);
                        }
                    }
                    

                }


                foreach (var task in list)
            {
                TaskDataOut taskDO=new TaskDataOut()
                {
                    CreatedByName = task.CreatedBy?.Name,
                    CreatedByLastName = task.CreatedBy?.LastName,
                    AsigneeIndividualName = task.AsigneeIndividual?.Name,
                    AsigneeIndividualLastName = task.AsigneeIndividual?.LastName,
                    AsigneeGroup = task.AsigneeGroup?.Name,
                    EquipmentToRepair = task.EquipmentToRepair?.Name,

                    DueDate = task.DueDate,
                    Id = task.Id,
                    Name = task.Name,
                    Description = task.Description,
                    CreatedById = task.CreatedById,
                    CreatedOn = task.CreatedOn,
                    Priority = task.Priority,
                    Status = task.Status,
                    Position = task.Position,
                    Domain = task.Domain,
                    AsigneeIndividualId = task.AsigneeIndividualId,
                    AsigneeGroupId = task.AsigneeGroupId,
                    EquipmentToRepairId = task.EquipmentToRepairId,
                    RepetitiveStart = task.RepetitiveStart,
                    RepetitiveSetting = task.RepetitiveSetting
                };
                    tasks.Add(taskDO);
            }
            }
            return tasks; 
        }

        public TaskDataOut getTask(int id) {
            Models.Task task;
            using (context)
            {
                task = context.Tasks.Where(t=>t.Id==id).Include(t => t.AsigneeGroup).Include(t => t.AsigneeIndividual).Include(t => t.CreatedBy).Include(t => t.EquipmentToRepair).First();
                if (task == null)
                    return null;
                TaskDataOut taskDO=new TaskDataOut()
                {
                    CreatedByName = task.CreatedBy?.Name,
                    CreatedByLastName = task.CreatedBy?.LastName,
                    AsigneeIndividualName = task.AsigneeIndividual?.Name,
                    AsigneeIndividualLastName = task.AsigneeIndividual?.LastName,
                    AsigneeGroup = task.AsigneeGroup?.Name,
                    EquipmentToRepair = task.EquipmentToRepair?.Name,

                    DueDate = task.DueDate,
                    Id = task.Id,
                    Name = task.Name,
                    Description = task.Description,
                    CreatedById = task.CreatedById,
                    CreatedOn = task.CreatedOn,
                    Priority = task.Priority,
                    Status = task.Status,
                    Position = task.Position,
                    Domain = task.Domain,
                    AsigneeIndividualId = task.AsigneeIndividualId,
                    AsigneeGroupId = task.AsigneeGroupId,
                    EquipmentToRepairId = task.EquipmentToRepairId,
                    RepetitiveStart = task.RepetitiveStart,
                    RepetitiveSetting = task.RepetitiveSetting
                };
                return taskDO;
            }
            
          
;
        }

        public List<TaskDataIn> teamTasks(int id) {
            List<TaskDataIn> tasks = new List<TaskDataIn>();
            List<Models.Task> list;
            using (context)
            {
                list = context.Tasks.Where(t=>t.AsigneeGroupId.Value==id).ToList();

            }
            foreach (var task in list)
            {
                tasks.Add(new TaskDataIn(task));
            }
            return tasks;
        }

        public void repetitiveSetting(int id,string repSetting,DateTime repStart) {
        
            using(context)
            {
                Models.Task task = context.Tasks.FirstOrDefault(t => t.Id == id);
                task.RepetitiveSetting=repSetting;
                task.RepetitiveStart=repStart;
                context.SaveChanges();
            }

        }

        public void repetitiveRemove(int id) {
            
            using (context)
            {
                Models.Task task = context.Tasks.FirstOrDefault(t => t.Id == id);
                task.RepetitiveSetting = null;
                task.RepetitiveStart = null;
                context.SaveChanges();
            }

        }

        public void addNewTask(Models.Task task) {

            using (context) {

                context.Tasks.Add(task);
                context.SaveChanges();

            }

        }

        public TaskDataOut getNewTask()
        {
            using (context)
            {
                var users = context.Users.ToList();
                var groups = context.Groups.ToList();
                var equipmentPieces = context.EquipmentPieces.ToList();

                return new TaskDataOut()
                {
                    Individuals = users,
                    Groups = groups,
                    EquipmentPieces = equipmentPieces,
                };
            }
          
        }



    }
}
