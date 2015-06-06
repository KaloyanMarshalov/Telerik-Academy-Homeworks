/**
 * Created by Kaloyan on 4.6.2015 ã..
 */
console.log('============');
console.log('Exercise 7: BinarySearch');

var numArray = [1,4,1,2,9,7,8,8,32,1,23,4,5,7,8,9],
    element = 23,
    minI = 0,
    maxI = numArray.length- 1,
    midI = 0;

numArray.sort(function(a, b){return a-b});

while (maxI >= minI)
{
    midI = parseInt((minI + maxI) / 2);
    if (numArray[midI] == element)
    {
        console.log(midI);
        break;
    }
    else if (numArray[midI] < element)
    {
        minI = midI + 1;
    }
    else
    {
        maxI = midI - 1;
    }
}
