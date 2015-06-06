/**
 * Created by Kaloyan on 6.6.2015 ã..
 */
console.log('============');
console.log('Exercise 3: Underage People');

peopleArr
    .filter(function(person){
        return person.age < 18;
    })
    .forEach(function (person) {
        console.log(person);
    });
