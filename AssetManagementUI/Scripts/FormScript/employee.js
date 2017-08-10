$(document.body).on("click", "#createLink", function () {
    var url = "/Employees/Create";
    $.get(url, function (responseData) {
        $("#createMainBody").html(responseData);
    });
});