
var imageName;
var image64;

var images = [];

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
        $("#dvPreview img").attr("style", "min-width:200px;");

        images.push({ name: imageName, image64: image64 });
        console.log(images);

        display_thumb_images();
    };
    reader.onerror = function (error) {
        console.log('Error: ', error);
    };

    console.log(imageName);
    //console.log(image64);

}

function display_thumb_images() {
    $("#thumb_images").empty();

    images.forEach(img => {

        $("#thumb_images").append('<li onclick="changeImage(&apos;' + img.name + '&apos;)"><a data-target="#pic-2" data-toggle="tab"><img src="' + img.image64 + '" /></a><i class="bi bi-x-circle-fill delete-image" onclick="removeImage(&apos;' + img.name + '&apos;)"></i></li>');
       
    }
    );
}

function changeImage(src) {


    for (i = 0; i < images.length; i++) {
        if (images[i].name == src) {
            $("#dvPreview img").attr("src", images[i].image64);
        }
    }
}

function changeImageUvid(src) {

       $("#dvPreview img").attr("src", '/images/boats/'+src);
     
}

function removeImage(imgName) {

    for (i = 0; i < images.length; i++) {
        if (images[i].name == imgName) {
            images.splice(i, 1);
            i--;
            break;
        }
    }
    display_thumb_images();
    if (images[0] != undefined)
        $("#dvPreview img").attr("src", images[0].image64);
    else
        displayAddImageIcon();

}

function displayAddImageIcon() {

    $("#dvPreview").html("");
    $("#dvPreview").show();
    $("#dvPreview").append("<i></i>");
    $("#dvPreview i").attr("class","bi bi-images");
    $("#dvPreview i").attr("style", "font-size:12em;");
    $("#dvPreview i").attr("onclick", "openFileDialog()");

}