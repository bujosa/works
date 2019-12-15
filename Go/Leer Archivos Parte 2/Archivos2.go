package main

import (
	"bufio"
	"fmt"
	"os"
)

func main() {
	archivo, err := os.Open("./Read.txt")

	if err != nil {
		fmt.Println("Hubo error")
	}

	scanner := bufio.NewScanner(archivo)

	for scanner.Scan() {
		linea := scanner.Text()

		fmt.Println(linea)
	}
	
   archivo.close()

}
