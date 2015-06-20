/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(beginning, end) {
    var result = [],
        i,
		start = parseInt(beginning),
		finish = parseInt(end);

    if (isNaN(beginning) || isNaN(end)) {
        throw new Error('nan parameter');
    }
    if (beginning === 'undefined' || end === 'undefined') {
        throw new Error('bad parameters');
    }

    for (i = start; i <= finish; i++) {
        if (isPrime((i))) {
            result.push(i);
        }
    }

    function isPrime(num) {
        var i = 2;
        if (num === 1 || num === 0) {
            return false;
        }

        if (num === 2) {
            return true;
        }

        while (i <= Math.sqrt(num)) {
            if (num % i === 0) {
                return false;
            }

            i += 1;
        }

        return true;
    }
    return result;
}

module.exports = findPrimes;
