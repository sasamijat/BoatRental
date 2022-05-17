function addNewBoat() {

    boatId = -1;

    newBoat = {}

    newBoat.Name = $("#Name").val();
    newBoat.Make = $("#Make").val();
    newBoat.Model = $("#Model").val();
    newBoat.Year = $("#Year").val();
    newBoat.Length = $("#Length").val();
    newBoat.PassangerCapacity = $("#PassangerCapacity").val();
    newBoat.FuelCapacity = $("#FuelCapacity").val();
    newBoat.BedCount = $("#BedCount").val();
    newBoat.Desctription = $("#Desctription").val();
    
    $.ajax({
        type: "POST",
        url: "https://localhost:44319/Boat/AddNewBoat",
        data: newBoat,
        success: function (id) {
            if (id != -1) {
                boatId = id;
                uploadImagesForBoat(id);
            }
        }

    });
    
}

function uploadImagesForBoat(boatId) {
    images.forEach(img => {
        image = {}
        image.ImageName = img.name;
        image.Attachment = img.image64;


        $.ajax(
            {
                type: "POST",
                url: "https://localhost:44319/image/addNewBoatImage/" + boatId,
                data: image,
                success: function () {
                    console.log("uspean upload!");
                }
            }
        )
    });

}
