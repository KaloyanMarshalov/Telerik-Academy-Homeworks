/**
 * Created by Kaloyan on 7.6.2015 ã..
 */
console.log('============');
console.log('Exercise 3: Sub-string in text');

function countOccurences(string, word) {
    var regex = new RegExp(word, 'gi');
    return string.match(regex).length;
}
var text = 'We are living in a yellow submarine. We don\'t have anything else. Inside the submarine is very tight. So we are drinking all day. We will move out of it in 5 days.';

console.log(countOccurences(text, 'in'));
