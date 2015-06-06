/**
 * Created by Kaloyan on 7.6.2015 ã..
 */
console.log('============');
console.log('Exercise 10: Find palindromes');

function extractPalindromes(text) {
    var palindromes = [];

    var currentWord = '';
    var regex = /\b\w+\b/g;

    while (currentWord = regex.exec(text)) { /* regex-exec -> Gets matches one-by-one*/
        if (isPalindrome(currentWord[0])) {
            palindromes.push(currentWord[0]);
        }
    }

    return palindromes;
}

function isPalindrome(word) {
    for (var i = 0; i < word.length / 2; i++) {
        if (word.charAt(i) != word.charAt(word.length - i - 1)) {
            return false;
        }
    }

    return true;
}

var text = 'samoe ABBA LAMAL sadd  das asa and i llooll.';
console.log(extractPalindromes(text));
