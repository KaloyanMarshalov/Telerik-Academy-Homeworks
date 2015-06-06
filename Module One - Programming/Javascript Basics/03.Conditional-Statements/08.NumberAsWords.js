console.log('============');
console.log('Exercise 8: Number as words');


var number = 666,
    numberAsString,
    count,
    firstDigit,
    secondDigit,
    thirdDigit,
    line;

function getDigit(digit) {
    switch (digit) {
        case 0: return "zero";
        case 1: return "one";
        case 2: return "two";
        case 3: return "three";
        case 4: return "four";
        case 5: return "five";
        case 6: return "six";
        case 7: return "seven";
        case 8: return "eight";
        case 9: return "nine";
    }
}

function getTenths(digit) {
    switch (digit) {
        case 2: return "twenty";
        case 3: return "thirty";
        case 4: return "fourty";
        case 5: return "fifty";
        case 6: return "sixty";
        case 7: return "seventy";
        case 8: return "eighty";
        case 9: return "ninety";
    }
}

function getTeens(teens) {
    switch (teens) {
        case 10: return "ten";
        case 11: return "eleven";
        case 12: return "twelve";
        case 13: return "thirteen";
        case 14: return "fourteen";
        case 15: return "fifteen";
        case 16: return "sixteen";
        case 17: return "seventeen";
        case 18: return "eighteen";
        case 19: return "nineteen";
    }
}

numberAsString = number.toString();
count = numberAsString.length;

if (count === 1) {
    console.log(getDigit(number));
} else if (count === 2) {
    if (number > 19) {
        firstDigit = parseInt(numberAsString[0]);
        secondDigit = parseInt(numberAsString[1]);
        secondDigit !== 0 ? console.log(getTenths(firstDigit), getDigit(secondDigit)) : console.log(getTenths(firstDigit));
    } else {
        console.log(getTeens(number));
    }
} else if (count === 3) {
    firstDigit = parseInt(numberAsString[0]);
    secondDigit = parseInt(numberAsString[1]);
    thirdDigit = parseInt(numberAsString[2]);
    line = getDigit(firstDigit) + " " + "hundred";
    if (secondDigit === 0 && thirdDigit !== 0) {
        line += " " + "and" + " " + getDigit(thirdDigit);
    } else if (secondDigit !== 0) {
        if (secondDigit > 1) {
            line += " " + "and" + " " + getTenths(secondDigit);
            if (thirdDigit !== 0) {
                line += " " + getDigit(thirdDigit);
            }
        } else {
            line += " " + "and" + " " + getTeens(parseInt(numberAsString[1] + numberAsString[2]));
        }

    }

    console.log(line);
}
