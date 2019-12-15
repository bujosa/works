package main

import "fmt"

func main() {
	x := 20
	y := 10

	if x > y {
		fmt.Printf("%d es mayor que Y %d \n", x, y)
	} else {
		fmt.Printf("%d es mayor que x con %d \n", y, x)
	}
}
