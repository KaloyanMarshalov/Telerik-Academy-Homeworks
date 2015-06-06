/**
 * Created by Kaloyan on 6.6.2015 ã..
 */
console.log('============');
console.log('Exercise 3: Occurrences of Word');

function countOccurrences(text, word, isCaseSensitive){
    var regexString = '\\b' + word + '\\b',
        modifier = isCaseSensitive ? 'g' : 'gi',
        regex = new RegExp(regexString, modifier);

    return text.match(regex).length;
}

console.log(countOccurrences('asdd ds Ds a a sd ds', 'ds'));
console.log(countOccurrences('asdd ds Ds a a sd ds', 'ds', true));