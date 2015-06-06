/**
 * Created by Kaloyan on 6.6.2015 ã..
 */
console.log('============');
console.log('Exercise 5: Appearance Count');

function appearanceCount(numArray, num) {
    var count = 0

    for (var i = 0; i < numArray.length; i++) {
        if (numArray[i] === num) {
            count+=1;
        }
    }

    return count;
}

console.log(appearanceCount([1,2,3,1,1,1,23,4,1,2,3,2], 1));

