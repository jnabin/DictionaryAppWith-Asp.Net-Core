// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('#searchWord').mouseenter(function () {
    $('#livesearch').stop().show();
});
$('input[type=search]').on('input', function () {
    $('#livesearch').stop().show();
});
$("#searchWord").mouseleave(function () {
    if (!$('#livesearch').is(':hover')) {
        $('#livesearch').hide();
    };
});
