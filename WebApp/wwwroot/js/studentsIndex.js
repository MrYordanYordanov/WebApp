﻿var nameregex = /^[A-Z][a-z]+$/;

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
            nameMessage = "Name must starts with uppercase follow with lowercase and contains at least 2 letters";
            $(idMessSelector).text(nameMessage);
            $(idMessSelector).attr('class', 'visible-lg');
            $(inputIdSellector).css('border', '2px solid #FF0000');
            $(idMessSelector).css('color', 'red');
            return false;
        }
    }
}

function surValidation(surVal, idMessSelector, inputIdSellector) {
    var surMessage = "";
    $(inputIdSellector).css('border', '');
    $(idMessSelector).css('color', '');

    if (surVal.length === 0) {
        surMessage = "Surname is required";
        $(idMessSelector).text(surMessage);
        $(idMessSelector).attr('class', 'visible-lg');
        $(inputIdSellector).css('border', '2px solid #FF0000');
        $(idMessSelector).css('color', 'red');
        return false;
    }
    else {
        if (surVal.match(nameregex)) {
            $(idMessSelector).attr('class', 'hidden');
            $(idMessSelector).text();
            return true;
        }
        else {
            surMessage = "Surname must starts with uppercase follow with lowercase and contains at least 2 letters";
            $(idMessSelector).text(surMessage);
            $(idMessSelector).attr('class', 'visible-lg');
            $(inputIdSellector).css('border', '2px solid #FF0000');
            $(idMessSelector).css('color', 'red');
            return false;
        }
    }
}

function dobValidation(dobDVal, idMessSelector, inputIdSellector) {
    var dobMessage = "";
    $(inputIdSellector).css('border', '');
    $(idMessSelector).css('color', '');

    if (dobDVal) {
        let isValid = Date.parse(dobDVal)
        if (isValid) {
            $(idMessSelector).attr('class', 'hidden');
            $(idMessSelector).text();
            return true;
        }
        else {
            dobMessage = "Invalid DOB";
            $(idMessSelector).text(dobMessage);
            $(idMessSelector).attr('class', 'visible-lg');
            $(inputIdSellector).css('border', '2px solid #FF0000');
            $(idMessSelector).css('color', 'red');
            return false;
        }
    } else {
        dobMessage = "DOB is required";
        $(idMessSelector).text(dobMessage);
        $(idMessSelector).attr('class', 'visible-lg');
        $(inputIdSellector).css('border', '2px solid #FF0000');
        $(idMessSelector).css('color', 'red');
        return false;
    }
}

