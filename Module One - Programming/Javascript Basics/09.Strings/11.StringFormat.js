/**
 * Created by Kaloyan on 7.6.2015 ã..
 */
console.log('============');
console.log('Exercise 11: String format');

function stringFormat(str) {
    var selfArguments = arguments;

    return str.replace(/\{(\d+)}/g, function (match, arg) {
        return selfArguments[+arg + 1];
    });
}
var str = stringFormat('Hello {0}!', 'Peter');
console.log(stringFormat(str));

var frmt = '{0}, {1}, {0} text {2}';
var str2 = stringFormat(frmt, 1, 'Pesho', 'Gosho');
console.log(stringFormat(str2));

