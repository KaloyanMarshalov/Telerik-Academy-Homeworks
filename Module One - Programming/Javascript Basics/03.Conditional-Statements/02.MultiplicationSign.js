/**
 * Created by Kaloyan on 24.5.2015 ã..
 */
console.log('============');
console.log('Exercise 2: Multiplication sign');

var firstNum = 5;
var secondNum = 2;
var thirdNum = 2;

if (firstNum < 0 && secondNum > 0 && thirdNum > 0) {
    console.log('-');
} 
else if (firstNum > 0 && secondNum < 0 && thirdNum > 0) {
    console.log('-');
}
else if (firstNum > 0 && secondNum > 0 && thirdNum < 0) {
    console.log('-');
}
else if (firstNum < 0 && secondNum <0 && thirdNum < 0) {
    console.log('-');
}
else if (firstNum == 0 || secondNum ==0 || thirdNum == 0) {
    console.log('0');
}
else {
    console.log('+');
}