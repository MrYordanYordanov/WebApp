var nameregex = /^[A-Z]+[a-z0-9 ]+$/;

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

function startDValidation(startDVal, idMessSelector, inputIdSellector) {
    var startDMessage = "";
    $(inputIdSellector).css('border', '');
    $(idMessSelector).css('color', '');

    if (startDVal) {
        let isValid = Date.parse(startDVal)
        if (isValid) {
            $(idMessSelector).attr('class', 'hidden');
            $(idMessSelector).text();
            return true;
        }
        else {
            startDMessage = "Invalid start date";
            $(idMessSelector).text(startDMessage);
            $(idMessSelector).attr('class', 'visible-lg');
            $(inputIdSellector).css('border', '2px solid #FF0000');
            $(idMessSelector).css('color', 'red');
            return false;
        }
    }
    else {
        startDMessage = "Start date is required";
        $(idMessSelector).text(startDMessage);
        $(idMessSelector).attr('class', 'visible-lg');
        $(inputIdSellector).css('border', '2px solid #FF0000');
        $(idMessSelector).css('color', 'red');
        return false;
    }
}

function endDValidation(endDVal, idMessSelector, inputIdSellector) {
    var endDMessage = "";
    $(inputIdSellector).css('border', '');
    $(idMessSelector).css('color', '');

    if (endDVal) {
        let isValid = Date.parse(endDVal)
        if (isValid) {
            $(idMessSelector).attr('class', 'hidden');
            $(idMessSelector).text();
            return true;
        }
        else {
            endDMessage = "Invalid end date";
            $(idMessSelector).text(endDMessage);
            $(idMessSelector).attr('class', 'visible-lg');
            $(inputIdSellector).css('border', '2px solid #FF0000');
            $(idMessSelector).css('color', 'red');
            return false;
        }
    } else {
        endDMessage = "End Date is required";
        $(idMessSelector).text(endDMessage);
        $(idMessSelector).attr('class', 'visible-lg');
        $(inputIdSellector).css('border', '2px solid #FF0000');
        $(idMessSelector).css('color', 'red');
        return false;
    }
}

