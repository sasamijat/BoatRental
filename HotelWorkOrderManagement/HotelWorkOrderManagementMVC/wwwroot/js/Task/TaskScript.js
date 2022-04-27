

$(document).ready(function () {

    $('#NewStatusModal').click(function () {
        $("#modal-setting-new-status").modal('show');
    });

    $('#DropTaskModal').click(function () {
        $("#modal-drop-task").modal('show');
    });
})

function SubmitChange(id) {
    var status = document.getElementById('ModalStatus').value;
    var description = document.getElementById('ModalDescription').value;

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
            $("#modal-setting-new-status").modal('hide');
            window.location.reload();
        }
    });

}
function DropTask(id) {
    var description = document.getElementById('ModalDescriptionTaskDrop').value;

    $.ajax({
        type: "POST",
        url: 'https://localhost:7221/TaskStateChanges/DropTask',
        data: {
            taskId: id,
            executorId: 1,
            description: description,
        },
        success: function () {
            $("#modal-drop-task").modal('hide');
            window.location='https://localhost:7221/Tasks/Tasks?id=3&team=false';
        }
    });

}

function DismissModal(id) {
    $(id).modal('hide');
}

function ModalRepetitiveTask(signal,id) {       
    if (signal=="True") {
        $.ajax({
            type: "POST",
            url: 'https://localhost:7221/Tasks/repetitiveRemove',
            data: {
                id: id,
            },
            success: function () {
                location.reload()
                alert("Task repetition successfully removed ")
                
            }
        });
    } else {
        $('#modal-repetitive-task').modal('show');
    }
}

function SubmitChangeRepetitive(id) {

        var setting = document.querySelector('input[name="rep_setting"]:checked').value;
        var rep_start = document.getElementById("rep_start").value;

        $.ajax({
            type: "POST",
            url: 'https://localhost:7221/Tasks/repetitiveSetting',
            data: {
                id: id,
                repSetting: setting,
                repStart: rep_start,
            },
            success: function () {
                $("#modal-repetitive-task").modal('hide');
                location.reload()
                alert("Task repetition successfully added")
            }
        });  


}
var commentImage64;
var imageName;

function SubmitComment(id, userId) {
    var text = $("#Comment").val();

    let obj = {};
    obj.Text = text;
    obj.CreatedById = userId;
    obj.TaskId = id;
    obj.CommentImage = commentImage64;
    obj.ImageName = imageName;


    if(text !="")
        $.ajax({
            type: "POST",
            url: 'https://localhost:7221/Tasks/SubmitComment',
            data: obj,
            success: function () {
            location.reload()
            alert("Task comment successfully added")
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

function RemoveComment(id) {
    $.ajax({
        type: "POST",
        url: 'https://localhost:7221/Tasks/RemoveComment',
        data: {
            id: id,
        },
        success: function () {
            location.reload()
            alert("Task comment successfully removed")
        }
    });
}


     