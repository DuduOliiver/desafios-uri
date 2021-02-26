var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let n1 = Number(lines.shift());
let n2 = Number(lines.shift());
let n3 = Number(lines.shift());
let n4 = Number(lines.shift());

let diferenca = (n1 * n2) - (n3 * n4);

console.log(`DIFERENCA = ${diferenca}`);
