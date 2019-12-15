package main 

import (
	"fmt"
	"log"
	"net/http"
)

func homepage(w http.ResponseWriter, r *http.Request){
	fmt.Fprintf(w, "Homepage Endpoint Hit")
}

func handleRequests(){
	http.HandleFunc("/",homepage)
	log.Fatal(http.ListenAndServe(":8001",nil))
}
func main(){

	handleRequests()

}