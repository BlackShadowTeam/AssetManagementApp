$(document.body).on("click", "#createLink", function () {
    var url = "/Departments/Create";
    $.get(url, function (responseData) {
        $("#createMainBody").html(responseData);
    });
});