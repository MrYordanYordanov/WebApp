
function addBtn(result) {
    var childrens = $(result).parent().parent().children();
    var hiddenDivId = $(childrens[4]).children();
    var disId = $(hiddenDivId[0]).text().trim();

    var disName = $(childrens[0]).text().trim();
    var disPrName = $(childrens[1]).text().trim();
    var disScore = $(childrens[2]).text().trim();

    var semId = $('#semId').text().trim();

    $.ajax(
        {
            type: "PUT", //HTTP PUT Method
            url: "/Semesters/AddDiscipline", // Controller/View
            data: { //Passing data
                SemId: semId,
                DisId: disId,
            },
            success: function (result) {
                $(childrens).remove()
                if (Number(disScore) === 0) {
                    $('#semsdis > tbody:last')
                        .append(`<tr><td>${disName}</td><td>${disPrName}</td><td>${disScore}</td>
                        <td><button type="button" name="deleteBtn" onclick="deleteBtn(this)" class="btn btn-danger mb-2">Remove</button></td>
                     <td><div id="semDisId" style="display: none;"> ${disId} </div></td></tr>`);
                }
                else {
                    $('#semsdis > tbody:last')
                        .append(`<tr><td>${disName}</td><td>${disPrName}</td><td>${disScore}</td><td></td>
                          <td><div id="semDisId" style="display: none;"> ${disId} </div></td></tr>`);
                }
            }
        });
};

function deleteBtn(result) {
    var childrens = $(result).parent().parent().children();
    var hiddenDivId = $(childrens[4]).children();
    var disId = $(hiddenDivId[0]).text().trim();

    var disName = $(childrens[0]).text().trim();
    var disPrName = $(childrens[1]).text().trim();
    var disScore = $(childrens[2]).text().trim();

    $.ajax(
        {
            type: "PUT", //HTTP PUT Method
            url: "/Semesters/DeleteDiscipline", // Controller/View
            data: { //Passing data
                DisId: disId,
            },
            success: function (result) {
                $(childrens).remove()
                $('#availableDis > tbody:last')
                    .append(`<tr><td>${disName}</td><td>${disPrName}</td><td>${disScore}</td>
                          <td><button type="button" name="addBtn" onclick="addBtn(this)" class="btn btn-success mb-2">Add</button></td>
                          <td> <div id="availDisId" style="display: none;"> ${disId} </div></td></tr>`)
            }
        });
}