var i = 0;
var required = "This field is required"

$('#myform').submit(function (myform) {
    var signal=validation();
    return (signal);
});

function validation() {
    i = 0;

    var name = $("#NameValidation");
    var lastName = $("#LastNameValidation");
    var password = $("#PasswordValidation");
    var userName = $("#UserNameValidation");
    var role = $("#RoleValidation");

    var UserNameValue = $("#UserName").val();


    if ($("#Name").val() == "") {
        name.text(required);

    } else {
        name.text("");
        i++;
    } if ($("#LastName").val() == "") {
        lastName.text(required);

    } else {
        lastName.text("");
        i++;
    } if ($("#Password").val() == "") {
        password.text(required);

    } else {
        password.text("");
        i++;
    } if ($("#UserName").val() == "") {
        userName.text(required);

    } else {
        userName.text("");
        i++;
    } if ($("#Role").val() == null) {
        role.text(required);

    } else {
        role.text("");
        i++;
    }

    
    if (i == 5) {
        $.ajax({
            type: "GET",
            url: 'https://localhost:7221/Users/IsUsernameAvailable?userName=' + UserNameValue,
            success: function (response) {
                if (response == false) {
                    userName.text("This Username is already taken");
                }
                else {
                    userName.text("");
                    return true;
                }
            }
        });

        
    }
  return false

    
}

