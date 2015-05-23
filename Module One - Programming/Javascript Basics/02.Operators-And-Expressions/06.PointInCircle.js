/**
 * Created by Kaloyan on 23.5.2015 ã..
 */
console.log('===========');
console.log('Exercise 6: Point Inside Circle');

var points = [
    {x: 0, y: 1},
    {x: -5, y: 0},
    {x: -4, y: 5},
    {x: 1.5, y: -3},
    {x: -4, y: -3.5},
    {x: 100, y: -30},
    {x: 0, y: 0},
    {x: 0.2, y: -0.8},
    {x: 0.9, y: -4.93},
    {x: 2, y: -2.655}
]

for(var i = 0; i < points.length; i++) {
    var point = points[i];
    //x^2 + y^2 = r^2
    var isInside = point.x * point.x + point.y * point.y <= 25;
    console.log('Point' + i + ' {' + point.x + '; ' + point.y + '}: ' + isInside);
}
