var nameregex = /^[A-Z].+$/;
var prnameregex = /^[A-Z]+[a-z]+([\s.]*[A-Z]+[a-z]+)*$/;

function nameValidation(nameVal, idMessSelector, inputIdSellector) {
    var nameMessage = "";
    $(inputIdSellector).css('border', '');
    $(idMessSelector).css('color', '');

    if (nameVal.length === 0) {
        nameMessage = "Name is required";
        $(idMessSelector).text(nameMessage);
        $(idMessSelector).attr('class', 'visible-lg');
        $(inputIdSellector).css('border', '2px solid #FF0000');
        $(idMessSelector).css('color', 'red');
        return false;
    }
    else {
        if (nameVal.match(nameregex)) {
            $(idMessSelector).attr('class', 'hidden');
            $(idMessSelector).text();
            return true;
        }
        else {
            nameMessage = "Name must starts with uppercase and contains at least 2 letters";
            $(idMessSelector).text(nameMessage);
            $(idMessSelector).attr('class', 'visible-lg');
            $(inputIdSellector).css('border', '2px solid #FF0000');
            $(idMessSelector).css('color', 'red');
            return false;
        }
    }
}

function prNameValidation(prnameVal, idMessSelector, inputIdSellector) {
    var prnameMessage = "";
    $(inputIdSellector).css('border', '');
    $(idMessSelector).css('color', '');

    if (prnameVal.length === 0) {
        prnameMessage = "Proffesor Name is required";
        $(idMessSelector).text(prnameMessage);
        $(idMessSelector).attr('class', 'visible-lg');
        $(inputIdSellector).css('border', '2px solid #FF0000');
        $(idMessSelector).css('color', 'red');
        return false;
    }
    else {
        if (prnameVal.match(prnameregex)) {
            $(idMessSelector).attr('class', 'hidden');
            $(idMessSelector).text();

            return true;
        }
        else {
            prnameMessage = "Proffesor Name must starts with uppercase follow with lowercase letter and contains at least 2 letters";
            $(idMessSelector).text(prnameMessage);
            $(idMessSelector).attr('class', 'visible-lg');
            $(inputIdSellector).css('border', '2px solid #FF0000');
            $(idMessSelector).css('color', 'red');
            return false;
        }
    }
}

function scoreValidation(scoreVal, idMessSelector, inputIdSellector) {
    var scoreMessage = "";
    $(inputIdSellector).css('border', '');
    $(idMessSelector).css('color', '');
    if (scoreVal) {
        if (scoreVal >= 0) {
            $(idMessSelector).attr('class', 'hidden');
            $(idMessSelector).text();
            return true;
        }
        else {
            scoreMessage = "Score must be a positive number";
            $(idMessSelector).text(scoreMessage);
            $(idMessSelector).attr('class', 'visible-lg');
            $(inputIdSellector).css('border', '2px solid #FF0000');
            $(idMessSelector).css('color', 'red');
            return false;
        }
    }
    else {
        scoreMessage = "Score must be a number";
        $(idMessSelector).text(scoreMessage);
        $(idMessSelector).attr('class', 'visible-lg');
        $(inputIdSellector).css('border', '2px solid #FF0000');
        $(idMessSelector).css('color', 'red');
        return false;
    }
}

$('#disciplineName').on('change', function () {
    var nameVal = $(this).val();
    nameValidation(nameVal, '#nameVMessage', '#disciplineName');
})
$('#disciplineProfessorName').on('change', function () {
    var prnameVal = $(this).val();
    prNameValidation(prnameVal, '#prNameVMessage', '#disciplineProfessorName');
})
$('#disciplineScore').on('change', function () {
    var scoreVal = Number($(this).val());
    scoreValidation(scoreVal, '#scoreVMessage', '#disciplineScore');
})

function showErrorMessages(message, messSelector, inputSellector) {
    $(inputSellector).css('border', '2px solid #FF0000');
    $(messSelector).text(message);
    $(messSelector).attr('class', 'visible-lg');
    $(messSelector).css('color', 'red');
}


