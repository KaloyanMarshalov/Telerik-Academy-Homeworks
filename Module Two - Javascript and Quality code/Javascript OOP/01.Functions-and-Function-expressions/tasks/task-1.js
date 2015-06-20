/* Task Description */
/*
    Write a function that sums an array of numbers:
        numbers must be always of type Number
        returns `null` if the array is empty
        throws Error if the parameter is not passed (undefined)
        throws if any of the elements is not convertible to Number

*/

function sum(arrayOfNumbers) {
    var sumofNums = 0,
        i,
        l;

    if (!arrayOfNumbers) {
        throw new Error('no arguments');
    }
    if (arrayOfNumbers.length === 0) {
        return null;
    }

    for (i = 0, l = arrayOfNumbers.length; i < l; i += 1) {
        if (isNaN(arrayOfNumbers[i])) {
            throw new Error('Not a number');
        }

        sumofNums += parseInt(arrayOfNumbers[i]);
    }

    return sumofNums;
}

module.exports = sum;
