$(document).ready(() => {
    $("#weiter").hide();
    $("#zurueck").hide();

    $("#formularbtn").click(() => {
        $("#weiter").show();
        $("#zurueck").show();
        $.ajax({
            url: "/formular/getAllFormular",
            method: "GET",
            success: (dataFromServer1) => {
                if (dataFromServer1 == "NoFormular") {
                    $("#formular").text("Keine Formulare vorhanden!");
                }
                else if (dataFromServer1 == "DbError") {
                    $("#formular").text("Es gibt zur Zeit Probleme mit dem Server!");
                }
                else {
                    $("#formular").html(createFormular(dataFromServer1));
                }
            },
            error: () => {
                $("#formular").text("Es trat ein Fehler auf - die Daten konnten nicht geladen werden!");
            }
        });
    });

    $("#weiter").click(() => {
        $("#formular").html(createFormular2());
    });

    $("#zurueck").click(() => {
        $("#formular").html(createFormular3());
    });

    $.ajax({
        url: "/formular/getAllFormular",
        method: "GET",
        success: (dataFromServer2) => {

            if (dataFromServer2 == "NoFormular") {
                $("#waehlen").text("Keine Formulare vorhanden!");
            }
            else if (dataFromServer2 == "DbError") {
                $("#waehlen").text("Es gibt zur Zeit Probleme mit dem Server!");
            }
            else {
                $("#waehlen").html(createSelectFormulare(dataFromServer2));
            }
        },
        error: () => {
            $("#waehlen").text("Es trat ein Fehler auf - die Daten konnten nicht geladen werden!");
        }
    });

    $("#waehlen").change(() => {
        let s = $("#waehlen").val();
        $.ajax({
            url: "/formular/getFormularById?id=" + s,
            method: "GET",
            success: (dataFromServer3) => {

                if (dataFromServer3 == "NoFormular") {
                    $("#formular2").text("Keine Formulare vorhanden!");
                }
                else if (dataFromServer3 == "DbError") {
                    $("#formular2").text("Es gibt zur Zeit Probleme mit dem Server!");
                }
                else {
                    $("#formular2").html(createFormularbyId(dataFromServer3));
                }
            },
            error: () => {
                $("#formular2").text("Es trat ein Fehler auf - die Daten konnten nicht geladen werden!");
            }
        });
    });

    $.ajax({
        url: "/formular/getKey",
        method: "GET",
        success: (dataFromServer4) => {

            if (dataFromServer4 == "NoFormular") {
                $("#wahlFormular").text("Keine Formulare vorhanden!");
            }
            else if (dataFromServer4 == "DbError") {
                $("#wahlFormular").text("Es gibt zur Zeit Probleme mit dem Server!");
            }
            else {
                $("#wahlFormular").html(createSelectErgebnis(dataFromServer4));
            }
        },
        error: () => {
            $("#wahlFormular").text("Es trat ein Fehler auf - die Daten konnten nicht geladen werden!");
        }
    });

    $("#weiter2").hide();
    $("#zurueck2").hide();

    $("#wahlFormular").change(() => {
        $("#weiter2").show();
        $("#zurueck2").show();
        let s = $("#wahlFormular").val();
        $.ajax({
            url: "/formular/getErgebnisByKey?key=" + s,
            method: "GET",
            success: (dataFromServer5) => {

                if (dataFromServer5 == "NoFormular") {
                    $("#antwort").text("Keine Formulare vorhanden!");
                }
                else if (dataFromServer5 == "DbError") {
                    $("#antwort").text("Es gibt zur Zeit Probleme mit dem Server!");
                }
                else {
                    $("#antwort").html(createErgebnis(dataFromServer5));
                }
            },
            error: () => {
                $("#antwort").text("Es trat ein Fehler auf - die Daten konnten nicht geladen werden!");
            }
        });
    });

    $("#weiter2").click(() => {
        $("#antwort").html(createErgebnis2());
    });

    $("#zurueck2").click(() => {
        $("#antwort").html(createErgebnis3());
    });

    $("#wahlFormular").change(() => {
        let s = $("#wahlFormular").val();
        $.ajax({
            url: "/formular/getErgebnisByKey?key=" + s,
            method: "GET",
            success: (dataFromServer6) => {

                if (dataFromServer6 == "NoFormular") {
                    $("#auswertung").text("Keine Formulare vorhanden!");
                }
                else if (dataFromServer6 == "DbError") {
                    $("#auswertung").text("Es gibt zur Zeit Probleme mit dem Server!");
                }
                else {
                    createChart(dataFromServer6);
                }
            },
            error: () => {
                $("#auswertung").text("Es trat ein Fehler auf - die Daten konnten nicht geladen werden!");
            }
        });
    });
});

