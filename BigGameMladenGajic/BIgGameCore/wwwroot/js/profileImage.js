
var imageName;
var image64;

function openFileDialog() {
    $('#slika').trigger('click'); return false;
}

function getBase64() {

    $("#dvPreview").html("");
    var file = document.getElementById('slika').files[0]
    imageName = file.name
    var reader = new FileReader();
    reader.readAsDataURL(file);
    reader.onload = function () {
        image64 = reader.result;

        $("#dvPreview").show();
        $("#dvPreview").append("<img />");
        $("#dvPreview img").attr("src", reader.result);
        $("#dvPreview img").attr("style", "min-width:200px;max-width:40%;");
        $("#saveBtn").attr("style", "display:inline-flex");

    };
    reader.onerror = function (error) {
        console.log('Error: ', error);
    };

    console.log(imageName);
    console.log(image64);

}

function uploadProfileImage(userID) {

    let image = {};

    if (imageName != null && image64 != null) {

        image.ImageName = imageName;
        image.Attachment = image64;
        //image.ImageId = userID;

        console.log(image);

        $.ajax(
            {
                type: "POST",
                url: "https://localhost:44319/image/addNewProfileImage/" + userID,
                data: image,
                success: function () {
                    window.location.href = "/Home/Profile/" + userID;
                }
            }
        )
    }
    else {
        alert("Odaberite sliku!")
    }
}