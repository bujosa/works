package main

import (
	"net/http"
)

func main() {

	// Entonces ahora que cree la carpeta public no es necesaria usar esta linea de codigo por
	// lo tanto estara comentada

	/*
		http.HandleFunc("/", func(w http.ResponseWriter, r *http.Request) {
			http.ServeFile(w, r, r.URL.Path[1:])
		})
	*/

	fileserver := http.FileServer(http.Dir("Public"))

	http.Handle("/", http.StripPrefix("/", fileserver))

	http.ListenAndServe(":8000", nil)
}

// Aparte de asignaler un "index.hmtl" tambien se puede hacer de la siguiente forma
// r.URL.Path[1:]
// Con este hack puedes entrar a cualquier archivo que este ubicado en esa carpeta
// Hasta el mismo codigo
