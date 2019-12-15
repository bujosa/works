package main

import "fmt"

type Human struct {
	name string
}

func (this Human) hablar() string {
	return "Bla Bla Bla"
}

func (this Tutor) hablar() string {
	return "Bienvenido a mi mundo"
}

type Tutor struct {
	Human
	Dummy
}

type Dummy struct {
	name string
}

func main() {

	tutor := Tutor{Human{"David"}, Dummy{"Jose"}}
	//resultado := "Hola Mundo"
	fmt.Println(tutor.Dummy.name)
	fmt.Println(tutor.hablar())
}

// Cabe resaltar que go no es un lenguaje orientado a Objeto
// Pero si se puede utilizar herencia
