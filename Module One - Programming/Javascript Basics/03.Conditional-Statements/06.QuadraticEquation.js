console.log('============');
console.log('Exercise 6: Quadratic equation');

var aCoeff = 3;
var bCoeff = 7;
var cCoeff = 1;
var D = bCoeff * bCoeff - (4 * aCoeff * cCoeff);
if (D > 0) {
    var root1 = (-bCoeff + Math.sqrt(D)) / (2 * aCoeff);
    var root2 = (-bCoeff - Math.sqrt(D)) / (2 * aCoeff);
    console.log('Root 1 is: ' + root1 + ', and root 2 is:' + root2 + '  (D > 0)');
}
else if (D < 0) {
    console.log('This equation has no real roots (D < 0)');
}
else {
    var root3 = -bCoeff / 2 * aCoeff;
    console.log('The Root is: ' + root3 + '  (D = 0)');
}