$('#semName').on('change', function () {
    var nameVal = $(this).val();
    nameValidation(nameVal, '#nameVMessage', '#semName');
})
$('#semStartDate').on('change', function () {
    var strDVal = $(this).val();
    startDValidation(strDVal, '#startDVMessage', '#semStartDate');
})
$('#semEndDate').on('change', function () {
    var endDVal = $(this).val();
    endDValidation(endDVal, '#endDVMessage', '#semEndDate');
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
    var startDateinput = $(childrens[2]).children();
    var endDateinput = $(childrens[3]).children();
    var semEditName = $(nameinput[0]).val();
    var semEditStartDate = $(startDateinput[0]).val();
    var semEditEndDate = $(endDateinput[0]).val();

    $(nameinput[0]).on('change', function () {
        var nameVal = $(this).val();
        nameValidation(nameVal, nameinput[1], nameinput[0]);
    })
    $(startDateinput[0]).on('change', function () {
        var strDVal = $(this).val();
        startDValidation(strDVal, startDateinput[1], startDateinput[0]);
    })
    $(endDateinput[0]).on('change', function () {
        var endDVal = $(this).val();
        endDValidation(endDVal, endDateinput[1], endDateinput[0]);
    })

    var editnameValSuc = nameValidation(semEditName, nameinput[1], nameinput[0]);
    var editStartDValSuc = startDValidation(semEditStartDate, startDateinput[1], startDateinput[0]);
    var editEndDValSuc = endDValidation(semEditEndDate, endDateinput[1], endDateinput[0]);

    if (editnameValSuc && editStartDValSuc && editEndDValSuc) {
        var id = $(childrens[0]).text();
        $.ajax(
            {
                type: "PUT", //HTTP PUT Method
                url: "Semesters/Edit", // Controller/View
                data: { //Passing data
                    Id: id,
                    Name: semEditName, //Reading text box values using Jquery
                    StartDate: semEditStartDate,
                    EndDate: semEditEndDate
                },
                success: function (response) {
                    if (response.success) {
                        $(childrens[1]).empty()
                            .append(`${response.result.name}`);
                        $(childrens[2]).empty()
                            .append(`${response.result.startDate.toString()}`);
                        $(childrens[3]).empty()
                            .append(`${response.result.endDate.toString()}`);
                        $(childrens[4]).empty()
                            .append(`<button type="button" onclick="editBtn($(this))" class="btn btn-warning mb-2">Edit</button>
                                       <a href="/Semesters/Details/${id}" class="btn btn-info" role="button">View Disciplines</a>`);
                    } else {
                        if (response.result.nameMessage) {
                            showErrorMessages(response.result.nameMessage, nameinput[1], nameinput[0]);
                        }
                        if (response.result.startDateMessage) {
                            showErrorMessages(response.result.startDateMessage, startDateinput[1], startDateinput[0]);
                        }
                        if (response.result.endDateMessage) {
                            showErrorMessages(response.result.endDateMessage, endDateinput[1], endDateinput[0]);
                        }
                    }
                }
            });

    }
};


function editBtn(result) {
    var childrens = $(result).parent().parent().children();
    var semId = Number($(childrens[0]).text().trim());
    var semName = $(childrens[1]).text().trim();
    var semStartDate = $(childrens[2]).text().trim();
    var semtEndDate = $(childrens[3]).text().trim();

    $(childrens[1]).empty()
        .append(`<input type="text" class="form-control" value="${semName}" id="semNameEdit" placeholder="Name">
                                    <div class="hidden" id="editNameVMessage"></div>`)
    $(childrens[2]).empty()
        .append(`<input type="date" class="form-control" value="${semStartDate}" id="semStartDateEdit" placeholder="StartDate">
                                     <div class="hidden" id="editStartDVMessage"></div>`)
    $(childrens[3]).empty()
        .append(`<input type="date" class="form-control" value="${semtEndDate}" id="semEndDateEdit" placeholder="EndDate">
                                     <div class="hidden" id="editEndDVMessage"></div>`)
    $(childrens[4]).empty()
        .append(`<button  onclick="saveBtn($(this))" type="button" name="saveBtn" class="btn btn-success mb-2">Save</button>
                           <a href="/Semesters/Details/${semId}" class="btn btn-info" role="button">View Disciplines</a>`)

    var nameinput = $(childrens[1]).children();
    var startDateinput = $(childrens[2]).children();
    var endDateinput = $(childrens[3]).children();

    $(nameinput[0]).on('change', function () {
        var nameVal = $(this).val();
        nameValidation(nameVal, nameinput[1], nameinput[0]);
    })
    $(startDateinput[0]).on('change', function () {
        var strDVal = $(this).val();
        startDValidation(strDVal, startDateinput[1], startDateinput[0]);
    })
    $(endDateinput[0]).on('change', function () {
        var endDVal = $(this).val();
        endDValidation(endDVal, endDateinput[1], endDateinput[0]);
    })
};



//$(document).ready(function () {
$('#create').click(function (e) {
    let semName = $('#semName').val();
    let semStartDate = $('#semStartDate').val();
    let semEndDate = $('#semEndDate').val();

    var nameValSuc = nameValidation(semName, '#nameVMessage', '#semName');
    var startDValSuc = startDValidation(semStartDate, '#startDVMessage', '#semStartDate');
    var endDValSuc = endDValidation(semEndDate, '#endDVMessage', '#semEndDate');

    if (nameValSuc && startDValSuc && endDValSuc) {
        $.ajax(
            {
                type: "POST", //HTTP POST Method
                url: "Semesters/Create", // Controller/View
                data: { //Passing data
                    Name: semName, //Reading text box values using Jquery
                    StartDate: semStartDate,
                    EndDate: semEndDate
                },
                success: function (result) {

                    $('#semsGrid > tbody:last')
                        .append(`<tr><td>${result.id}</td><td>${result.name}</td><td>${result.startDate}</td><td>${result.endDate}</td><td>
                                <button type="button" onclick="editBtn(this)"   name="editBtn" class="btn btn-warning mb-2">Edit</button>
                                   <a href="/Semesters/Details/${result.id}" class="btn btn-info" role="button">View Disciplines</a></td></tr>`);
                }
            });

        $('#semName').val('');
        $('#semStartDate').val('');
        $('#semEndDate').val('');
    } else {
        e.preventDefault();
    }
});