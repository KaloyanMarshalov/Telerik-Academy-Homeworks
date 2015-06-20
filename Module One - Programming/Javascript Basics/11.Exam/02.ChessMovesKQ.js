/**
 * Created by Kaloyan on 11.6.2015 ã..
 */
function solve(params) {
    var rows = parseInt(params[0]),
        cols = parseInt(params[1]),
        tests = parseInt(params[rows + 2]),
        knightMoves = [[-2, 1], [-1, 2], [1, 2], [2, 1],
            [2, -1], [1, -2], [-1, -2], [-2, -1]],
        queenMoves = [[0, 1], [1, 1], [1, 0], [1, -1], [0, -1], [-1, -1], [-1, 0], [-1, 1]],
        i,
        move,
        moveCol,
        moveRow,
        currCol,
        currRow,
        queenCode = 'Q'.charCodeAt(0),
        knightCode = 'K'.charCodeAt(0),
        slashCode = '-'.charCodeAt(0);

    for (i = 0; i < tests; i++) {
        move = params[rows + 3 + i];
        // Your solution here
        currCol = move.charCodeAt(0) - 97;   ///d1 b3
        currRow = rows - parseInt(move[1]) + 2;                 //rows - 1 + 2
        moveCol = move.charCodeAt(3) - 97;           //cols - 1
        moveRow = rows - parseInt(move[4]) + 2;
        
        if ((params[moveRow].charCodeAt(moveCol) == knightCode || params[moveRow].charCodeAt(moveCol) == queenCode)
            || params[currRow].charCodeAt(currCol) == slashCode) {
            console.log('no');
        }
        else {
            if (params[currRow].charCodeAt(currCol) == knightCode) {
                var moveres = '';
                for (var j = 0, k = knightMoves.length; j < k; j++) {
                    currCol += knightMoves[j][0];
                    currRow += knightMoves[j][1];

                    if (currCol == moveCol && currRow == moveRow) {
                        moveres = 'yes';
                        break;
                    }
                    else {
                        currCol -= knightMoves[j][0];
                        currRow -= knightMoves[j][1];
                        moveres = 'no';
                    }
                }
                console.log(moveres);
            }

            else if (params[currRow].charCodeAt(currCol) == queenCode) {
                var moveresQ = '';
                var orCol = currCol;
                var orRow = currRow;
                var breakBig = false;

                for (var p = 0, l = queenMoves.length;  p < l; p++) {
                    currCol = orCol;
                    currRow = orRow;
                    if (breakBig) {
                        break;
                    }

                    for (var z = 0; z < 8; z++) {
                        currRow += queenMoves[p][0];
                        currCol += queenMoves[p][1];
                        if ((currCol <0 || currRow < 0 || params[currRow].charCodeAt(currCol) == queenCode ||
                            params[currRow].charCodeAt(currCol) == knightCode)                        ) {
                            moveresQ = 'no';

                            break;
                        }
                        if (currCol == moveCol && currRow == moveRow) {
                            moveresQ = 'yes';
                            breakBig = true;
                            break;
                        }
                    }
                }
                console.log(moveresQ);
            }
        }
    }
}