var myChart

function createChart(data) {
    var xValues = ["Frage1", "Frage2", "Frage3", "Frage4", "Frage5", "Frage6", "Frage7", "Frage8"];
    /*var a1 = 0;
    var a2 = 0;
    var a3 = 0;
    var a4 = 0;
    var a5 = 0;
    var a6 = 0;
    var a7 = 0;
    var a8 = 0;*/
    var a = [0, 0, 0, 0, 0, 0, 0, 0]
    var l = data.length;
    for (let i = 0; i < l; i++) {
        a[0]+=data[i].a1;
        a[1]+=data[i].a2;
        a[2]+=data[i].a3;
        a[3]+=data[i].a4;
        a[4]+=data[i].a5;
        a[5]+=data[i].a6;
        a[6]+=data[i].a7;
        a[7]+=data[i].a8;
    }
    /*a1 = a1 / l;
    a2 = a2 / l;
    a3 = a3 / l;
    a4 = a4 / l;
    a5 = a5 / l;
    a6 = a6 / l;
    a7 = a7 / l;
    a8 = a8 / l;*/
    a[0] = a[0] / l;
    a[1] = a[1] / l;
    a[2] = a[2] / l;
    a[3] = a[3] / l;
    a[4] = a[4] / l;
    a[5] = a[5] / l;
    a[6] = a[6] / l;
    a[7] = a[7] / l
    var yValues = [a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7]];
    var barColors = "red";

    if (myChart != null) myChart.destroy();

    myChart = new Chart("myChart", {
        type: "bar",
        data: {
            labels: xValues,
            datasets: [{
                backgroundColor: barColors,
                data: yValues
            }]
        },
        options: {
            legend: { display: false },
            scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero: true
                    }
                }],
            }
        }
    });
}

let x;
let y;
let z;

function createSelectErgebnis(antwort) {
    let s = `<select>
        <option>Schlüssel wählen</option>`;
    for (let i = 0; i < antwort.length; i++) {
        s += `<option>${antwort[i].teacherKey}</option>`;
    }
    s += `</select>`;
    return s;
}

function createErgebnis(ergebnis) {
    x = ergebnis;
    y = 1;
    z = ergebnis.length;
    let s = `<div class="container">
            <table class="table table-striped table-bordered table-hover table-condensed">
                <thead>
                    <tr>
                        <th>Formularfragen</th>
                        <th>Formularantworten</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>FormularID</td>
                        <td>${ergebnis[y - 1].teacherId}</td>
                    </tr>
                    <tr>
                        <td>Überschrift</td>
                        <td>${ergebnis[y - 1].heading}</td>
                    </tr>
                    <tr>
                        <td>${ergebnis[y - 1].q1}</td>
                        <td>${ergebnis[y - 1].a1}</td>
                    </tr>
                    <tr>
                        <td>${ergebnis[y - 1].q2}</td>
                        <td>${ergebnis[y - 1].a2}</td>
                    </tr>
                    <tr>
                        <td>${ergebnis[y - 1].q3}</td>
                        <td>${ergebnis[y - 1].a3}</td>
                    </tr>
                    <tr>
                        <td>${ergebnis[y - 1].q4}</td>
                        <td>${ergebnis[y - 1].a4}</td>
                    </tr>
                    <tr>
                        <td>${ergebnis[y - 1].q5}</td>
                        <td>${ergebnis[y - 1].a5}</td>
                    </tr>
                    <tr>
                        <td>${ergebnis[y - 1].q6}</td>
                        <td>${ergebnis[y - 1].a6}</td>
                    </tr>
                    <tr>
                        <td>${ergebnis[y - 1].q7}</td>
                        <td>${ergebnis[y - 1].a7}</td>
                    </tr>
                    <tr>
                        <td>${ergebnis[y - 1].q8}</td>
                        <td>${ergebnis[y - 1].a8}</td>
                    </tr>
                    <tr>
                        <td>${ergebnis[y - 1].annotion}</td>
                        <td>${ergebnis[y - 1].annotionanswer}</td>
                    </tr>
                    <tr>
                        <td>Schlüssel</td>
                        <td>${ergebnis[y - 1].teacherKey}</td>
                    </tr>
                </tbody>
            </table>
        </div>`;
    return s;
}

