/**
 * Created by Kaloyan on 6.6.2015 ã..
 */
console.log('============');
console.log('Exercise 2: Remove elements');

Array.prototype.remove = function (element) {
    for (var i = 0; i < this.length; i++) {
        if (this[i] === element) {
            this.splice(i, 1);
            i--;
        }
    }
};

var arr = [1,2,3,1,2,3,4,1,23,4,2,1,3,6];
console.log(arr);

arr.remove(1);
console.log(arr);
