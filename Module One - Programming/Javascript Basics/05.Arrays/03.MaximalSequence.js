/**
 * Created by Kaloyan on 3.6.2015 ã..
 */
console.log('============');
console.log('Exercise 3: Maximal sequence');

var numArray = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
    k,
    i,
    bestSequence = 1,
    bestElement = numArray[0],
    currSequence = 1,
    result = '';

for (i = 1, k = numArray.length; i < k; i++)
{
    if (numArray[i-1] === numArray[i])
    {
        currSequence++;
    }
    else
    {
        currSequence = 1;
    }

    if (currSequence >= bestSequence)   //the sign must be >= so that the last max sequence is the best
    {
        bestSequence = currSequence;
        bestElement = numArray[i];
    }
}

for (i = 0; i < bestSequence; i++)
{
    if (i == bestSequence-1)
    {
        result += bestElement;
    }
    else
    {
        result += bestElement + ', ';
    }
}
console.log(result);
