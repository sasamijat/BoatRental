var tId = 0;

var signal = 0;
function clickHold(id, taskSelfAsign) {
    if (taskSelfAsign=="True") {
        tId = setTimeout(GFG_Fun, 1000, id);
    }
    var divId = "#" + id;
    $(divId).on("mouseup touchend", function () {
        if (signal == 0) {
            window.location.href = 'https://localhost:7221/Tasks/GetTask?id=' + id;
        }
        clearTimeout(tId);
        signal = 0;
    });
}

function GFG_Fun(id) {
    ShowModal("#modal-take-team-task", id);
}

function DismissModal(id) {
    $(id).modal('hide');
}
var idTask;
function ShowModal(id, taskId) {
    idTask=taskId
    $(id).modal('show');
    signal = 1;
}

function TakeSelectedTask(userId) {
    $.ajax({
        type: "POST",
        url: 'https://localhost:7221/Tasks/TakeSelectedTask',
        data: {
            taskId: idTask,
            userId: userId
        },
        success: function () {
            idTask = null;
            DismissModal("#modal-take-team-task");
            window.location.reload();
        }
    });
}

function SelfTeamTasks(url) {
    window.location.href = url;
    var a = 1;
}

function search() {
    var keyword = $("#SearchInput").val();
    window.location.href = 'https://localhost:7221/Tasks/Tasks?team=@(ViewBag.Team)&keyword=' + keyword;
}