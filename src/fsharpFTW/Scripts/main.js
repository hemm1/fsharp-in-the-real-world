var uri = 'api/cars';

$(function() {
    $.getJSON(uri)
        .done(function(data) {
            $.each(data, function(key, item) {
                $('<tr><td>' + item.id + '</td><td>' + item.make + '</td><td>' + item.model + '</td></tr>')
                    .appendTo($('#cars tbody'));
            });
        });
});

var del = function() {
    $.ajax({
        url: uri,
        type: 'DELETE'
    });
};

$("#deleteFerrari").click(function() {
    del();
})