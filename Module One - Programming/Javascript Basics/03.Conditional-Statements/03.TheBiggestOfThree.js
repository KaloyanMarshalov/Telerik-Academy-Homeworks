console.log('============');
console.log('Exercise 3: The biggest of three');

var fstNum = 3;
var sndNum = 5;
var trdNum = 8;
if (fstNum > sndNum) {
    if (fstNum > trdNum) {
        console.log('The first number: ' + fstNum + ' is the biggest');
    }
    else {
        console.log('The third number: ' + trdNum + ' is the biggest');
    }
}
else {
    if (sndNum > trdNum) {
        console.log('The second number: ' + sndNum + ' is the biggest');
    }
    else {
        console.log('The third number: ' + trdNum + ' is the biggest');
    }
}