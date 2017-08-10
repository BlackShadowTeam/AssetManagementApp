$(document.body).on("click", "#createLink", function () {
    var url = "/Designations/Create";
    $.get(url, function (responseData) {
        $("#createMainBody").html(responseData);
    });
});