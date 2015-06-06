/**
 * Created by Kaloyan on 4.6.2015 ã..
 */
console.log('============');
console.log('Exercise 5: Selection Sort');

var numArray = [1,2,3,7,1,0,9,-3,14,15,15,6],
    temp, 
    minIndex,
    i,
    k;

console.log(numArray);

for (i = 0, k = numArray.length-1; i < k; i++)
{
    minIndex = i;
    for (var j = i+1; j < numArray.length; j++)
    {
        if (numArray[j] < numArray[minIndex])
        {
            minIndex = j;
        }
    }
    if (minIndex != i)
    {
        temp = numArray[i];
        numArray[i] = numArray[minIndex];
        numArray[minIndex] = temp;
    }
}

console.log(numArray);
