function changeExistingImage(src) {
    console.log(src);

    $("#dvPreview").html("");
    $("#dvPreview").append("<img />");
    $("#dvPreview img").attr("src", "/images/boats/"+src);
}

var imagesForRemove = [];

function imageForRemove(img) {
    console.log(img);
    imagesForRemove.push(img);
    $("li#" + img).hide();

}


function editBoat() {

    

    newBoat = {}

    newBoat.BoatID = boatForEdit;
    newBoat.Name = $("#Name").val();
    newBoat.Make = $("#Make").val();
    newBoat.Model = $("#Model").val();
    newBoat.Year = $("#Year").val();
    newBoat.Length = $("#Length").val();
    newBoat.PassangerCapacity = $("#PassangerCapacity").val();
    newBoat.FuelCapacity = $("#FuelCapacity").val();
    newBoat.BedCount = $("#BedCount").val();
    newBoat.Desctription = $("#Desctription").val();

    console.log(newBoat);
    
    $.ajax({
        type: "POST",
        url: "https://localhost:44319/Boat/EditBoat",
        data: newBoat,
        success: function (id) {
            if (id != -1) {
                removeImagesForBoat(boatForEdit)
                uploadImagesForBoat(boatForEdit);
            }

            location.reload();
        }

    });
    
}

function removeImagesForBoat(boatForEdit) {

    imagesForRemove.forEach(img => {

        image = {}
        image.BoatId = boatForEdit;
        image.Image = img;

        $.ajax({

            type: "POST",
            url: "https://localhost:44319/Boat/DeleteImageForBoat/" + boatForEdit,
            data: image,
            dataType: "text",
            success: function () {
                console.log("deleted succesufully");
                location.reload();
            }
        });

    })

}