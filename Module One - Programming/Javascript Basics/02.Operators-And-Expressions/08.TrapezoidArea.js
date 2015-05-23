/**
 * Created by Kaloyan on 23.5.2015 ã..
 */
console.log('===========');
console.log('Exercise 8: Trapezoid Area');
var trapezoids = [
    {a: 5, b: 7, h: 12},
    {a: 2, b: 1, h: 33},
    {a: 8.5, b: 4.3, h: 2.7},
    {a: 100, b: 200, h: 300},
    {a: 0.222, b: 0.333, h: 0.555}
];

for (var i = 0; i< trapezoids.length; i++){
    var trapezoid = trapezoids[i];
    var area = (trapezoid.a + trapezoid.b) * trapezoid.h / 2;

    console.log('Trapezoid ' + i + ' {' + trapezoid.a + '; ' + trapezoid.b + '; ' + trapezoid.h + '}: ' + area);
}