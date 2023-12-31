// let arreglo = [1, 2, 3, "aa "];
// document.write(arreglo);

// let persona = {
//   edad: 12,
//   nombre: "juan",
//   saludo: function saludo() {
//     alert("Hola");
//   },
// };
// document.write(persona.saludo);
// console.log(persona);

// let fecha = new Date();
// let hora = fecha.getHours();
// documento.write(<br></br>);

function mostrar() {
  let fecha = new Date();
  let hora = fecha.getHours();
  let dato = `hora: ${fecha.getMinutes()}: ${fecha.getSeconds()} hs`;
  let parrafo = document.getElementById("parrafo");
  // parrafo.innerHTML = `hora: ${hora}: ${fecha.getMinutes()}: ${fecha.getSeconds()} hs`;

  parrafo.innerText = `hora: ${hora}: ${fecha.getMinutes()}: ${fecha.getSeconds()} hs`;
}
mostrar();
setInterval(mostrar, 1000);
