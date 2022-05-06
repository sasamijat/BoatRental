var commentImage64;
var imageName;
var i = 0;
var required="This field is required"
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

    var s = validation(task);

    if(s)
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

function validation(task) {
    i = 0;
    var domain = $("#DomainValidation");
    var name = $("#NameValidation");
    var status = $("#StatusValidation");
    var description = $("#DescriptionValidation");
    var position = $("#PositionValidation");
    var priority = $("#PriorityValidation");
    var asignee = $("#AsigneeValidation");
    
    if (task.Domain == null) {
        domain.text(required);

    } else {
        domain.text("");
        i++;
    }if (task.Name == "") {
        name.text(required);

    } else {
       name.text("");
        i++;
    } if (task.Status == null) {
        status.text(required);

    } else {
       status.text("");
        i++;
    } if (task.Description == "") {
        description.text(required);

    } else {
       description.text("");
        i++;
    } if (task.Position == "") {
        position.text(required);

    } else {
       position.text("");
        i++;
    } if (task.Priority == null) {
        priority.text(required);

    } else {
        priority.text("");
        i++;
    } if (task.AsigneeIndividualId == null && task.AsigneeGroupId==null) {
        asignee.text(required);

    } else {
       asignee.text("");
        i++;
    }

    return i ==7;
}