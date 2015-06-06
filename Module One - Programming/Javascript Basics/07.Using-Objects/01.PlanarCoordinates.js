/**
 * Created by Kaloyan on 6.6.2015 ã..
 */
console.log('============');
console.log('Exercise 1: Planar Coordinates');

function calculatePointsDistance(x1, y1, x2, y2) {
    return Math.sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
}

function canFormTriangle(x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6) {
    var line1 = calculatePointsDistance(x1, y1, x2, y2);
    var line2 = calculatePointsDistance(x3, y3, x4, y4);
    var line3 = calculatePointsDistance(x5, y5, x6, y6);

    return (line1 + line2 > line3 && line2 + line3 > line1 && line1 + line3 > line2);
}

console.log(canFormTriangle(2,3,5,6,5,6,7,4,7,4,2,3));
