$(document.body).on("click", "#createLink", function () {
    var url = "/AssetManufacturers/Create";
    $.get(url, function (responseData) {
        $("#createMainBody").html(responseData);
    });
});