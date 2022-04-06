

$(document).ready(function () {
    var id = document.getElementById("CreatedBy").name;
    var group = document.getElementById("AsigneeIndividual").name == null;
    var individualId = document.getElementById("AsigneeIndividual").name
    var groupId = document.getElementById("AsigneeGroup").name
    var url1 = 'https://localhost:7221/Users/GetUserName?id=' + individualId
    var url2 = 'https://localhost:7221/Groups/GetGroupName?id=' + groupId
    var equipment = document.getElementById("EquipmentToRepair").name !=null



    $.ajax('https://localhost:7221/Users/GetUserName?id=' + id, {
        type: 'GET',
        success: function (response) {
            document.getElementById("CreatedBy").value = response;
        }
    }),
        $.ajax({
            url: (group == false) ? url1 : url2,
            type: 'GET',
            success: function (response) {
                document.getElementById("AsigneeIndividual").value = response;
            }
        });
    if (equipment == true) {
        id = document.getElementById("EquipmentToRepair").name
        $.ajax('https://localhost:7221/Equipment/GetEquipmentName?id=' + id, {
            type: 'GET',
            success: function (response) {
                document.getElementById("EquipmentToRepair").value = response;
            }
        })
    }
       
})