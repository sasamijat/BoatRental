function SubmitData() {
    var UserDataIn = {}
    UserDataIn.Id = $("#Id").val();
    UserDataIn.Name = $("#Name").val();
    UserDataIn.LastName = $("#LastName").val();
    UserDataIn.Password = $("#Password").val();
    UserDataIn.UserName = $("#UserName").val();
    var ProfileImage = $('#ProfileImage')[0].files[0];
    UserDataIn.Role = $("#Role").val();



    $.ajax({
        type: "POST",
        url: "https://localhost:7221/Users/Upsert",
        data: {
            UserDataIn: UserDataIn,
            ProfileImage: ProfileImage
        },
        success: function () {
            window.location.href='https://localhost:7221/Users/Upsert';
            alert("User successfully added")
            
        }
    })

}