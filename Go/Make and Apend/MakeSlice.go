package main

import "fmt"

func main() {

	slice := make([]int, 3)
	// La ventaja de los slice es que su capacidad no esta
	// predefinidda
	slice = append(slice, 2)
	fmt.Println(slice)
}

// slice https://www.youtube.com/watch?v=kUB3DphxfdY&list=PLdKnuzc4h6gFmPLeous4S0xn0j9Ik2s3Y&index=9
