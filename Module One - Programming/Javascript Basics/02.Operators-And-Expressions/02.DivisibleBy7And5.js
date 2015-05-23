/**
 * Created by Kaloyan on 23.5.2015 ã..
 */
console.log('===========');
console.log('Exercise 2: Divisible by 7 and 5');
var divisableArr = [3, 0, 5, 7, 35, 140];
for(var i = 0; i < divisableArr.length; i++) {
    var number = divisableArr[i];
    var divisible = number%5 == 0 && number%7 == 0;
    console.log(number + ': ' + divisible);
}
