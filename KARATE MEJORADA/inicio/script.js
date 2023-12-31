let nav = document.getElementById("contenedor-nav");

let backgroud_menu = document.getElementById("back-menu");

document.getElementById("icono-menu").addEventListener("click", mostrar_menu);

document.getElementById("back-menu").addEventListener("click", ocultar_menu);

function mostrar_menu() {
  nav.style.right = "0px";
  backgroud_menu.style.display = "block";
}

let botonCerrarmenu = document.getElementById("cerrar-menu");

botonCerrarmenu.addEventListener("click", ocultar_menu);

function ocultar_menu() {
  nav.style.right = "-550px";
  backgroud_menu.style.display = "none";
}

// let horario= document.getElementsById("reloj");
let mostrarHora = () => {
  let day = document.getElementById("reloj");
  let fecha = new Date();
  let aa = fecha.getDate();
  let minutos = fecha.getMinutes();
  let segundos = fecha.getSeconds();
  day.innerText = `Hora: ${aa}:${minutos}:${segundos}`;
};
setInterval(mostrarHora, 1000);

let inscripcion = document.getElementById("inscripcion");
inscripcion.style.display = "inline-block";
inscripcion.style.marginTop = "30px";
 function