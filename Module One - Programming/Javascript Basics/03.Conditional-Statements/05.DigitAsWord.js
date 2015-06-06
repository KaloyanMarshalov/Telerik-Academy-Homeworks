console.log('============');
console.log('Exercise 5: Digit as word');

var digit = 7;
var name;
switch (digit) {
    case 0: name = 'The digit\'s name is Zero'; break;
    case 1: name = 'The digit\'s name is One'; break;
    case 2: name = 'The digit\'s name is Two'; break;
    case 3: name = 'The digit\'s name is Three'; break;
    case 4: name = 'The digit\'s name is Four'; break;
    case 5: name = 'The digit\'s name is Five'; break;
    case 6: name = 'The digit\'s name is Six'; break;
    case 7: name = 'The digit\'s name is Seven'; break;
    case 8: name = 'The digit\'s name is Eight'; break;
    case 9: name = 'The digit\'s name is Nine'; break;
    default: name = 'Invalid number (must be a single digit)'; break;
}
console.log(name);
