package main

import (
	"encoding/json"
	"net/http"
)

type Curso struct {
	Title        string `json:"Titulo"`
	NumeroVideos int    `json:"Videos"`
	// Es muy importante que si una variable es declarada en miniscula
	// se tomara en cuenta como si fuera una variable privada
	// Por eso para que sea publica debe empezar en mayuscula
}

func main() {
	http.HandleFunc("/", func(w http.ResponseWriter, r *http.Request) {
		curso := Curso{"Mi pagina de videos", 5}
		json.NewEncoder(w).Encode(curso)
	})

	http.ListenAndServe(":8000", nil)
}
