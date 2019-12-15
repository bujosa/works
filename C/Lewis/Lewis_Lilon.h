#pragma once
#include <iostream>
#include <string>

using namespace std;

class Lewis_Lilon
{
private: 

	int Cantidad_Estudiantes;
	string Nombre_Escuela;
	string codigo_escuela;
	int tarifa_mensual;
	int Ganancia_Mensual; // Variable asignada al calculo

public:

	// Constructor de la clase.
	Lewis_Lilon(int _cantidad, int _tarifamensual, string _nombre, string _codigo) {
		this->Cantidad_Estudiantes = _cantidad;
		this->Nombre_Escuela = _nombre;
		this->codigo_escuela = _codigo;
		this->tarifa_mensual = _tarifamensual;
	}

	// printea los resultados que albergan las propiedades de la 
	// clase y el resultado del calculo.
	void RESULTADOS() {
		cout << "El nombre de la escuela es: " << Get_Nombre() << endl;
		cout << "Su codigo es: " << Get_Codigo() << endl;
		cout << "Alberga una poblacion de estudiantes de: " << Get_Cantidad() << endl;
		cout << "Tiene una tarifa mensual de: " << Get_Tarifa() << endl;
		cout << "Genera unan ganancia mensual de: " << Get_Ganancias() << endl;
	}

	// Esta funcion calcula las ganacias mensuales que puede tener 
	// La escuela o institucion.
	void calculo() {
		Ganancia_Mensual = Cantidad_Estudiantes * tarifa_mensual;
	}

	// Funciones para obtener valores guardado en los atributos

	string Get_Nombre() {
		return Nombre_Escuela;
	}
	string Get_Codigo() {
		return codigo_escuela;
	}
	int Get_Cantidad() {
		return Cantidad_Estudiantes;
	}
	int Get_Tarifa() {
		return tarifa_mensual;
	}
	int Get_Ganancias() {
		return Ganancia_Mensual;
	}

	// Funciones de Asignacion de valores esto sirve para modificar

	void Set_Nombre(string nombre) {
		this->Nombre_Escuela = nombre;
	}
	void Set_Codigo(string codigo) {
		this->codigo_escuela = codigo;
	}
	void Set_Tarifa(int tarifa) {
		this->tarifa_mensual = tarifa;
	}
	void Set_Cantidad(int cantidad) {
		this->Cantidad_Estudiantes = cantidad;
	}
};

