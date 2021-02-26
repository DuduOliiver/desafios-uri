método 01:
const pegarValores = (string) => string.split(" ").map(item => Number(item)).reverse();


const [qntPecas1, valorPorPeca1] = pegarValores(lines.shift());
const [qntPecas2, valorPorPeca2] = pegarValores(lines.shift());

const precoAPagar1 = qntPecas1 * valorPorPeca1;
const precoAPagar2 = qntPecas2 * valorPorPeca2;

console.log(`VALOR A PAGAR: R$ ${(precoAPagar1 + precoAPagar2).toFixed(2)}`);



método 02:
var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

const getvalue = (string) => string.split(" ").map(value => Number(value));
const [peca1, numero1, valor1] = getvalue(lines.shift());
const [peca2, numero2, valor2] = getvalue(lines.shift());

const total = (numero1 * valor1) + (numero2 * valor2);

console.log(`VALOR A PAGAR: R$ ${total.toFixed(2)}`);
