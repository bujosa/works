package main

import "fmt"

type Casa struct {
	edad int

	nombre, apellido string
}

func main() {

	data := Casa{28, "Uriel", "Bujosa"}
	fmt.Println(data)
	// otra forma
	mansion := new(Casa)
	mansion.edad = 15000
	mansion.nombre = "David"
	mansion.apellido = "Bujosa"
	fmt.Println(mansion)
}
