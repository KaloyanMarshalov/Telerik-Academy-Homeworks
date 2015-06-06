/**
 * Created by Kaloyan on 3.6.2015 ã..
 */
console.log('============');
console.log('Exercise 2: Lexicographical comparison');

var firstArr = ['a', 'b', 'c'],
    secondArr = ['d', 'b', 'a'],
    i,
    k;

if (firstArr.length == secondArr.length)
{
    for (i = 0, k = firstArr.length; i < k; i++)
    {
        if (firstArr[i] === secondArr[i])
        {
            console.log(firstArr[i] + '===' + secondArr[i]);
        }
        else
        {
            console.log(firstArr[i] + '!==' + secondArr[i]);
        }
    }
}
else
{
    console.log('The arrays have different lengths');
    console.log('Length of array one: ' + firstArr.length);
    console.log('Length of array two: ' + secondArr.length);
}