/**
 * Created by Kaloyan on 7.6.2015 ã..
 */
console.log('============');
console.log('Exercise 5: nbsp');

var text = "Some of  the spaces   are not  needed  in this       text.";
var newSubstring = "&nbsp;";

console.log(text);
var result = text.replace(/ /g, newSubstring);
console.log(result);