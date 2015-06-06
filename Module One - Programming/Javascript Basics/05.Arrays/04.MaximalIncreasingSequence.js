/**
 * Created by Kaloyan on 3.6.2015 ã..
 */
console.log('============');
console.log('Exercise 4: Maximal increasing sequence');

var numArray = [3, 2, 3, 4, 2, 2, 4],
    bestSequence = 1,
    bestStart = numArray[0],
    currSequence = 1,
    i,
    k,
    result = '';

for (i = 1, k = numArray.length; i < k; i++)
{
    if (numArray[i-1] + 1 == numArray[i])
    {
        currSequence++;
    }
    else
    {
        currSequence = 1;
    }

    if (currSequence >= bestSequence)
    {
        bestSequence = currSequence;
        bestStart = numArray[i - bestSequence + 1];
    }
}

for (i = 0; i < bestSequence; i++)
{
    if (i == bestSequence -1)
    {
        result += bestStart+i;
        console.log(result);
    }
    else
    {
        result += bestStart+i + ', ';
    }
}