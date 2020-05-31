$('#searchBar').autocomplete({
    source: function (request, response) {
        $.ajax({
            headers: { RequestVerificationToken: $("#RequestCsrfToken").val() },
            datatype: 'json',
            url: 'Teams/SearchName',
            data: { searchName: request.term },
            success: function (data) { response(data) }
        })
    }
})