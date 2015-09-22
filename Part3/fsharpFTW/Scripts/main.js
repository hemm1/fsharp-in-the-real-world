var uri = 'api/currency';


$('form').on('submit', function (e) {
    e.preventDefault();

    $.get(uri, $('form').serialize(), function(data) {
        $('#converted').html("NOK: " +  data);
    });
});