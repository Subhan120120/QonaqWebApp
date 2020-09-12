



$('.btn-outline-danger').click(function () {

    let getSelected = $('#Etable').bootstrapTable('getAllSelections')
    $.ajax({
        type: "POST",
        url: '@Url.Action("Delete")',
        dataType: "json",
        data: getSelected[0],
        success: function (data) {
            console.log(data)
            $table.bootstrapTable('removeByUniqueId', 1)
        },
        error: function (error) {
            console.log(error.responseXML);
        }
    });
});


$(document).ready(function () {


    $.ajax({
        type: "GET",
        url: '@Url.Action("GetMenuGroup")',
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        success: function (data) {


        },
        error: function (error) {
            console.log(error.responseXML);
        }
    });

});


showInPopup = (url, title) => {

    $.ajax({
        type: 'GET',
        url: url,
        success: function (res) {
            $("#form-modal .modal-body").html(res)
            $("#form-modal .modal-title").html(title)
            $("#form-modal").modal('show')
        }
    })
}


jQueryAjaxPost = form => {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $('#view-all').html(res.html)
                    $('#form-modal .modal-body').html('');
                    $('#form-modal .modal-title').html('');
                    $('#form-modal').modal('hide');
                }
                else
                    $('#form-modal .modal-body').html(res.html);
            },
            error: function (err) {
                console.log(err)
            }
        })
    } catch (ex) {
        console.log(ex)
    }
    //to prevent default form submit event
    return false;
}


