/**
 * Created by Kaloyan on 6.6.2015 ã..
 */
console.log('============');
console.log('Exercise 1: Make Person');

function Person(fname, lname, age, gender) {
    this.firstName = fname;
    this.lastName = lname;
    this.age = age;
    this.gender = gender;
}

var peopleArr = [
    new Person('Ivan', 'Ivanov', 12, 'male'),
    new Person('Plamen', 'Plamenov', 15, 'male'),
    new Person('Hristo', 'Hristov', 22, 'male'),
    new Person('Kiril', 'Kirov', 18, 'male'),
    new Person('Mihail', 'Mihov', 39, 'male'),
    new Person('Ivaninva', 'Ivanova', 40, 'female'),
    new Person('Stefan', 'Stefanov', 15, 'male'),
    new Person('Zdravko', 'Zdravkov', 66, 'male'),
    new Person('Todorka', 'Lutenicata', 22, 'female'),
    new Person('Todor', 'Todorov', 35, 'male')
];

console.log(peopleArr);
