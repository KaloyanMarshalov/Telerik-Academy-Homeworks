/**
 * Created by Kaloyan on 1.6.2015 ã..
 */
console.log('============');
console.log('Exercise 1: Numbers 1 to N');

var N = 7;
var number = 1;
if (N > 1) {
    while (number <= N) {
        console.log(number);
        number++;
    }
}
else {
    console.log('This number is smaller or equal to 1')
}