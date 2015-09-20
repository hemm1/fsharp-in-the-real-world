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