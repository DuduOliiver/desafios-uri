var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let name = lines.shift();
let n1 = Number(lines.shift());
let vendas = Number(lines.shift());

let comissao = vendas * 0.15;
let total = n1 + comissao;

console.log(`TOTAL = R$ ${total.toFixed(2)}`);
