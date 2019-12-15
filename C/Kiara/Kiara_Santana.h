#pragma once
#include <iostream>
#include <string>

using namespace std;

class Kiara_Santana
{
private:

	string Nombre_Flor;
	string Color;
	int Cantidad;
	int Costo;
	int Ganancia_Venta_Total; // Esta es la variable de calculo
	// Que sera asignada en la funcion de calculo;

public:

	// Constructor de la clase
	Kiara_Santana(string nombre, string color, int cantidad, int Costo)
	{
		this->Nombre_Flor = nombre;
		this->Cantidad = cantidad;
		this->Color = color;
		this->Costo = Costo;
	}

	// Estas funciones son generales son parte de los requesitos
	// de la asignacion la de calculo hacer el papel de calcular
	// la ganancia total que puede generar vender una cantidad
	// de rosas X. 

	// La funcion RESULTADOS muestra en pantalla los valores
	// que tienen las propiedades de la clase mas el resultado
	// del calculo realizado.

	void calculo() {
		this->Ganancia_Venta_Total = Cantidad * Costo;
	}

	void RESULTADOS() {

		std::cout << "\tNombre de la flor: " << Get_Nombre();
		std::cout << "\n\tColor de la flor: " << Get_Color();
		std::cout << "\n\tCantidad disponible de la flor: " << Get_Cantidad();
		std::cout << "\n\tPrecio de la flor: " << Get_Costo();
		std::cout << "\n\tGanancia total si se vende todas las flor disponibles: " << Get_Ganancia();
	}

	// Hacen el papel de Get y Set para obtener los valores de las propiedades
	// Y modificarlas.
	string Get_Nombre() {
		return Nombre_Flor;
	}
	void Set_Nombre(string nombre) {
		this->Nombre_Flor = nombre;
	}
	string Get_Color() {
		return Color;
	}
	void Set_Color(string color) {
		this->Color = color;
	}
	int Get_Cantidad() {
		return Cantidad;
	}
	void Set_Cantidad(int cantidad) {
		this->Cantidad = cantidad;
	}
	int Get_Costo() {
		return Costo;
	}
	void Set_Costo(int Costo) {
		this->Costo = Costo;
	}
	int Get_Ganancia() {
		return Ganancia_Venta_Total;
	}
};

