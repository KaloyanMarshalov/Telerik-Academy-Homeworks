/**
 * Created by Kaloyan on 1.6.2015 ã..
 */
console.log('============');
console.log('Exercise 2: Numbers not divisible');

var N = 23;
if (N > 1) {
    for (var number = 1; number <= N; number++) {
        if (number % 21 != 0) {
            console.log(number);
        }
    }
}
else {
    alert('This number is smaller or equal to 1')
}
