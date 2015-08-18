function solve(params) {
    var rows = parseInt(params[0]),
        cols = parseInt(params[1]),
        tests = parseInt(params[rows + 2]),
        i,
        move,
        board = params.slice(2, 2 + rows),
        startRow,
        startCol,
        endRow,
        endCol,
        figure,
        destination;


    for (i = 0; i < tests; i++) {//tests
        move = params[rows + 3 + i];
        startCol = move[0].charCodeAt() - 97;
        startRow = rows - move[1];
        endCol = move[3].charCodeAt() - 97;
        endRow = rows - move[4];

        figure = board[startRow][startCol];
        destination = board[endRow][endCol];

        //no figure at start
        if (figure === '-'){
            console.log('no');
            continue;
        }

        //occupied destination
        if(destination !== '-'){
            console.log('no');
            continue;
        }

        //valid move for Rook
        if(figure === 'R'){
            if ( !((startRow === endRow) || (startCol === endCol)) ){
            console.log('no');
            continue;
            }
        }

        //valid move for Bishop
        if(figure === 'B'){
            if ( !(Math.abs(startRow - endRow) === Math.abs(startCol - endCol)) ){
                console.log('no');
                continue;
            }
        }

        //valid move for Queen
        if(figure === 'Q'){
            if ( !((startRow === endRow) || (startCol === endCol) || Math.abs(startRow - endRow) === Math.abs(startCol - endCol)) ){
                console.log('no');
                continue;
            }
        }
    //console.log("ETO ME");
        //horizontal move
        if(startRow === endRow){
            var figureOnCol = false;
            for (var c = Math.min(startCol, endCol) + 1; c < Math.max(startCol, endCol); c += 1){
                if(board[startRow][c] !== '-'){
                    console.log('no');
                    figureOnCol = true;
                    break;
                }
            }
            if(figureOnCol){
                continue;
            }
        }

        //vertical move
        if(startCol === endCol){
            var figureOnRow = false;
            for (var r = Math.min(startRow, endRow) + 1; r < Math.max(startRow, endRow); r += 1){
                if(board[r][startCol] !== '-'){
                    console.log('no');
                    figureOnRow = true;
                    break;
                }
            }
            if(figureOnRow){
                continue;
            }
        }

        //diagonal move
        if(Math.abs(startRow - endRow) === Math.abs(startCol - endCol)){
            var figureOnDiagonal = false;

            if(startRow < endRow && startCol < endCol){
                for (var dr = startRow + 1, dc = startCol + 1; dr < endRow; dr += 1, dc += 1){
                    if(board[dr][dc] !== '-'){
                        console.log('no');
                        figureOnDiagonal = true;
                        break;
                    }
                }
            }
            else if (startRow < endRow && startCol > endCol)
            {
                for (var dr = startRow + 1, dc = startCol - 1; dr < endRow; dr += 1, dc -= 1){
                    if(board[dr][dc] !== '-'){
                        console.log('no');
                        figureOnDiagonal = true;
                        break;
                    }
                }
            }

            else if(startRow > endRow && startCol < endCol){
                for (var dr = startRow - 1, dc = startCol + 1; dr > endRow; dr -= 1, dc += 1){
                    if(board[dr][dc] !== '-'){
                        console.log('no');
                        figureOnDiagonal = true;
                        break;
                    }
                }
            }
            else if (startRow > endRow && startCol > endCol)
            {
                for (var dr = startRow - 1, dc = startCol - 1; dr > endRow; dr -= 1, dc -= 1){
                    if(board[dr][dc] !== '-'){
                        console.log('no');
                        figureOnDiagonal = true;
                        break;
                    }
                }
            }

            if(figureOnDiagonal){
                continue;
            }
        }


        // All tests passed
        console.log('yes');
    }


}


var input1 = [
   '3',
   '4',
   '--R-',
   'B--B',
   'Q--Q',
   '12',
   'd1 b3',
   'a1 a3',
   'c3 b2',
   'a1 c1',
   'a1 b2',
   'a1 c3',
   'a2 b3',
   'd2 c1',
   'b1 b2',
   'c3 b1',
   'a2 a3',
   'd1 d3'
    ],

    input2 = [
        '5',
        '5',
        'Q---Q',
        '-----',
        '-B---',
        '--R--',
        'Q---Q',
        '10',
        'a1 a1',
        'a1 d4',
        'e1 b4',
        'a5 d2',
        'e5 b2',
        'b3 d5',
        'b3 a2',
        'b3 d1',
        'b3 a4',
        'c2 c5'

    ];

solve(input2);
