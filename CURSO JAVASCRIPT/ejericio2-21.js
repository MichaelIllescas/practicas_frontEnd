let bol=Boolean(true);
let num=Number(44);
let big=BigInt(12222);
let str=String ("Hola");
let un=undefined;

console.log(`bol = ${bol} : ${typeof bol}.`);
console.log(`num = ${num} : ${typeof num}.`);
console.log(`big = ${big} : ${typeof big}.`);
console.log(`str = ${str} : ${typeof str}.`);
console.log(`un = ${un} : ${typeof un}.`);

let creado= Boolean(BigInt(Number(String("1234"))));
console.log(creado);

let bol1=Boolean(Boolean(true));
let num1=Number(Number(12));
let big1=BigInt(BigInt(1212));
let str1=String (String("Hola"));
let un1=undefined;
console.log(bol1);
console.log(num1);
console.log(big1);
console.log(str1);

let suma= num1+str1
console.log(suma)

str1= 42 + Number("1");
console.log(str1)