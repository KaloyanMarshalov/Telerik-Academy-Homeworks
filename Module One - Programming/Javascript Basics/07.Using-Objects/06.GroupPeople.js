/**
 * Created by Kaloyan on 6.6.2015 ã..
 */
console.log('============');
console.log('Exercise 6: Group people');

function group(arrPersons, key) {
    if (arrPersons.length===0) {
        return undefined;
    }
    var result = {};
    for (var prop in arrPersons[0]) {
        if (prop === key) {
            for (var i = 0; i < arrPersons.length; i++) {
                if (!result[arrPersons[i][key]]) {
                    result[arrPersons[i][key]] = [];
                }
                result[arrPersons[i][key]].push(arrPersons[i]);
            }
        }
    }
    return result;
}

var people = [
    {fname: 'Ivan', lname: 'Hasanov', age: 12},
    {fname: 'Petrur', lname: 'Petrov', age: 20},
    {fname: 'Hristo', lname: 'Hristov', age: 22},
    {fname: 'Ivan', lname: 'Ivanov', age: 4},
    {fname: 'Zlatan', lname: 'Georgiev', age: 55}
];

console.log(group(people, 'age'));
console.log(group(people, 'fname'));