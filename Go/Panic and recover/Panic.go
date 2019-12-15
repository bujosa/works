package main

import (
	"bufio"
	"fmt"
	"os"
)

func main() {
	readfile()
	fmt.Println("Yo me ejecute")
}

func readfile() bool {

	archivo, err := os.Open("./Readd.txt")

	defer func() {
		archivo.Close()
		fmt.Println("Entro al defer")
		recover()

	}()

	if err != nil {
		fmt.Println("Hubo error")
		panic(err)
	}

	scanner := bufio.NewScanner(archivo)

	for scanner.Scan() {
		linea := scanner.Text()

		fmt.Println(linea)
	}

	return true

}
