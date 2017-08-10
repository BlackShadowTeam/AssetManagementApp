$(document.body).on("click", "#createLink", function () {
    var url = "/Branchs/Create";
    $.get(url, function (responseData) {
        $("#createMainBody").html(responseData);
    });
});