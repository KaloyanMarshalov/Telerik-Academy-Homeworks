console.log('============');
console.log('Exercise 4: Sorting 3 numbers');

var fstNum = 6;
var sndNum = 2;
var trdNum = 3;
if (fstNum > sndNum) {
    if (fstNum > trdNum) {
        if (sndNum > trdNum) {
            console.log('The descending order is: ' + fstNum + '>' + sndNum + '>' + trdNum);
        }
        else {
            console.log('The descending order is: ' + fstNum + '>' + trdNum + '>' + sndNum);
        }
    }
    else {
        console.log('The descending order is: ' + trdNum + '>' + fstNum + '>' + sndNum);
    }
}
else {
    if (sndNum > trdNum) {
        if (trdNum > fstNum) {
            console.log('The descending order is: ' + sndNum + '>' + trdNum + '>' + fstNum);
        }
        else {
            console.log('The descending order is: ' + sndNum + '>' + fstNum + '>' + trdNum);
        }
    }
    else {
        console.log('The descending order is: ' + trdNum + '>' + sndNum + '>' + fstNum);
    }
}