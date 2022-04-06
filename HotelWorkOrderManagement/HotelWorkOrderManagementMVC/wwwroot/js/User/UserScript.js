
function removeUser(id) {
    // url of the data that is to be delete
    $.ajax('https://localhost:7221/Users/Remove?id=' + id, {
        type: 'DELETE'
    }).done(function () {
        document.getElementById(id).remove();
        alert("User Deleted: ");
    });

}

                     
