let contacts = [{
name: "Maxwell Wright",
phone: "(0191) 719 6495",
email: "Curabitur.egestas.nunc@nonummyac.co.uk"
}, {
name: "Raja Villarreal",
phone: "0866 398 2895",
email: "posuere.vulputate@sed.com"
}, {
name: "Helen Richards",
phone: "0800 1111",
email: "libero@convallis.edu"
}];

let eleccion =prompt("Ingrese 1 si desea mostrar el primer contacto, 2 si desea mostrar el ultimo contacto, o 3 si desea añadir un nuevo contacto", 0)

if (!Number.isNaN(eleccion)) {

	switch (eleccion){
		case "1":
			//muestra el primer contacto
            console.log(`Nombre:${contacts[0].name}, telefono: ${contacts[0].phone}, correo electronico: ${contacts[0].email}`);	
	        break;
        case "2":
			//muestra el ultimo contacto
			console.log(`Nombre:${contacts[contacts.length-1].name}, telefono: ${contacts[contacts.length-1].phone}, correo electronico: ${contacts[contacts.length-1].email}`);
            break;
        case "3":  
        	//agrega un nuevo contacto

        	let nombre=prompt("Name");
        	let telefono=prompt("phone");
        	let mail= prompt("email");
        	if (nombre && telefono && mail ){
				contacts.push({name: nombre, phone: telefono, email: mail });
	    		alert("Se ha añadido exitosamente");
            	break;
            } else{
            	alert("Faltan ingresar campos");
            	break;
            }
		default:
			alert("Opcion invalida");	
            break;
	}

}else{
	alert("Has ingresado un elemento invalido");
}






