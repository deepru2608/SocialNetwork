$(document).ready(function () {
    $('[data-toggle="tooltip"]').tooltip()
});

window.global = {
    openModal: function (name) {
        name = '#' + name;
        $(name).modal('show')
    },
    closeModal: function (name) {
        name = '#' + name;
        $(name).modal('hide')
    },
    showNavMenu: function () {
        $("#sidebarToggle, #sidebarToggleTop").on('click', function (e) {
            $("body").toggleClass("sidebar-toggled");
            $(".sidebar").toggleClass("toggled");
            if ($(".sidebar").hasClass("toggled")) {
                $('.sidebar .collapse').collapse('hide');
            };
        });
    },
    showCalender: function (name) {
        $('#' + name).datepicker();
    }
}

function confirmDelete(uniqueId, isTrue) {
    var deleteSpan = 'deleteSpan_' + uniqueId;
    var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqueId;
    if (isTrue) {
        $('#' + deleteSpan).hide();
        $('#' + confirmDeleteSpan).show();
    } else {
        $('#' + deleteSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }
}



