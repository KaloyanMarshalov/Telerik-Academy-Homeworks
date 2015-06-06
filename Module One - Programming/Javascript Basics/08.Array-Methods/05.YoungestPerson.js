/**
 * Created by Kaloyan on 6.6.2015 ã..
 */
console.log('============');
console.log('Exercise 5: Youngest Person');

function printYoungestPersonFullname(arr) {
    var minAge = arr[0].age;
    arr.forEach(function (element) {
        if (minAge > element.age) {
            minAge = element.age;
        }
    });

    var youngestPerson = arr.filter(function (item) {
        if (item.age === minAge) {
            return item;
        }
    });

    return youngestPerson[0].firstName + ' ' + youngestPerson[0].lastName;
}
console.log(printYoungestPersonFullname(peopleArr));

