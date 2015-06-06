/**
 * Created by Kaloyan on 6.6.2015 ã..
 */
console.log('============');
console.log('Exercise 7: First larger than neighbours');

function findFirstLarger(arr) {
    var isFound = false;
    
    for (var i = 1; i < arr.length - 1; i++) {
        if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) {
            isFound = true;
            return i;
        }
    }

    if (!isFound) {
        return -1;
    }
}

console.log(findFirstLarger([1, 2, 3, 1, 2, 3, 4, 1, 2, 5]));
console.log(findFirstLarger([1,2,2,2,3]));
