$(document.body).on("click", "#createLink", function () {
    var url = "/Organizations/Create";
    $.get(url, function(responseData) {
        $("#createMainBody").html(responseData);
    });
});