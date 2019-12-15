#pragma once
#include <string>
#include <iostream>

using namespace std;

// Farmacia
class Dionisio_Jimenez
{
private:

	string NombreFarmacia;
	string NombreMedicamento;
	int Precio_Medicamento;
	int Cantidad_Medicamento;
	int Ganancia_De_Venta; // Atributo sera asignado por funcion de calculo

public:

	// Constructor 
	Dionisio_Jimenez(string Nombre, string Medicamento, int Precio, int Cantidad) {
		this->NombreFarmacia = Nombre;
		this->NombreMedicamento = Medicamento;
		this->Precio_Medicamento = Precio;
		this->Cantidad_Medicamento = Cantidad;
	}

	// Imprime los valores de las propiedades y el Resultado del calculo
	void RESULTADOS() {
		cout << "Nombre de la Farmacio: " << get_NombreF();
		cout << "\nNombre del Medicamento: " << get_NombreM();
		cout << "\nPrecio del Medicamento: " << get_PrecioM();
		cout << "\nCantidad del Medicamento: " << get_CantidadM();
		cout << "\nGanancia total: " << get_GananciaV();
	}

	// Calcula La ganacia de la venta total de un medicamento existente;
	void calculo() {
		this->Ganancia_De_Venta = Precio_Medicamento * Cantidad_Medicamento;
	}

	// Funciones de Set and Get e3 todos los atributos

	string get_NombreF() {
		return this->NombreFarmacia;
	}
	string get_NombreM() {
		return this->NombreMedicamento;
	}
	int get_PrecioM() {
		return this->Precio_Medicamento;
	}
	int get_CantidadM() {
		return this->Cantidad_Medicamento;
	}
	int get_GananciaV() {
		return this->Ganancia_De_Venta;
	}

	// set sirve para modificar los atributos que son privado de una clase
	void set_NombreF(string NombreF) {
		this->NombreFarmacia = NombreF;
	}
	void set_NombreM(string NombreM) {
		this->NombreMedicamento = NombreM;
	}
	void set_PrecioM(int Precio) {
		this->Precio_Medicamento = Precio;
	}
	void set_CantidadM(int cantidad) {
		this->Cantidad_Medicamento = cantidad;
	}
};

