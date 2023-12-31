let contacts = [{
name: "Maxwell Wright",
phone: "(0191) 719 6495",
email: "Curabitur.@nonummyac.co.uk"
}, {
name: "Raja Villarreal",
phone: "0866 398 2895",
email: "posuere.vulputate@sed.com"
}, {
name: "Helen Richards",
phone: "0800 1111",
email: "libero@convallis.edu"
}];
function showContac(lista, indice) {
	if (lista instanceof Array && Number.isInteger(indice) && indice< lista.length ){
		return (console.log(`nombre: ${lista[indice].name},teléfono: ${lista[indice].phone},Email: ${lista[indice].email}.`))
	}
	else {return console.log("Alguno de los elementos es invalido")
    }	
}
//console.log(showContac(contacts, 2));

function showAllContacts(lista){
	if (lista instanceof Array){
		for (elementosLista of lista){	
			for(contacto in elementosLista){
					console.log(`${contacto}:${elementosLista[contacto]}`)
			}
		
		}
	}else{ 
		console.log("El argumento no es una lista")
		}	
	
}
let a=0;
//showAllContacts(a);

function addNewContact(lista, name,phone,email){
	if (lista instanceof Array){
		if (name && phone && email) {
			lista.push({name: name, phone: phone, email: email })
			console.log("Contacto ingresado correctamente.")
		}else{
			console.log("alguno de los datos ingresados es icorrecto")
		}
	}else{
		console.log("el argumento ingresado no es una lista")
	}
}	
addNewContact(contacts, "a" ,"2222","joni.illes");
showContac(contacts, 3)