// SECCION DE MENUS DESPLEGABLES

let boton_hombres = document.getElementById("boton-abrir-menu");
let menuOcultoHombres = document.getElementById("menu-oculto-hombres");

let boton_mujeres = document.getElementById("boton-mujeres");
let menuOcultoMujeres = document.getElementById("menu-oculto-mujeres");

function desplegarMenuHombres() {
  if (menuOcultoHombres.style.display == "none") {
    menuOcultoHombres.style.display = "block";
    menuOcultoHombres.style.position = "absolute";

    menuOcultoHombres.style.opacity = "1";
    menuOcultoMujeres.style.display = "none";
  } else {
    menuOcultoHombres.style.display = "none";
  }
}
function desplegarMenuMujeres() {
  if (menuOcultoMujeres.style.display == "none") {
    menuOcultoMujeres.style.display = "block";
    menuOcultoMujeres.style.position = "absolute";
    menuOcultoMujeres.style.opacity = "1";
    menuOcultoHombres.style.display = "none";
  } else {
    menuOcultoMujeres.style.display = "none";
  }
}
boton_hombres.addEventListener("click", desplegarMenuHombres);
boton_mujeres.addEventListener("click", desplegarMenuMujeres);

// FUNCION DE FECHA SUPERIOR
function obtenerFechaFormateada() {
  const opciones = {
    weekday: "long", // Nombre completo del día de la semana
    day: "numeric", // Día del mes
    month: "long", // Nombre completo del mes
    year: "numeric", // Año
  };

  const fechaActual = new Date();
  const fechaFormateada = fechaActual.toLocaleDateString("es-ES", opciones);

  return fechaFormateada;
}
function mayusculaPrimerLetra(str) {
  return str.charAt(0).toUpperCase() + str.slice(1);
}
const dia = document.getElementById("fecha");
dia.innerText = mayusculaPrimerLetra(obtenerFechaFormateada());

// SECCION RESPONSIVE
let nav = document.getElementById("contenedor-nav");

let backgroud_menu = document.getElementById("back-menu");

let lista_desplegable = document.getElementById("lista-desplegable");

function mostrar_menu() {
  if (nav.style.display != "block") {
    nav.style.right = "0px";
    backgroud_menu.style.display = "block";
    botonCerrarmenu.style.display = "flex";
    botonCerrarmenu.style.opacity = "1";
    lista_desplegable.style.right = "0px";
    lista_desplegable.style.top = "150px";
  } else {
    ocultar_menu();
  }
}
function ocultar_menu() {
  nav.style.right = "-1000px";
  lista_desplegable.style.right = "-1000px";
  backgroud_menu.style.display = "none";
  botonCerrarmenu.style.opacity = "0";
}
let botonCerrarmenu = document.getElementById("icono-cerrar-desactivo");

botonCerrarmenu.addEventListener("click", ocultar_menu);

document.getElementById("icono-menu").addEventListener("click", mostrar_menu);

document.getElementById("back-menu").addEventListener("click", ocultar_menu);

// HOJA CONTACTO

// FUNCION PARA MOSTRAR HORA

let mostrarHora = () => {
  let hora = document.getElementById("hora");
  let fecha = new Date();
  let aa = fecha.getDate();
  let minutos = fecha.getMinutes();
  let segundos = fecha.getSeconds();
  hora.innerHTML = `Hora: ${aa}:${minutos}:${segundos}`;
};

setInterval(mostrarHora, 1000);
