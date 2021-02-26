var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let n1 = Number(lines.shift());
let n2 = Number(lines.shift());

let media = (n1*3.5 + n2*7.5) / 11;

console.log(`MEDIA = ${media.toFixed(5)}`);
