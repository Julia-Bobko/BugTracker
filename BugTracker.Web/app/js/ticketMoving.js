$(function () {

    $('div.draggable').draggable({
        helper: function () {
            return $('<img src="http://professorweb.ru/downloads/jquery/lily.png"/>')
        }
    });

    $('#basket').droppable({
        activeClass: "active",
        hoverClass: "hover",
        over: function (event, ui) {
            ui.helper.css("border", "thick solid #27e6ed")
        },
        out: function (event, ui) {
            ui.helper.css("border", "")
        }
    });

});