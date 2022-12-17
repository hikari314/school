function correction() {
    var points=0;
    if(document.test.q1[2].checked){
        points = points + 2
    }

    if(document.test.q2[4].checked){
        points = points + 2
    }

    if(document.test.q3[0].checked){
        points = points + 2
    }

    if(document.test.q4[1].checked){
        points = points + 2
    }

    if(document.test.q5[3].checked){
        points = points + 2
    }

    let grades;
    if(points<5) {
        grades = "I";
    }else if(points<=6){
        grades ="R";
    }else if(points<=8){
        grades = "B";
    }else{
        grades = "MB";
    }

    document.getElementById("result").innerHTML="<b>Your score is</b>" + points + "and your grade is" + grades;
}
