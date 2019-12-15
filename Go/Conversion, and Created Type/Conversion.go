package main

import "fmt"

type Bujosa int // Created my Type

var y int

func main() {

	y = 45
	var X Bujosa
	X = 45

	fmt.Printf("%T\n", X)
	fmt.Printf("%T\n", y)

	Z := int(X)
	fmt.Printf("%T\n", Z)

	// Conversion no Casting

}