function createErgebnis2() {
    y = y + 1;
    if (y <= z) {
        let s = `<div class="container">
            <table class="table table-striped table-bordered table-hover table-condensed">
                <thead>
                    <tr>
                        <th>Formularfragen</th>
                        <th>Formularantworten</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>FormularID</td>
                        <td>${x[y - 1].teacherId}</td>
                    </tr>
                    <tr>
                        <td>Überschrift</td>
                        <td>${x[y - 1].heading}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].q1}</td>
                        <td>${x[y - 1].a1}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].q2}</td>
                        <td>${x[y - 1].a2}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].q3}</td>
                        <td>${x[y - 1].a3}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].q4}</td>
                        <td>${x[y - 1].a4}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].q5}</td>
                        <td>${x[y - 1].a5}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].q6}</td>
                        <td>${x[y - 1].a6}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].q7}</td>
                        <td>${x[y - 1].a7}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].q8}</td>
                        <td>${x[y - 1].a8}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].annotion}</td>
                        <td>${x[y - 1].annotionanswer}</td>
                    </tr>
                    <tr>
                        <td>Schlüssel</td>
                        <td>${x[y - 1].teacherKey}</td>
                    </tr>
                </tbody>
            </table>
        </div>`;
        return s;
    } else {
        y = z + 1;
        let d = `<h5 style="position: relative; top: 120px">alle verfügbaren Ergebnisformulare</h5><br />`;
        return d;
    }
}

function createErgebnis3() {
    y = y - 1;
    if (y >= 1) {
        let s = `<div class="container">
            <table class="table table-striped table-bordered table-hover table-condensed">
                <thead>
                    <tr>
                        <th>Formularfragen</th>
                        <th>Formularantworten</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>FormularID</td>
                        <td>${x[y - 1].teacherId}</td>
                    </tr>
                    <tr>
                        <td>Überschrift</td>
                        <td>${x[y - 1].heading}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].q1}</td>
                        <td>${x[y - 1].a1}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].q2}</td>
                        <td>${x[y - 1].a2}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].q3}</td>
                        <td>${x[y - 1].a3}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].q4}</td>
                        <td>${x[y - 1].a4}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].q5}</td>
                        <td>${x[y - 1].a5}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].q6}</td>
                        <td>${x[y - 1].a6}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].q7}</td>
                        <td>${x[y - 1].a7}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].q8}</td>
                        <td>${x[y - 1].a8}</td>
                    </tr>
                    <tr>
                        <td>${x[y - 1].annotion}</td>
                        <td>${x[y - 1].annotionanswer}</td>
                    </tr>
                    <tr>
                        <td>Schlüssel</td>
                        <td>${x[y - 1].teacherKey}</td>
                    </tr>
                </tbody>
            </table>
        </div>`;
        return s;
    } else {
        y = 0;
        let d = `<h5 style="position: relative; top: 120px">Hier werden die Ergebnisformulare angezeigt</h5>`;
        return d;
    }
}

let f=0;
let i;

function createSelectFormulare(formular) {
    let s = `<select>
        <option>FormularID wählen</option>`;
    for (let i = 0; i < formular.length; i++) {
        s += `<option>${formular[i].teacherId}</option>`;
    }
    s += `</select>`;
    return s;
}

function createFormularbyId(formularbyid) {
    let s = `<div class="container">
        <table class="table table-striped table-bordered table-hover table-condensed">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Formularfragen</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>FormularID</td>
                    <td>${formularbyid.teacherId}</td>
                </tr>
                <tr>
                    <td>Überschrift</td>
                    <td>${formularbyid.heading}</td>
                </tr>
                <tr>
                    <td>Frage 1</td>
                    <td>${formularbyid.q1}</td>
                </tr>
                <tr>
                    <td>Frage 2</td>
                    <td>${formularbyid.q2}</td>
                </tr>
                <tr>
                    <td>Frage 3</td>
                    <td>${formularbyid.q3}</td>
                </tr>
                <tr>
                    <td>Frage 4</td>
                    <td>${formularbyid.q4}</td>
                </tr>
                <tr>
                    <td>Frage 5</td>
                    <td>${formularbyid.q5}</td>
                </tr>
                <tr>
                    <td>Frage 6</td>
                    <td>${formularbyid.q6}</td>
                </tr>
                <tr>
                    <td>Frage 7</td>
                    <td>${formularbyid.q7}</td>
                </tr>
                <tr>
                    <td>Frage 8</td>
                    <td>${formularbyid.q8}</td>
                </tr>
                <tr>
                    <td>Anmerkung</td>
                    <td>${formularbyid.annotion}</td>
                </tr>
            </tbody>
        </table>
    </div>`;
    return s;
}

