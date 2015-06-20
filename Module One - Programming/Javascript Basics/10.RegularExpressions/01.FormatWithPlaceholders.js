/**
 * Created by Kaloyan on 10.6.2015 �..
 */
console.log('============');
console.log('Exercise 1: Format with placeholders');

String.prototype.format = function (options) {
    return this.replace(/(?:#{(\w+)})/g, function ($0, $1) {
        return options[$1];
    });
};

var options1 = {name: 'John'};
console.log('Hello, there! Are you #{name}?'.format(options1));

var options2 = {name: 'John', age: 13};
console.log('My name is #{name} and I am #{age}-years-old'.format(options2));