package main

import (
	"io"
	"net/http"
)

func main() {
	http.HandleFunc("/HomePage", func(w http.ResponseWriter, r *http.Request) {

		io.WriteString(w, "Esta es la pagina principal")
	})
	http.HandleFunc("/", handler)
	http.ListenAndServe(":8000", nil)
}

func handler(w http.ResponseWriter, r *http.Request) {

	io.WriteString(w, "Hola Yordi mi first pagina web in go")
}
