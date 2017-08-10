$(document.body).on("click", "#createLink", function () {
    var url = "/AssetTypes/Create";
    $.get(url, function (responseData) {
        $("#createMainBody").html(responseData);
    });
});