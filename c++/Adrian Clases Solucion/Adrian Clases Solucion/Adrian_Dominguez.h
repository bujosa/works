#pragma once

#include <string>
#include <iostream>

using namespace std;

class Adrian_Dominguez
{
private:
		int cantidad;
		double Itbis;
		int precio;
		string nombreproducto;
		double ganancia;
public:
	Adrian_Dominguez(int _cantidad, double _Itbis, int _precio, string _nombreproducto) {

		cantidad = _cantidad;
		Itbis = _Itbis;
		precio = _precio;
		nombreproducto = _nombreproducto;
	}
	
	// Esta funcion se encarga de calcular la cantidad de producto
	// Por el precio y el itbis para mostrar una ganancia total
	void Calculo() {
		ganancia = (cantidad * ((precio*Itbis) + precio));
		 
	}
	// Esta funcion se encarga de mostrar los resultados que
	// es guardada en la variable ganancia
	void RESULTADOS() {
		cout << "Nombre del producto: " << Get_Nombre() << endl;
		cout << "Cantidad existente del producto: " << Get_Cantidad() << endl;
		cout << "Precio del producto: " << Get_Precio() << endl;
		cout << "Itbis del producto: " << Get_Itbis() << endl;
		cout << "La Ganancia maxima obtenida por el producto es: " << ganancia << endl;
	}


	// Esta parte hace el papel de Get de mostrar lo que guardan 
	// las variables privada de la clase.
	int Get_Cantidad() {
		return cantidad;
	}
	double Get_Itbis() {
		return Itbis;
	}
	int Get_Precio(){
		return precio;
	}
	string Get_Nombre() {
		return nombreproducto;
	}
	double Get_Ganancias() {
		return ganancia;
	}

	// Esta parte de Set modifica los valores que 
	// se crearon mediante el contructor;

	void Set_Cantidad(int cantidad) {
		this->cantidad = cantidad;
	}
	void Set_Precio(int precio) {
		this->precio = precio;
	}
	void Set_Nombre(string nombre) {
		this->nombreproducto = nombre;
	}
	void Set_Itbis(double Itbis) {
		this->Itbis = Itbis;
	}

};

