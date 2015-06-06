/**
 * Created by Kaloyan on 1.6.2015 ã..
 */
console.log('============');
console.log('Exercise 4: Lexicographically smallest');

var propDocument;
var propWindow;
var propNavigator;
var orderDocument = [];
var orderWindow = [];
var orderNavigator = [];

for (propDocument in document) {
    orderDocument.push(propDocument);
}
orderDocument.sort();

for (propWindow in window) {
    orderWindow.push(propWindow);
}
orderWindow.sort();

for (propNavigator in navigator) {
    orderNavigator.push(propNavigator);
}
orderNavigator.sort();

console.log('For document smallest property is: ' + orderDocument[0] + ' and largest is: ' + orderDocument[orderDocument.length - 1]);
console.log('For window smallest property is: ' + orderWindow[0] + ' and largest is: ' + orderWindow[orderWindow.length - 1]);
console.log('For navigator smallest property is: ' + orderNavigator[0] + ' and largest is: ' + orderNavigator[orderNavigator.length - 1]);