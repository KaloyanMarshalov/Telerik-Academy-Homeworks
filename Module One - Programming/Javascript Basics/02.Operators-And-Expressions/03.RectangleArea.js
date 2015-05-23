/**
 * Created by Kaloyan on 23.5.2015 ã..
 */
console.log('===========');
console.log('Exercise 3: Rectangle Area');
var trianglesArr = [
    {width: 3, height: 4},
    {width: 2.5, height: 3},
    {width: 5, height: 5}
];

for(var i = 0; i < trianglesArr.length; i++){
    var triangle = trianglesArr[i];
    console.log('Rectangle ' + i + ': width: ' + triangle.width + '; height: ' + triangle.height);
    console.log('Area: ' + triangle.width * triangle.height);
}
