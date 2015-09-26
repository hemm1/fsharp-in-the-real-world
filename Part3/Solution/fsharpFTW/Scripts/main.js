var currencyUri = 'api/currency';
var countriesUri = 'api/countries';


$('#currency').on('submit', function (e) {
    e.preventDefault();

    $.get(currencyUri, $('#currency').serialize(), function (data) {
        $('#converted').html("NOK: " +  data);
    });
});

$('#country-info').on('submit', function (e) {
    e.preventDefault();

    function getLanguages(languages) {
        var result = "";
        for (var key in languages) {
            result += languages[key] + " ,";
        }
        return result;
    }

    $.get(countriesUri, $('#country-info').serialize(), function (data) {
        $('.country-info').html(
            "<p>Name: " + data.name + "</p>" +
            "<p>Population: " + data.population + "</p>" +
            "<p>Languages: " + getLanguages(data.languages) + "</p>"
            );
    });
});

$(document).ready(function() {

    $.get(countriesUri, function (data) {
        $.each(data, function (key, value) {

          $("#country-info select").append('<option value=' + value.code + '>' + value.name + '</option>');
        });
    });

  
})