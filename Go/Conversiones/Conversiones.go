package main

import (
	"fmt"
	"strconv"
)

func main() {
	edad := 22

	edad_str := strconv.Itoa(edad) // Convertir entero a String

	fmt.Println("Mi edad es " + edad_str)

}
