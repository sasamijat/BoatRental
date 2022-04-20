function hide(id) {
    var div = document.getElementById(id);
    if (div.hasAttribute("hidden")) {
        div.removeAttribute("hidden");
    } else {
        div.setAttribute("hidden", "hidden");
    }
}

function ShowModal(id) {
    $(id).modal('show');
}

function DismissModal(id) {
    $(id).modal('hide');
}

function AddMember(groupId,modalId,groupName) {

    $.ajax({
        type: "GET",
        url: 'https://localhost:7221/Groups/getAllEmployeesExceptGroupMembers',
        data: {
            id: groupId
        },
        success: function (response) {
            var members = response;
            var select = document.getElementById("ModalEmployees");
            if (select.childElementCount != 0)
                $("#ModalEmployees").empty();
            var GroupNameModal = document.getElementById("GroupName");
            GroupNameModal.textContent ="Group : "+ groupName;
            GroupNameModal.name = groupId;

            var defaultOption = document.createElement("option")
            defaultOption.setAttribute("selected", "selected");
            defaultOption.setAttribute("disabled", "disabled");
            defaultOption.textContent = "Choose employee:"; 
            select.appendChild(defaultOption);
            for (var i = 0; i < members.length; i++) {
                var option = document.createElement("option");
                option.setAttribute("value", members[i].id);
                option.textContent = members[i].name + " " + members[i].lastName;
                select.appendChild(option);
            }

            $(modalId).modal('show');
        }
    });
}

function SubmitAddMember() {

    var GroupNameModal = document.getElementById("GroupName");
    var id = document.getElementById('ModalEmployees').selectedOptions[0].value;

    $.ajax({
        type: "POST",
        url: 'https://localhost:7221/Groups/addMember',
        data: {
            id: id,
            groupId: GroupNameModal.name
        },
        success: function (response) {
            $("#modal-add-member").modal('hide');
            alert("Member successfully added");
            window.location.reload();

        }
    });

}

function SubmitRemoveMember(id,groupId,member,group) {

    var result = confirm("Are you sure u want to remove "+member+" from the group "+group+" ?");
    if (result) {

        $.ajax({
            type: "POST",
            url: 'https://localhost:7221/Groups/removeMember',
            data: {
                id: id,
                groupId: groupId
            },
            success: function (response) {
                alert("Member successfully removed");
                window.location.reload();

            }
        });
    }

}

function SelfTaskAssign(id,signal) {

    $.ajax({
        type: "POST",
        url: 'https://localhost:7221/Groups/SelfTaskAssign',
        data: {
            id: id,
            signal: signal
        },
        success: function (response) {
            alert("Self task assign setted to: "+signal);
            window.location.reload();

        }
    });
}
