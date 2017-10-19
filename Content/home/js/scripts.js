
$(document).ready(function(){	

$("#cpanel").css({ 'min-height': $('#spanel').height() + "px" });
$("#logbtn").mouseup(function (e) {
    $(this).blur();
    if ($("#logrg").css('display') != 'block')
    {
        $("#logrg").show(511);
    }
    else
        $("#logrg").hide(555)
    $("html").css(scrollTop, 0);
});

$("#close").click(function () {
    $("#logrg").hide(555)
});
});