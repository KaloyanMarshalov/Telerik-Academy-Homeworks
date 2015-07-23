var animal = {
    makeNoise: function() {
        return this.type + ' says: ' + this.noise;
    }
};


// prototypal inheritance with a reused method from the parent class
var dog = (function(parent) {
    var dog = Object.create(animal);

    Object.defineProperties(animal, {
        type: {
            value: 'dog'
        },
        noise: {
            value: 'djaf'
        },
        color: {
            value: 'brown'
        }
    });

    Object.defineProperty(dog, 'makeNoise', {
        value: function() {
            return parent.makeNoise.call(this) + ' and is of color ' + this.color;
        }
    });

    return dog;
}(animal));

console.log(dog.makeNoise());
//duck typing
console.log(dog.makeNoise.call({type: 'cat', noise: 'meow', color: 'white'}));
