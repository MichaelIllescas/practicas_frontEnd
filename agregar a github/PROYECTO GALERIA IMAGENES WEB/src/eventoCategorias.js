import datafotos from "./data/fotos";
const contenedorCategorias = document.getElementById("categorias");

const galeria = document.getElementById("galeria");

const contenedorImagen = document.getElementById("imagenActiva");

contenedorCategorias.addEventListener("click", (e) => {
  e.preventDefault();

  if (e.target.closest("a")) {
    categoriaActiva = e.target.closest("a").dataset.categoria;
    galeria.dataset.categoria = categoriaActiva;
    // Obtenemos las fotos que corresponden a la categoria
    const fotos = dataFotos.fotos[categoriaActiva];
    const carousel = galeria.querySelector(".galeria__carousel-slides");

    // Reiniciamos el carousel
    carousel.innerHTML = "";
    galeria.classList.add("galeria--active");

    // Tomamos la informacion de la primera imagen de la categoria y la cargamos en el DOM.
    const { id, nombre, ruta, descripcion } = fotos[0];
    cargarImagen(id, nombre, ruta, descripcion);

    // Por cada foto agregamos un slide al carousel.
    for (let i = 0; i < fotos.length; i++) {
      const slide = `
				<a href="#" class="galeria__carousel-slide">
					<img class="galeria__carousel-image" src="${fotos[i].ruta}" alt="" data-id-foto="${fotos[i].id}" />
				</a>
			`;

      carousel.innerHTML += slide;
    }
  }
});
