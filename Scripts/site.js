$(function () {
    nav = $("nav.navbar");
    navh = nav.height();
    navf = function () {
        if ($(this).scrollTop() > navh)
            nav.addClass("nav-dark ");
        else
            nav.removeClass("nav-dark ");
    }
    $(document).scroll(navf);
    navf();
    $("body").animate({ 'opacity': '1' }, 1000);
    $('#body').css({ 'padding-top': navh * 2 + "px" });
});