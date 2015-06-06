/**
 * Created by Kaloyan on 7.6.2015 ã..
 */
console.log('============');
console.log('Exercise 7: ParseURL');

function extractURLElements(url) {
    var pattern = /(.*):\/\/(.*?)(\/.*)/g;

    return pattern.exec(url);
}

var urlAddress = "https://www.devbg.org/forum/index.php";

var fragments = extractURLElements(urlAddress);

// Convert to JSON object
var jsonObject = JSON.stringify({
    protocol: fragments[1],
    server: fragments[2],
    resource: fragments[3]
});

console.log(jsonObject);

