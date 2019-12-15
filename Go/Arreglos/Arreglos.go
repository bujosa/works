package main

import "fmt"

func main() {
	arreglo := [10]int{1, 2, 3}
	arreglo[9] = 100
	fmt.Println(arreglo)
}
