package main

import (
	"fmt"
	"strings"
	"time"
)

func main() {
	go say_myname_slow("Bujosa")
	fmt.Println("Aprendiendo go rutines")
	var wait string
	fmt.Scanln(&wait)
}

func say_myname_slow(name string) {

	letras := strings.Split(name, "")
	for _, letra := range letras {
		time.Sleep(1000 * time.Millisecond)
		fmt.Println(letra)
	}

}
