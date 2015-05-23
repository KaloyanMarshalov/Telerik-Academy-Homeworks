/**
 * Created by Kaloyan on 23.5.2015 ã..
 */
console.log('===========');
console.log('Exercise 4: Third Digit is 7');

var numArray = [5, 701, 1732, 9703, 877, 777877, 9999799];

for(var i = 0; i < numArray.length; i++){
    var number = numArray[i];
    var isSeven = number % 1000 >= 700 && number % 1000 <= 799;

    console.log(number + ': ' + isSeven);
}