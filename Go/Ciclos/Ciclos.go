package main

import "fmt"

func main() {
	for i := 0; i < 10; i++ { // El for sirve como el while tambien
		fmt.Println("Te quiero mucho Nelly")

		if i == 2 {
			continue
		}
		if i == 9 {
			break
		}
	}
}
