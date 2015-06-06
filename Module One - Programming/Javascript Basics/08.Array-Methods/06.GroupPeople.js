/**
 * Created by Kaloyan on 6.6.2015 ã..
 */
console.log('============');
console.log('Exercise 6: Group people');

var groups = peopleArr.reduce(function (gr, person) {
    var letter = person.firstName[0];

    if (gr[letter]) {
        gr[letter].push(person);
    } else {
        gr[letter] = [person];
    }

    return gr;
}, {});
console.log(groups);
