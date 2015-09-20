var uri = 'api/cars';

$(function() {
    $.getJSON(uri)
        .done(function(data) {
            $.each(data, function(key, item) {
                $('<tr><td>' + (key + 1) + '</td><td>' + item.make + '</td><td>' + item.model + '</td> <td> <button onClick="deleteCar(' + item.id + ')">Delete car</button></td> </tr>')
                    .appendTo($('#cars tbody'));
            });
        });
});

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