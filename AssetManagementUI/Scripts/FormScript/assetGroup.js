$(document.body).on("click", "#createLink", function () {
    var url = "/AssetGroups/Create";
    $.get(url, function (responseData) {
        $("#createMainBody").html(responseData);
    });
});