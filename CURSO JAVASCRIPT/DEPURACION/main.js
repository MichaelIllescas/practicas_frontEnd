function outer() {
    let name = "outer";
    let str = inner();
    return str;
}

function inner() {
    let name = "inner";
    return "¡Hola!";
}
console.time('Leibniz');
console.log("Antes de llamar a outer()");
console.timeEnd('Leibniz');
console.log(outer());
console.log("Despues de llamar a outer()");

function max(array) { 
    let maxValue = array[1]; 
    for(let i=1; i<array.length; i++) { 
        if(array[i] > maxValue) { 
            maxValue = array[i]; 
        } 
    } 
    return maxValue; 
} 
 
console.log( max([1, 4, 6, 2])); // -> 6 
console.log( max([10, 4, 6, 2])); // -> 6
let x=3e-3
console.log(x)