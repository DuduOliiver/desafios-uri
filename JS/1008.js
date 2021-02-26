var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let n1 = Number(lines.shift());
let horas = Number(lines.shift());
let valor = Number(lines.shift());

let numero = horas * valor;

console.log(`NUMBER = ${n1}`);
console.log(`SALARY = U$ ${numero.toFixed(2)}`);
