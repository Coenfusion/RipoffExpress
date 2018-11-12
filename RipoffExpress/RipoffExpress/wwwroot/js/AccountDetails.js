var registerAjaxLinkLoad = function (element, target) {
    $.get($(element).data('url')).done(function (data) {
        $(target).html(data);
    });
};
