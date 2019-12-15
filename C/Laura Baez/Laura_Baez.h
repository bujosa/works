#pragma once

#include <iostream>
#include <string>

using namespace std;

class Laura_Baez
{
private:
	string Nombre_Tienda;
	string Nombre_Producto;
	int Cantidad;
    int Precio;
	int Ganancias_Venta_Producto; // Es realizada por la funcion de calculo 
public:
	Laura_Baez(string Nombre, string Producto, int cantidad, int precio) {
		this->Nombre_Tienda = Nombre;
		this->Nombre_Producto = Producto;
		this->Cantidad = cantidad;
		this->Precio = precio;
	}
	void RESULTADOS() {
		cout << "Nombre de la Tienda: " << get_Nombre() << endl;
		cout << "Nombre del producto: " << get_Producto() << endl;
		cout << "Cantidad del Producto: " << get_Cantidad() << endl;
		cout << "Precio del producto: " << get_Precio() << endl;
		cout << "Ganancia total: " << get_Ganancia() << endl;
	}
	void calculo() {
		this->Ganancias_Venta_Producto = Cantidad * Precio; 
		// Esta operacion calcula las ganacias maximas para saber 
		// con la cantidad de un producto a un precio x cuanto se ganaria si 
		// se vendiera todo.
	}

	string get_Nombre() {
		return this->Nombre_Tienda;
	}
	string get_Producto() {
		return this->Nombre_Producto;
	}
	int get_Cantidad() {
		return this->Cantidad;
	}
	int get_Precio() {
		return this->Precio;
	}
	int get_Ganancia() {
		return this->Ganancias_Venta_Producto;
	}

	void set_Nombre(string nombre) {
		this->Nombre_Tienda = nombre;
	}
	void set_Producto(string producto) {
		this->Nombre_Producto = producto;
	}
	void set_Cantidad(int cantidad) {
		this-> Cantidad = cantidad;
	}
	void set_Precio(int precio) {
		this->Precio = precio;
	}
};

