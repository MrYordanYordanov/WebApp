function addBtn(result) {
    var childrens = $(result).parent().parent().children();
    var hiddenDivId = $(childrens[4]).children();
    var semId = $(hiddenDivId[0]).text().trim();

    var semName = $(childrens[0]).text().trim();
    var semStartDate = $(childrens[1]).text().trim();
    var semEndDate = $(childrens[2]).text().trim();

    var studId = $('#studId').text().trim();

    $.ajax(
        {
            type: "PUT", //HTTP PUT Method
            url: "/Students/AddSemester", // Controller/View
            data: { //Passing data
                StudId: studId,
                SemId: semId,
            },
            success: function (result) {
                $(childrens).remove()
                $('#semsstud > tbody:last')
                    .append(`<tr><td>${semName}</td><td>${semStartDate}</td><td>${semEndDate}</td>
                          <td><a href="/Semesters/Details/${semId}" class="btn btn-info" role="button">View Disciplines</a></td></tr>`);

            }
        });
};