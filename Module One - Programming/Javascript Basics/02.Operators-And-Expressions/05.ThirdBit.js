/**
 * Created by Kaloyan on 23.5.2015 ã..
 */

console.log('===========');
console.log('Exercise 5: Third Bit');

var numArray = [5, 8, 0, 15, 5343, 62241];

for(var i = 0; i < numArray.length; i++){
    var number = numArray[i];
    var thirdBit = number >> 3 & 1;
    console.log(number + ': ' + thirdBit);
}