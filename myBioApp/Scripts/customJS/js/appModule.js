window.appModule = (function ($) {

    getProjectsSection = function () {
        $.ajax({
            url: '/Home/Projects',
            type: 'POST',
            dataType: 'html',
            success: function (data) {
                $('#myProjects').html(data);
            },
            error: function () {
                alert('failed to load the project data');
            }
        });
    };

    return {
        init: function () {
        },

        getProjectsSection: function () {
            getProjectsSection();
        }
    };
})(jQuery);