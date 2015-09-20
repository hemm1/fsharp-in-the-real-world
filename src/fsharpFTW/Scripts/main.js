var uri = 'api/cars';

$(function() {
    $.getJSON(uri)
        .done(function(data) {
            $.each(data, function(key, item) {
                $('<tr id="car' + item.id + '">' +
                        '<td>' + (key + 1) + '</td>' +
                        '<td class="make">' + item.make + '</td>' +
                        '<td class="model">' + item.model + '</td> ' +
                        '<td class="edit"><button onClick="editCar(' + item.id + ')">Edit car</button></td>' +
                        '<td class="delete"><button onClick="deleteCar(' + item.id + ')">Delete car</button></td> ' +
                        '</tr>')
                    .appendTo($('#cars tbody'));
            });
        });
});

var editCar = function(id) {
    var make = $('#car' + id + ' ' + '.make');
    var makeText = make.text();
    var makeField = $('<input type="text" id="make' + id + '" value="' + makeText + '"/>');
    make.empty();
    makeField.appendTo(make);

    var model = $('#car' + id + ' ' + '.model');
    var modelText = model.text();
    var modelField = $('<input type="text" id="model' + id + '" value="' + modelText + '"/>');
    model.empty();
    modelField.appendTo(model);

    var edit = $('#car' + id + ' ' + '.edit');
    var saveButton = $('<button onClick="saveCar(' + id + ')">Save</button>');
    edit.empty();
    saveButton.appendTo(edit);
};

var saveCar = function(id) {
    var make = $('#make' + id).val();
    var model = $('#model' + id).val();

    var data = { "Id": id, "Make": make, "Model": model };

    $.ajax({
        url: uri + '/' + id,
        type: 'PUT',
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(data),
        dataType: "json",
    }).done(function() {
            location.reload();
        }
    );
}

var deleteCar = function(id) {
    $.ajax({
        url: uri + '/' + id,
        type: 'DELETE'
    }).done(function() {
            location.reload();
        }
    );
};

var newCar = function(event) {
    event.preventDefault();
    var make = event.target.make.value;
    var model = event.target.model.value;

    var data = { "Make": make, "Model": model };
    $.ajax({
        url: uri,
        type: 'POST',
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(data),
        dataType: "json",
    }).done(function() {
            location.reload();
        }
    );
}

$("#newcar").submit(newCar);