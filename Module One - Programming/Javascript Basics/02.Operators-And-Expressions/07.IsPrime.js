/**
 * Created by Kaloyan on 23.5.2015 ã..
 */
console.log('===========');
console.log('Exercise 7: Is Prime');

var numArray = [1,2,3,4,9,37,97,51,-3,0];

for (var i = 0; i < numArray.length; i++) {
    console.log(numArray[i] + ': ' + CheckIfPrime(numArray[i]));
}

function CheckIfPrime(number) {
    if(number > 100) {
        throw "number is larger than 100";
    }
    if(number == 1 || number <= 0){
        return false;
    }
    else {
        for(var i = 2; i < number; i++){
            if(number % i == 0) {
                return false;
            }
        }
        return true;
    }
}