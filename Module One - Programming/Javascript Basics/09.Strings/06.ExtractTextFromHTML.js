/**
 * Created by Kaloyan on 7.6.2015 ã..
 */
console.log('============');
console.log('Exercise 6: Extract text from HTML');

var input = "<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>;";
var result = input.replace(/<(.*?)>/g, '');

console.log(result);

