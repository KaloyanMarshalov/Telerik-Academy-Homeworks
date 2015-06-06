/**
 * Created by Kaloyan on 6.6.2015 ã..
 */
console.log('============');
console.log('Exercise 4: Has property');

function checkIfContainsProperty(obj, prop) {
    if (obj[prop]) {
        return true;
    }
    else {
        return false;
    }
}

var obj = {
    name: 'Kondio',
    age: 15,
    hair: false
}
console.log(checkIfContainsProperty(obj, 'age'));
console.log(checkIfContainsProperty(obj, 'car'));
