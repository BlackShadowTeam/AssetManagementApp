$(document.body).on("click", "#createLink", function () {
    var url = "/AssetModels/Create";
    $.get(url, function (responseData) {
        $("#createMainBody").html(responseData);
    });
});