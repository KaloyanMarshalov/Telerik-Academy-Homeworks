/**
 * Created by Kaloyan on 7.6.2015 ã..
 */
console.log('============');
console.log('Exercise 2: Correct brackets');

function bracketCheck(expression) {
    var bracketCount = 0;

    for (var i = 0, j = expression.length; i < j; i++) {
        if (expression[i] == '(') {
            bracketCount++;
        }
        else if (expression[i] == ')') {
            bracketCount--;
        }

        if (bracketCount < 0) {
            return false;
        }
    }

    return bracketCount === 0;
}

var expression = '((a+b)/5-d)';
console.log(bracketCheck(expression));

console.log(bracketCheck(')(a+b))'));

