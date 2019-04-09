$(document).ready(function () {
    //$('#myTable').DataTable({ responsive: true });



    // Setup - add a text input to each footer cell
    $('#example thead th').each(function () {
        var title = $(this).text();
        if (title != "" && title != "Nombre_Cargo") {
            $(this).html($(this).html() + '<input type="text" placeholder="Filtrar ' + title + '" />');
        }



    });

    // DataTable
    var table = $('#example').DataTable();

    // Apply the search
    table.columns().every(function () {
        var that = this;

        $('input', this.header()).on('keyup change', function () {
            if (that.search() !== this.value) {
                that
                    .search(this.value)
                    .draw();
            }
        });
    });
});