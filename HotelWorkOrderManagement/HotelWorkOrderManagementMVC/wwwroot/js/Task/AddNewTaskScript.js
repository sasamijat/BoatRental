var commentImage64;
var imageName;
function AddNewTask(task) {
    var task = {}
    task.Name = $("#Name").val();
    task.Description = $("#Description").val();
    task.CreatedById = document.getElementById("CreatedById").title;
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
    task.ImageName = imageName;
    task.Attachment = commentImage64;


    $.ajax({
        type: "POST",
        url: 'https://localhost:7221/Tasks/addNewTask',
        data: task,
        success:function() {
            window.location.href = 'https://localhost:7221/Tasks/GroupOrIndividual';
                alert("Task is successfully added")
            }        
    });

}

function getBase64() {
    var file = document.getElementById('CommentFile').files[0]
    imageName = file.name
    var reader = new FileReader();
    reader.readAsDataURL(file);
    reader.onload = function () {
        commentImage64 = reader.result;
    };
    reader.onerror = function (error) {
        console.log('Error: ', error);
    };
}