$('#studentName').on('change', function () {
    var nameVal = $(this).val();
    nameValidation(nameVal, '#nameVMessage', '#studentName');
})
$('#studentSurname').on('change', function () {
    var surVal = $(this).val();
    surValidation(surVal, '#surVMessage', '#studentSurname');
})
$('#studentDob').on('change', function () {
    var dobVal = $(this).val();
    dobValidation(dobVal, '#dobDVMessage', '#studentDob');
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
    var surnameinput = $(childrens[2]).children();
    var dobinput = $(childrens[3]).children();
    var studentEditName = $(nameinput[0]).val();
    var studentEditSurname = $(surnameinput[0]).val();
    var studentEditDob = $(dobinput[0]).val();

    $(nameinput[0]).on('change', function () {
        var nameVal = $(this).val();
        nameValidation(nameVal, nameinput[1], nameinput[0]);
    })
    $(surnameinput[0]).on('change', function () {
        var surVal = $(this).val();
        surValidation(surVal, surnameinput[1], surnameinput[0]);
    })
    $(dobinput[0]).on('change', function () {
        var dobVal = $(this).val();
        dobValidation(dobVal, dobinput[1], dobinput[0]);
    })

    var editnameValSuc = nameValidation(studentEditName, nameinput[1], nameinput[0]);
    var editSurValSuc = surValidation(studentEditSurname, surnameinput[1], surnameinput[0]);
    var editDobValSuc = dobValidation(studentEditDob, dobinput[1], dobinput[0]);

    if (editnameValSuc && editSurValSuc && editDobValSuc) {
        var id = $(childrens[0]).text();
        $.ajax(
            {
                type: "PUT", //HTTP PUT Method
                url: "Students/Edit", // Controller/View
                data: { //Passing data
                    Id: id,
                    Name: studentEditName, //Reading text box values using Jquery
                    Surname: studentEditSurname,
                    Dob: studentEditDob
                },
                success: function (response) {
                    if (response.success) {
                        $(childrens[1]).empty()
                            .append(`${response.result.name}`);
                        $(childrens[2]).empty()
                            .append(`${response.result.surname}`);
                        $(childrens[3]).empty()
                            .append(`${response.result.dob.toString()}`);
                        $(childrens[4]).empty()
                            .append(`<button type="button" onclick="editBtn($(this))" class="btn btn-warning mb-2">Edit</button>
                                                                  <a href="/Students/Details/${id}" class="btn btn-info" role="button">View Semesters</a>`);
                    } else {
                        if (response.result.nameMessage) {
                            showErrorMessages(response.result.nameMessage, nameinput[1], nameinput[0]);
                        }
                        if (response.result.surnameMessage) {
                            showErrorMessages(response.result.surnameMessage, surnameinput[1], surnameinput[0]);
                        }
                        if (response.result.dobMessage) {
                            showErrorMessages(response.result.dobMessage, dobinput[1], dobinput[0]);
                        }
                    }
                }
            });
    }

};


function editBtn(result) {

    var childrens = $(result).parent().parent().children();
    var studId = Number($(childrens[0]).text().trim());
    var studentName = $(childrens[1]).text().trim();
    var studentSurname = $(childrens[2]).text().trim();
    var studentDob = $(childrens[3]).text().trim();

    $(childrens[1]).empty()
        .append(`<input type="text" class="form-control" value="${studentName}" id="studentNameEdit" placeholder="Name">
                                                    <div class="hidden" id="editNameVMessage"></div>`)
    $(childrens[2]).empty()
        .append(`<input type="text" class="form-control" value="${studentSurname}" id="studentSurnameEdit" placeholder="Name">
                                                     <div class="hidden" id="editSurVMessage"></div>`)
    $(childrens[3]).empty()
        .append(`<input type="date" class="form-control" value="${studentDob}" id="studentDobEdit" placeholder="Date">
                                                      <div class="hidden" id="editDobVMessage"></div>`)
    $(childrens[4]).empty()
        .append(`<button  onclick="saveBtn($(this))" type="button" name="saveBtn" class="btn btn-success mb-2">Save</button>
                                                       <a href="/Students/Details/${studId}" class="btn btn-info" role="button">View Semesters</a>`)

    var nameinput = $(childrens[1]).children();
    var surnameinput = $(childrens[2]).children();
    var dobinput = $(childrens[3]).children();

    $(nameinput[0]).on('change', function () {
        var nameVal = $(this).val();
        nameValidation(nameVal, nameinput[1], nameinput[0]);
    })
    $(surnameinput[0]).on('change', function () {
        var surVal = $(this).val();
        surValidation(surVal, surnameinput[1], surnameinput[0]);
    })
    $(dobinput[0]).on('change', function () {
        var dobVal = $(this).val();
        dobValidation(dobVal, dobinput[1], dobinput[0]);
    })
};



//$(document).ready(function () {
$('#create').click(function (e) {
    studentName = $('#studentName').val();
    studentSurname = $('#studentSurname').val();
    studentDob = $('#studentDob').val();

    var nameValSuc = nameValidation(studentName, '#nameVMessage', '#studentName');
    var surValSuc = surValidation(studentSurname, '#surVMessage', '#studentSurname');
    var dobValSuc = dobValidation(studentDob, '#dobDVMessage', '#studentDob');

    if (nameValSuc && surValSuc && dobValSuc) {
        $.ajax(
            {
                type: "POST", //HTTP POST Method
                url: "Students/Create", // Controller/View
                data: { //Passing data
                    Name: studentName, //Reading text box values using Jquery
                    Surname: studentSurname,
                    Dob: studentDob
                },
                success: function (result) {

                    $('#studentsGrid > tbody:last')
                        .append(`<tr><td>${result.id}</td><td>${result.name}</td><td>${result.surname}</td><td>${result.dob}</td><td>
                                                    <button type="button" onclick="editBtn(this)"   name="editBtn" class="btn btn-warning mb-2">Edit</button>
                                                    <a href="/Students/Details/${result.id}" class="btn btn-info" role="button">View Semesters</a></td></tr>`);
                }
            });

        $('#studentName').val('');
        $('#studentSurname').val('');
        $('#studentDob').val('');
    } else {
        e.preventDefault();
    }
});