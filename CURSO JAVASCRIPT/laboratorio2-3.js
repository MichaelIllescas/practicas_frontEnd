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

contacts.push({name: "Maise Haley", phone:"0913 531 3030", email:"risus.Quisque@urna.ca" });

console.log(`Nombre:${contacts[0].name}, telefono: ${contacts[0].phone}, correo electronico: ${contacts[0].email}`)

console.log(`Nombre:${contacts[contacts.length-1].name}, telefono: ${contacts[contacts.length-1].phone}, correo electronico: ${contacts[contacts.length-1].email}`)