function createFormular(formular) {
    f = formular;
    i = 1;
    let s = `<div class="container">
        <table class="table table-striped table-bordered table-hover table-condensed">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Formularfragen</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>FormularID</td>
                    <td>${formular[i - 1].teacherId}</td>
                </tr>
                <tr>
                    <td>Überschrift</td>
                    <td>${formular[i - 1].heading}</td>
                </tr>
                <tr>
                    <td>Frage 1</td>
                    <td>${formular[i - 1].q1}</td>
                </tr>
                <tr>
                    <td>Frage 2</td>
                    <td>${formular[i - 1].q2}</td>
                </tr>
                <tr>
                    <td>Frage 3</td>
                    <td>${formular[i - 1].q3}</td>
                </tr>
                <tr>
                    <td>Frage 4</td>
                    <td>${formular[i - 1].q4}</td>
                </tr>
                <tr>
                    <td>Frage 5</td>
                    <td>${formular[i - 1].q5}</td>
                </tr>
                <tr>
                    <td>Frage 6</td>
                    <td>${formular[i - 1].q6}</td>
                </tr>
                <tr>
                    <td>Frage 7</td>
                    <td>${formular[i - 1].q7}</td>
                </tr>
                <tr>
                    <td>Frage 8</td>
                    <td>${formular[i - 1].q8}</td>
                </tr>
                <tr>
                    <td>Anmerkung</td>
                    <td>${formular[i - 1].annotion}</td>
                </tr>
            </tbody>
        </table>
    </div>`;
    return s;
}

function createFormular2() {
    i = i + 1;
    if (i <= 5) {
        let s = `<div class="container">
            <table class="table table-striped table-bordered table-hover table-condensed">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Formularfragen</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>FormularID</td>
                        <td>${f[i - 1].teacherId}</td>
                    </tr>
                    <tr>
                        <td>Überschrift</td>
                        <td>${f[i - 1].heading}</td>
                    </tr>
                    <tr>
                        <td>Frage 1</td>
                        <td>${f[i - 1].q1}</td>
                    </tr>
                    <tr>
                        <td>Frage 2</td>
                        <td>${f[i - 1].q2}</td>
                    </tr>
                    <tr>
                        <td>Frage 3</td>
                        <td>${f[i - 1].q3}</td>
                    </tr>
                    <tr>
                        <td>Frage 4</td>
                        <td>${f[i - 1].q4}</td>
                    </tr>
                    <tr>
                        <td>Frage 5</td>
                        <td>${f[i - 1].q5}</td>
                    </tr>
                    <tr>
                        <td>Frage 6</td>
                        <td>${f[i - 1].q6}</td>
                    </tr>
                    <tr>
                        <td>Frage 7</td>
                        <td>${f[i - 1].q7}</td>
                    </tr>
                    <tr>
                        <td>Frage 8</td>
                        <td>${f[i - 1].q8}</td>
                    </tr>
                    <tr>
                        <td>Anmerkung</td>
                        <td>${f[i - 1].annotion}</td>
                    </tr>
                </tbody>
            </table>
        </div>`;
        return s;
    } else {
        i = 6;
        let d = `<h5 style="position: relative; top: 133px">alle verfügbaren Standardformulare</h5><br />
        <h5 style="position: relative; top: 133px">Individuelle Formulare müssen mit ID gesucht werden!</h5>`;
        return d;
    }
}

function createFormular3() {
    i = i - 1;
    if (i >= 1) {
        let s = `<div class="container">
            <table class="table table-striped table-bordered table-hover table-condensed">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Formularfragen</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>FormularID</td>
                        <td>${f[i - 1].teacherId}</td>
                    </tr>
                    <tr>
                        <td>Überschrift</td>
                        <td>${f[i - 1].heading}</td>
                    </tr>
                    <tr>
                        <td>Frage 1</td>
                        <td>${f[i - 1].q1}</td>
                    </tr>
                    <tr>
                        <td>Frage 2</td>
                        <td>${f[i - 1].q2}</td>
                    </tr>
                    <tr>
                        <td>Frage 3</td>
                        <td>${f[i - 1].q3}</td>
                    </tr>
                    <tr>
                        <td>Frage 4</td>
                        <td>${f[i - 1].q4}</td>
                    </tr>
                    <tr>
                        <td>Frage 5</td>
                        <td>${f[i - 1].q5}</td>
                    </tr>
                    <tr>
                        <td>Frage 6</td>
                        <td>${f[i - 1].q6}</td>
                    </tr>
                    <tr>
                        <td>Frage 7</td>
                        <td>${f[i - 1].q7}</td>
                    </tr>
                    <tr>
                        <td>Frage 8</td>
                        <td>${f[i - 1].q8}</td>
                    </tr>
                    <tr>
                        <td>Anmerkung</td>
                        <td>${f[i - 1].annotion}</td>
                    </tr>
                </tbody>
            </table>
        </div>`;
        return s;
    } else {
        i = 0;
        let d = `<h5 style="position: relative; top: 133px">Hier werden die Formulare angezeigt</h5>`;
        return d;
    }
}