/**
 * Created by Kaloyan on 6.6.2015 ã..
 */
console.log('============');
console.log('Exercise 6: Larger than neighbours');

function checkIfLarger(arr, pos) {
    if (pos <= 0 || pos >= arr.length - 1) {
        alert("Invalid position");
    }
    else {
        if (arr[pos] > arr[pos - 1] && arr[pos] > arr[pos + 1]) {
            return(true);
        }
        else {
            return(false);
        }
    }
}

console.log(checkIfLarger([1,2,3,1,1,2,3,4,1,2,3,5], 2));
