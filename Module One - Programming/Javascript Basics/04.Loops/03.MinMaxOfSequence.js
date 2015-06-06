/**
 * Created by Kaloyan on 1.6.2015 ã..
 */
console.log('============');
console.log('Exercise 3: Min/Max of a sequence');

var arr = [1, 2, 3, 14, 77, 1233, -2, -5, -66, 2, 0.15, 0.25, 66.7, -23.5, 4, 0, 1];
console.log('Array is: ' + arr);
console.log('Min number is: ' + Math.min.apply(arr, arr) + '. Max number is: ' + Math.max.apply(arr, arr));
