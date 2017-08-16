$(document.body).on("click", "#createLink", function () {
    var url = "/Organizations/Create";
    $.get(url, function(responseData) {
        $("#createMainBody").html(responseData);
    });
});



$(document.body).on("click", "#searchButton", function () {
    var url = "/Organizations/FindById";
    $.get(url, function(responseData) {
        alert(responseData.name);
    });
});