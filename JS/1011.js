var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

const pi = 3.14159;
const r = Number(lines.shift());

const total = (4 / 3) * pi * r ** 3;

console.log(`VOLUME = ${total.toFixed(3)}`)

método 2:

var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

const pi = 3.14159;
const r = Number(lines.shift());

const total = (4 / 3) * pi
const valor = total * r ** 3;

console.log(`VOLUME = ${valor.toFixed(3)}`)
