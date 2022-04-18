function AddNewTask(task) {
    var task = {}
    task.Name = $("#Name").val();
    task.Description = $("#Description").val();
    task.CreatedById = $("#CreatedById").val();
    task.DueDate = $("#DueDate").val();
    task.Priority = $("#Priority").val();
    task.Status = $("#Status").val();
    task.Position = $("#Position").val();
    task.Domain = $("#Domain").val();
    task.AsigneeIndividualId = $("#AsigneeIndividualId").val();
    task.AsigneeGroupId = $("#AsigneeGroupId").val();
    task.EquipmentToRepairId = $("#EquipmentToRepairId").val();
    task.RepetitiveStart = $("#RepetitiveStart").val();
    task.RepetitiveSetting = $("#RepetitiveSetting").val();


    $.ajax({
        type: "POST",
        url: 'https://localhost:7221/Tasks/addNewTask',
        data: task,
        success:function() {
            window.location.href = 'https://localhost:7221/Tasks/addNewTask';
                alert("Task is successfully added")
            }        
    });

}

