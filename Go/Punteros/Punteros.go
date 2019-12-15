package main

import "fmt"

func main() {

	var x, y *int
	entero := 5

	x = &entero
	y = &entero

	*x = 6

	fmt.Println(x)
	fmt.Println(y)
	fmt.Println(*x)
	fmt.Println(*y)
}
