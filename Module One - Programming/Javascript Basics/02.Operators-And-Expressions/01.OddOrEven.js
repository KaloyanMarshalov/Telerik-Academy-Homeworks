/**
 * Created by Kaloyan on 23.5.2015 ã..
 */
console.log('===========');
console.log('Exercise 1: Odd or even')
var numArray = [3, 2, -2, -1, 0];

for(var i = 0; i < numArray.length; i++){
    var oddOrEven = numArray[i] % 2 == 0;
    console.log(numArray[i] + ': ' + oddOrEven);
}
