function solve(params) {
    var nk = params[0].split(' ').map(Number),
        s = params[1].split(' ').map(Number),
        sum = 0,
        j,
        k;

    // Your solution here

    for(j = 0; j < nk[1]; j += 1){
        s = transformation(s);
    }

    for(k = 0; k < nk[0]; k += 1){
        sum += s[k];
    }
    return sum;

    function transformation(s){
        var i,
            result =[],
            len = s.length,
            neighbor1,
            neighbor2;

        for (i = 0; i < len; i += 1){
            if(i === 0){
                neighbor1 = s[len - 1];
                neighbor2 = s[1];
            }
            else if(i === len - 1){
                neighbor1 = s[len - 2];
                neighbor2 = s[0];
            }
            else{
                neighbor1 = s[i - 1];
                neighbor2 = s[i + 1];
            }

            if(s[i] === 0){
                result.push(Math.abs(neighbor1 - neighbor2));
            }
            else if(s[i] === 1){
                result.push(neighbor1 + neighbor2);
            }
            else if(!(s[i] % 2)){ //even
                result.push(Math.max(neighbor1, neighbor2));
            }
            else{
                result.push(Math.min(neighbor1, neighbor2));
            }
        }
        return result;
    }
}


var test1 = [
    '5 1',
    '9 0 2 4 1'
],
    test2 = [
        '10 3',
        '1 9 1 9 1 9 1 9 1 9'
    ],
    test3 = [
        '10 10',
        '0 1 2 3 4 5 6 7 8 9'
    ];

console.log(solve(test1));
console.log(solve(test2));
console.log(solve(test3));