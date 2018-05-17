$(document).ready(function () {

    $("form").submit(function (e) {
        e.preventDefault();
        $.ajax({
            url: "api/calculation",
            method: "POST",
            data: {
                OperationName: this.elements["OperationName"].value,
                num1: this.elements["num1"].value,
                num2: this.elements["num2"].value

            },
            success: function (data) {
                addTableRow(data);
            }
        })
    });

    $("table").delegate("button", "click", function (e) {

        var button = $(this);
        var resultId = $(this).data("id");

        $.ajax({
            url: "api/calculation/" + resultId,
            method: "Get",
            success: function (data) {
                button.parent("td").parent("tr").append("<td>" + JSON.stringify(data) + "</td > ");
            }
        });
    });
});

var addTableRow = function (calculation) {
    $("table tbody").append("<tr><td>" + calculation + "</td><td><button data-id='" + calculation + "' type='button' class='btn btn - sm btn - primary'>Preview</button></td></tr>");
}