function saveBtn(result) {
    var childrens = $(result).parent().parent().children();
    var nameinput = $(childrens[1]).children();
    var prinput = $(childrens[2]).children();
    var scoreinput = $(childrens[3]).children();
    var disEditName = $(nameinput[0]).val();
    var disEditPrName = $(prinput[0]).val();
    var disEditPrScore = $(scoreinput[0]).val();


    $(nameinput[0]).on('change', function () {
        var nameVal = $(this).val();
        nameValidation(nameVal, nameinput[1], nameinput[0]);
    })
    $(prinput[0]).on('change', function () {
        var prnameVal = $(this).val();
        prNameValidation(prnameVal, prinput[1], prinput[0]);
    })
    $(scoreinput[0]).on('change', function () {
        var scoreVal = Number($(this).val());
        scoreValidation(scoreVal, scoreinput[1], scoreinput[0]);
    })

    var editnameValSuc = nameValidation(disEditName, nameinput[1], nameinput[0]);
    var editproNameValSuc = prNameValidation(disEditPrName, prinput[1], prinput[0]);
    var editscoreValSuc = scoreValidation(disEditPrScore, scoreinput[1], scoreinput[0]);

    if (editnameValSuc && editproNameValSuc && editscoreValSuc) {
        var id = $(childrens[0]).text();
        $.ajax(
            {
                type: "PUT", //HTTP PUT Method
                url: "Disciplines/Edit", // Controller/View
                data: { //Passing data
                    Id: id,
                    Name: disEditName, //Reading text box values using Jquery
                    ProfessorName: disEditPrName,
                    Score: disEditPrScore
                },
                success: function (response) {
                    if (response.success) {
                        $(childrens[1]).empty()
                            .append(`${response.result.name}`);
                        $(childrens[2]).empty()
                            .append(`${response.result.professorName}`);
                        $(childrens[3]).empty()
                            .append(`${response.result.score.toFixed(2)}`);
                        $(childrens[4]).empty()
                            .append(`<button type="button" onclick="editBtn($(this))" class="btn btn-warning mb-2">Edit</button>`);
                    } else {
                        if (response.result.nameMessage) {
                            showErrorMessages(response.result.nameMessage, nameinput[1], nameinput[0]);
                        }
                        if (response.result.prNameMessage) {
                            showErrorMessages(response.result.prNameMessage, prinput[1], prinput[0]);
                        }
                        if (response.result.scoreMessage) {
                            showErrorMessages(response.result.scoreMessage, scoreinput[1], scoreinput[0]);
                        }
                    }
                }
            });
    }
};

function editBtn(result) {
    var childrens = $(result).parent().parent().children();
    var disName = $(childrens[1]).text().trim();
    var disPrName = $(childrens[2]).text().trim();
    var disScore = $(childrens[3]).text().trim();

    $(childrens[1]).empty()
        .append(`<input type="text" class="form-control" value="${disName}" id="disNameEdit" placeholder="Name">
                              <div class="hidden" id="editNameVMessage"></div>`)
    $(childrens[2]).empty()
        .append(`<input type="text" class="form-control" value="${disPrName}" id="disPrNameEdit" placeholder="ProfessorName">
                           <div class="hidden" id="editPrVMessage"></div>`)
    $(childrens[3]).empty()
        .append(`<input type="number"  min="0"  step=".5" class="form-control" value="${disScore}" id="disScoreEdit">
                   <div class="hidden" id="editScoreVMessage"></div>`)
    $(childrens[4]).empty()
        .append(`<button  onclick="saveBtn($(this))" type="button" name="saveBtn" class="btn btn-success mb-2">Save</button>`)

    var nameinput = $(childrens[1]).children();
    var prinput = $(childrens[2]).children();
    var scoreinput = $(childrens[3]).children();

    $(nameinput[0]).on('change', function () {
        var nameVal = $(this).val();
        nameValidation(nameVal, nameinput[1], nameinput[0]);
    })
    $(prinput[0]).on('change', function () {
        var prnameVal = $(this).val();
        prNameValidation(prnameVal, prinput[1], prinput[0]);
    })
    $(scoreinput[0]).on('change', function () {
        var scoreVal = Number($(this).val());
        scoreValidation(scoreVal, scoreinput[1], scoreinput[0]);
    })
};

//$(document).ready(function () {

$('#create').click(function (e) {

    let disciplineName = $('#disciplineName').val();
    let disciplineProfessorName = $('#disciplineProfessorName').val();
    let disciplineScore = $('#disciplineScore').val();

    var nameValSuc = nameValidation(disciplineName, '#nameVMessage', '#disciplineName');
    var proNameValSuc = prNameValidation(disciplineProfessorName, '#prNameVMessage', '#disciplineProfessorName');
    var scoreValSuc = scoreValidation(disciplineScore, '#scoreVMessage', '#disciplineScore');

    if (nameValSuc && proNameValSuc && scoreValSuc) {
        //e.stopPropagation();
        $.ajax(
            {
                type: "POST", //HTTP POST Method
                url: "/Disciplines/Create", // Controller/View
                data: { //Passing data
                    Name: disciplineName, //Reading text box values using Jquery
                    ProfessorName: disciplineProfessorName,
                    Score: disciplineScore
                },
                success: function (result) {
                    $('#disciplinesGrid > tbody:last')
                        .append(`<tr><td>${result.id}</td>
                                         <td>${result.name}</td><td>${result.professorName}</td>
                                         <td>${result.score.toFixed(2)}</td><td>
                                    <button type="button" onclick="editBtn(this)"  name="editBtn" class="btn btn-warning mb-2">Edit</button></td></tr>`);

                    return true;
                }
            });

        $('#disciplineName').val('');
        $('#disciplineProfessorName').val('');
        $('#disciplineScore').val('');
    }
    else {
        e.preventDefault();
    }
})