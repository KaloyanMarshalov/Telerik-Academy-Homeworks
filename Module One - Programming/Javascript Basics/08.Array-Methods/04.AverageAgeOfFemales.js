/**
 * Created by Kaloyan on 6.6.2015 ã..
 */
console.log('============');
console.log('Exercise 4: Avarage age of females');

var females = peopleArr.filter(function(person) {
        return person.gender == 'female';
    }),
    sum = females.reduce(function (sum, person) {
        return sum + person.age;
    }, 0),
    avg = sum / females.length;

console.log(avg);
