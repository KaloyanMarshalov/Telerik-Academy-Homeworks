/**
 * Created by Kaloyan on 7.6.2015 ã..
 */
console.log('============');
console.log('Exercise 9: Extract e-mails');

function extractValidEmails(text) {
    var pattern = /(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))/g;
    var validEmails = text.match(pattern);

    return validEmails;
}

var text = 'please send me a message @ someEmail@gmail.com. I will try to respond to Other@yahoo.com, nut if you don\'t receive an' +
    'answer, i will use myeamil@abv.bg!';

var validEmails = extractValidEmails(text);
console.log(validEmails);
