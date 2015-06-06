/**
 * Created by Kaloyan on 6.6.2015 ã..
 */
console.log('============');
console.log('Exercise 5: Youngest person');

function findYoungest(peopleArr) {
    var youngestPerson = peopleArr[0],
        i,
        k;
    for (i = 1, k = peopleArr.length; i < k; i++) {
        if (peopleArr[i].age < youngestPerson.age) {
            youngestPerson = peopleArr[i];
        }
    }
    console.log(youngestPerson.fname + ' ' + youngestPerson.lname);
}

var people = [
    {fname: 'Ivan', lname: 'Hasanov', age: 12},
    {fname: 'Petrur', lname: 'Petrov', age: 20},
    {fname: 'Hristo', lname: 'Hristov', age: 22},
    {fname: 'Ivan', lname: 'Ivanov', age: 4},
    {fname: 'Zlatan', lname: 'Georgiev', age: 55}
];

findYoungest(people);
