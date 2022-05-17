// For Filters
document.addEventListener("DOMContentLoaded", function () {

    


    // For Range Sliders



    $("#ex6txt").html($("#ex6").val()); 
    $("#ex6").on("input change", (e) => {
        $("#ex6txt").html(e.target.value);
    });

    $("#rangeLengtnTXT").html($("#rangeLengtn").val());
    $("#rangeLengtn").on("input change", (e) => {
        $("#rangeLengtnTXT").html(e.target.value);
    });


});

function showFilterBar() {

    if ($("#filterbar").hasClass("show")) {
        $("#filterbar").removeClass("show");
    } else {
        $("#filterbar").addClass("show");
    }
}
