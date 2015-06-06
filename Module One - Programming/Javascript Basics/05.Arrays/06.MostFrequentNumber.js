/**
 * Created by Kaloyan on 4.6.2015 ã..
 */
console.log('============');
console.log('Exercise 6: Most frequent Number');



var numArray = [1,2,3,4,5,3,3,3,3,2,1,2,4,3,5],
    maxLength = 0,
    element = numArray[0],
    currentLength,
    i,
    k;
for (i = 0, k = numArray.length; i < k; i++) {
    currentLength = 0;
    for (var j = 0; j < numArray.length; j++) {
        if (numArray[i] === numArray[j]) {
            currentLength++;
        }
    }

    if (currentLength > maxLength) {
        maxLength = currentLength;
        element = numArray[i];
    }
}

console.log('Most frequent number: ' + element);
