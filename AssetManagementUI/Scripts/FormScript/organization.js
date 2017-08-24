/// <reference path="../DataTables/jquery.dataTables.js" />
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


$(document.body).on("click", "#saveButton", function () {
    var name = $("#Name").val();
    var shortName = $("#ShortName").val();
    var location = $("#Location").val();
    var description = $("#Description").val();
    var orgnation={name:name, shortName:shortName, location:location, description:description}

    $.ajax({
        type: "POST",
        url: "/Organizations/Save",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(orgnation),
        success:function(data) {
            if (data > 0) {
                alert("Success");
            } else {
                alert("Fail");
            }
        }
    });
});



//var table = $('#simple-table').DataTable({
//    columnDefs: [
//        { visible: false, targets: 1 }
//    ]
//});

//$('#simple-table tbody').on('click', 'td', function () {
//    var columnData = table
//        .column($(this).index() + ':visIdx')
//        .data();
//});

$(document).ready(function () {
    var table = $('#simple-table').DataTable();

    $('#simple-table tbody').on('click', 'tr', function () {
        if ($(this).hasClass('selected')) {

            alert(selected);
            //$(this).removeClass('selected');
        }
        else {
            table.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
        }
    });

    //$('#button').click(function () {
    //    table.row('.selected').remove().draw(false);
    //});
});


