

$(document).ready(function () {
    var id = document.getElementById("CreatedBy").name;
    var individualId = document.getElementById("AsigneeIndividual").name
    var groupId = document.getElementById("AsigneeGroup").name
    var url1 = 'https://localhost:7221/Users/GetUserName?id=' + individualId
    var url2 = 'https://localhost:7221/Groups/GetGroupName?id=' + groupId
    var equipment = document.getElementById("EquipmentToRepair").name


    $.ajax('https://localhost:7221/Users/GetUserName?id=' + id, {
        type: 'GET',
        success: function (response) {
            document.getElementById("CreatedBy").value = response;
        }
    }),
        $.ajax({
            url: (individualId !== "") ? url1 : url2,
            type: 'GET',
            success: function (response) {
                document.getElementById("AsigneeIndividual").value = response;
            }
        });
    if (equipment!=="") {
        id = document.getElementById("EquipmentToRepair").name
        $.ajax('https://localhost:7221/Equipment/GetEquipmentName?id=' + id, {
            type: 'GET',
            success: function (response) {
                document.getElementById("EquipmentToRepair").value = response;
            }
        })
    }

    $('#NewStatusModal').click(function () {
        $("#modal-setting-new-status").modal('show');
    });  
})

function SubmitChange(id) {
    var status = document.getElementById('Status').value;
    var description = document.getElementById('Description').value;

    $.ajax({
        type: "POST",
        url: 'https://localhost:7221/TaskStateChanges/SetNewStatus',
        data: {
            taskId: id,
            executorId: 1,
            status: status,
            description: description,
        },
        success: function () {
            alert("Great")
        }
    });

}


     