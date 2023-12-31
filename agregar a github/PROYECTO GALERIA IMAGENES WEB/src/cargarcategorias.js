import datacategorias from "./data/categorias";
const { categorias } = datacategorias;
const contenedorCategorias = document.getElementById("categorias");

categorias.forEach((categoria) => {
  const nuevaCategoria = document.createElement("a");
  const pantilla = `
                    <img class="categoria__img" src="${categoria.imagenPortada}" alt="" />
                    <div class="categoria__datos">
                        <p class="categoria__nombre">${categoria.nombre}</p>
                        <p class="categoria__numero-fotos">${categoria.numeroFotos}</p>
                    </div>`;
  nuevaCategoria.innerHTML = pantilla;
  nuevaCategoria.classList.add("categoria");
  nuevaCategoria.href = "#";
  nuevaCategoria.dataset.categoria = categoria.id;

  contenedorCategorias.append(nuevaCategoria);
});
