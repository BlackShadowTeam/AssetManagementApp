$(document.body).on("click", "#createLink", function () {
    var url = "/AssetLocations/Create";
    $.get(url, function (responseData) {
        $("#createMainBody").html(responseData);
    });
});