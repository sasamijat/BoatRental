$(document).ready(function () {
    var element = document.getElementById("Executor");
    var id = element.title
    var url = 'https://localhost:7221/Users/GetUserName?id=' + id;
    $.ajax({
        url: url,
        type: 'GET',
        success: function (response) {
            document.getElementById("Executor").innerHTML = response;
        }
    });

})

