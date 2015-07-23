var Person = (function() {
    function Person(name, age) {
        this.name = name;
        this.age = age;
    }

    Person.prototype.sayName = function() {
        return this.name + ' is my name! I am ' + this.age + ' years old.';
    };

    Object.defineProperty(Person.prototype, 'age', {
        get: function() {
            return this._age;
        },
        set: function(value) {
            this._age = value;
        }
    });

    return Person;
}());

var Student = (function() {
    function Student(name, age, school) {
        Person.call(this, name, age);
        this.school = school;
    }

    Student.prototype = new Person();

    Student.prototype.sayName = function () {
        var personName = Person.prototype.sayName.call(this);
        return personName + ' I study at ' + this.school;
    };

    return Student;
}());

var maria = new Student('Mariika', 20, 'NPMG');
console.log(maria.sayName());
