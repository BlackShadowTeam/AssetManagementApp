$(document.body).on("click", "#createLink", function () {
    var url = "/Vendors/Create";
    $.get(url, function (responseData) {
        $("#createMainBody").html(responseData);
    });
});