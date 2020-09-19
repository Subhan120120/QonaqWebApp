

showInPopup = (url, title, action) => {

    let SelectedRow = $('#Etable').bootstrapTable('getSelections')[0];

    if (SelectedRow === undefined && action == 'Edit') {
        alert(`Zehmet olmasa 1 setir secin`);
    }
    else {
        if (action == 'Edit') {
            url = `${url}/${SelectedRow.Id}`
        }

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
}



jQueryAjaxPost = form => {

    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            dataType: "json",
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {

                    var formActionId = form.action.substring(form.action.lastIndexOf('/') + 1);

                    if (formActionId == 0) {
                        $('#Etable').bootstrapTable('append', res.menuItem);
                    }
                    else {
                        $('#Etable').bootstrapTable('updateByUniqueId', {
                            id: res.menuItem.Id,
                            row: res.menuItem
                        })
                    }
                    $('#form-modal .modal-body').html('');
                    $('#form-modal .modal-title').html('');
                    $('#form-modal').modal('hide');
                }
                else {

                }
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


jQueryAjaxDelete = form => {

    let SelectedRows = $('#Etable').bootstrapTable('getSelections'); 

    if (SelectedRows[0] === undefined) {
        alert(`Zehmet olmasa 1 setir secin`);
    }
    else {

        var selectRowsArr = []
        for (let SelectedRow of SelectedRows) {
            selectRowsArr.push(parseInt(SelectedRow.Id))
        }

        if (confirm(Object.keys(selectRowsArr).length + ' element silinecek:')) {

            try {
                
                $.ajax({
                    type: 'POST',
                    url: form.action,
                    data: { selectRowsArr: selectRowsArr },
                    datatype: "json",
                    traditional: true,
                    success: function (res) {
      
                        for (let SelectedRow of SelectedRows) {
                            $('#Etable').bootstrapTable('removeByUniqueId', SelectedRow.Id)
                        }
                    },
                    error: function (err) {
                        console.log(err)
                    }
                })

            } catch (ex) {
                console.log(ex)
            }
        }
    }
    //prevent default form submit event
    return false;
}


$(function () {
    $("#loaderbody").addClass('hide');

    $(document).bind('ajaxStart', function () {
        $("#loaderbody").removeClass('hide');
    }).bind('ajaxStop', function () {
        $("#loaderbody").addClass('hide');
    });
});


