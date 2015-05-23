/**
 * Created by Kaloyan on 23.5.2015 ã..
 */
console.log('===========');
console.log('Exercise 9: Point inside Circle and outside Rectangle');

var points = [
    {x: 1, y: 2},
    {x: 2.5, y: 2},
    {x: 0, y: 1},
    {x: 2.5, y: 1},
    {x: 2, y: 0},
    {x: 4, y: 0},
    {x: 2.5, y: 1.5},
    {x: 2, y: 1.5},
    {x: 1, y: 2.5},
    {x: -100, y: -100}
];

for (var i = 0; i < points.length; i++) {
    var x = points[i].x;
    var y = points[i].y;

    var inCicle = (x - 1) * (x - 1) + (y - 1) * (y - 1) < 3 * 3;
    var outsideRectangle = !(x >= -1 && x <= 5 && y <= 1 && y >= -1);

    if (inCicle && outsideRectangle) {
        console.log('{' + x + '; ' + y + '} - YES');
    }
    else {
        console.log('{' + x + '; ' + y + '} - NO');
    }
}
