package main

import "fmt"

type User interface {
	permissions() int
	Name() string
}

type Admin struct {
	name string
}

func (this Admin) permissions() int {
	return 5
}

func (this Admin) Name() string {
	return this.name
}

type Editor struct {
	name string
}

func (this Editor) permissions() int {
	return 3
}

func (this Editor) Name() string {
	return this.name
}

func auth(user User) string {
	if user.permissions() > 4 {
		return user.Name() + " tiene permisos de administrador"
	} else if user.permissions() == 3 {
		return user.Name() + " Tiene permiso de Editor"
	}
	return ""
}

func main() {

	usuarios := []User{Admin{"David "}, Editor{" Joselo"}}

	for _, usuario := range usuarios {
		fmt.Println(auth(usuario))
	}

}
