/**
 * Created by Kaloyan on 11.6.2015 ã..
 */
function solve(params) {
    var arr = params[0].split(' '),
        result = 0,
        currentResult = 0,
        downhill = true;

    for (var i =0, k = arr.length; i < k - 1; i++) { //dont interate the last one and the first one it is a peak
        var currentNum = parseInt(arr[i]);
        var nextNum = parseInt(arr[i + 1]);

        if (currentNum > nextNum && downhill == false) {
            currentResult = 1;
            downhill = true;
        }
        else if (currentNum > nextNum) {
            currentResult += 1;
        }
        else if (currentNum < nextNum) {
            downhill = false;
            currentResult += 1;
        }

        if (currentResult > result) {
            result = currentResult;
        }
    }


    // Your solution here
    console.log(result);
}

solve('5 1 7 4 8');
solve('5 1 7 6 3 6 4 2 3 8');
solve('10 1 2 3 4 5 4 3 2 1 10');