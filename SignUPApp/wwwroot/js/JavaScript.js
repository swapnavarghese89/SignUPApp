
Scripts{<script type="text/jscript">

    jQuery.validator.unobtrusive.adapters.add("checkbox", function (options) {
            @if (options.element.tagName.toUpperCase() == "INPUT" && options.element.type.toUpperCase() == "CHECKBOX") {
        options.rules["required"] = true;
    if (options.message) {
        options.messages["required"] = options.message;
                }
            }
        });

    $('#CountryId').change(function () {
        var url = '@Url.Content("GetCityNames")'+"?CountryId="+$(this).val();
    alert(url);
    $.getJSON(url, function (data) {
            var items = "<option value='" + '' + "'>" + "--Select City--" + "</option>";
$.each(data, function (i, city) {
    items += "<option value='" + city.value + "'>" + city.text + "</option>";
});
$('#CityId').html(items);
        });
    });

</script >