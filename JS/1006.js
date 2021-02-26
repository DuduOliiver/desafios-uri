var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let n1 = Number(lines.shift());
let n2 = Number(lines.shift());
let n3 = Number(lines.shift());

media = (n1*2 + n2*3 + n3*5) / 10;

console.log(`MEDIA = ${media.toFixed(1)}`);
