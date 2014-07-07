(function (window) {
    $(function () {
        $('a').click(function () {
            var id = $(this).attr('id');
            if ($('.' + id).is(":hidden")) {
                $('.' + id).show();
            } else {
                $('.' + id).hide();
            }
        });
    });
})(window)