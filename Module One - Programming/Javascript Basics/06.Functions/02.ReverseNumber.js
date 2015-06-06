/**
 * Created by Kaloyan on 6.6.2015 ã..
 */
console.log('============');
console.log('Exercise 2: Reverse number');

function reverseNumber(number) {
    var stringNumber = number + '',
        stringArr = [];

    stringArr = stringNumber.split('');
    stringArr.reverse();
    return stringArr.join('');
}

console.log(reverseNumber(123456789));
