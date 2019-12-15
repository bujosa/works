package main

import (
	"fmt"
	"io/ioutil"
)

func main() {
	fila_data, err := ioutil.ReadFile("./Read.txt")

	if err != nil {
		fmt.Println("Hubo error")
	}
	fmt.Println(string(fila_data))
}
