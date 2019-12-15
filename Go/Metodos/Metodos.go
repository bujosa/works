package main

import "fmt"

type User struct {
	nombre   string
	apellido string
	numero   int
}

func (usuario User) nombre_completo() string {
	return usuario.nombre + " " + usuario.apellido
}

// Ahora si yo le pongo asterico si se toca el nombre
func (usuario *User) Set_Name(n string) {
	usuario.nombre = n
}

func main() {

	david := new(User)

	david.nombre = "David"

	david.apellido = "Bujosa"

	david.numero = 809

	david.Set_Name("Jose") // aqui lo hace es que modifica el nombre pero la funcion lo que hace
	// es que lo duplica por lo tanto el nombre que tiene david el cual es David no se toca

	resultado := david.nombre_completo()

	fmt.Println(resultado)
}
