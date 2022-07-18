// exercise 1
let salaries = {John: 100,Ann: 160,Pete: 130}
let sum = salaries.John + salaries.Ann + salaries.Pete;
console.log(sum)

// exercise 2
function multiplyNumeric(obj) {
    for (let el in obj) {
        if (typeof obj[el] == "number" ) {
            obj[el] *= 2
        }
    }
}

let menu = {width: 200,height: 300,title: "My menu"};
multiplyNumeric(menu);
console.log(menu)

// exercise 3
function checkEmailId(str){
    var mailFormat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    if (str.value.match(mailFormat)){
        alert("Valid Email Address!");
        document.myForm.inputEmail.focus();
        return true;
    }
    else {
        alert("You have entered an invalid Email Address!");
        document.myForm.inputEmail.focus();
        return false;
    }
}

// exercise 4
function truncate(str, maxlength) {
    if (str.length > maxlength) {
        return str.slice(0, maxlength - 1);
    } else {
        return str;
    }
}

// exercise 5
const nameArray = ["James", "Brennie"];
console.log(nameArray);
// append "Robert"
nameArray.push("Robert");
console.log(nameArray);
// replace
nameArray[1] = "Calvin";
console.log(nameArray);
// remove
nameArray.shift();
console.log(nameArray);
// prepend
nameArray.unshift("Rose", "Regal");
console.log(nameArray);