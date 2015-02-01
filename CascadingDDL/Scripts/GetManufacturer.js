$(document).ready(function () {
    var URL = 'home/ManufacturerList/';
    $.getJSON(URL, function (data) {
        var items = '<option value="">Select Manufacturer</option>';
        $.each(data, function (i, manufacturer) {
            items += "<option value='" + manufacturer.Value + "'>" + manufacturer.Text
            + "</option>";
        });
        $('#ManufacturersID').html(items);
    });
});