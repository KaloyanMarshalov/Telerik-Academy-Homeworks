/**
 * Created by Kaloyan on 6.6.2015 ã..
 */
console.log('============');
console.log('Exercise 3: Deep copy');

function makeDeepCopy(obj) {
    return JSON.parse(JSON.stringify(obj));
}

var pesho = {
    name: "Pesho",
    age: 16,
    objProp: {prop1: 4, prop2: 7}
};

var deepCopy = makeDeepCopy(pesho);
console.log(deepCopy);