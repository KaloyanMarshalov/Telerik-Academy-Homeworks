console.log('============');
console.log('Exercise 7: The Biggest of five');

var fstNum = 7;
var sndNum = 8;
var trdNum = 2;
var fthNum = 3;
var fifthNum = 2;

if (fstNum > sndNum && fstNum > trdNum && fstNum > fthNum && fstNum > fifthNum) {
    console.log('The first number: ' + fstNum + ' is the biggest');
}
else if (sndNum > fstNum && sndNum > trdNum && sndNum > fthNum && sndNum > fifthNum) {
    console.log('The second number: ' + sndNum + ' is the biggest');
}
else if (trdNum > fstNum && trdNum > sndNum && trdNum > fthNum && trdNum > fifthNum) {
    console.log('The third number: ' + trdNum + ' is the biggest');
}
else if (fthNum > fstNum && fthNum > sndNum && fthNum > trdNum && fthNum > fifthNum) {
    console.log('The fourth number: ' + fthNum + ' is the biggest');
}
else {
    console.log('The Fifth number: ' + fifthNum + ' is the biggest');
}
