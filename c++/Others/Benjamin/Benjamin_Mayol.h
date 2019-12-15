#pragma once

#include<string>
#include<iostream>

using namespace std;

class Benjamin_Mayol
{
private:

	// Las 5 propiedades privadas

	string Hotel;
	string Huesped;
	int Costo;
	int Dias;
	long double Ganancias;

public:

	// Constructor de la Clase Benjamin_Mayol

	Benjamin_Mayol(string hotel, string huesped, int costo, int dias) {

		this->Hotel = hotel;
		this->Huesped = huesped;
		this->Costo = costo;
		this->Dias = dias;
	}

	long double Impuestos;

	// recibira un parametro tipo double
	void calculo(long double impuestos) {
		long double x = (Costo*Dias*impuestos); // generacion de costos
		this->Impuestos = x; // atributo global public
		this->Ganancias = Costo * Dias + x; // atributo privado 
	}
	// Calculo de los impuesto dias y costo de estadia

	void RESULTADOS() {

		cout << " \t\tSistema Hotelero \n\n";
		cout << "Nombre del Hotel: " << get_Hotel() << endl;
		cout << "Nombre del Huesped: " << get_Huesped() << endl;
		cout << "Precio por Noche: " << get_Costo() << endl;
		cout << "Estadias que dura el Huespues: " << get_Dias() << endl;
		cout << "Impuestos generados: " << (int)Impuestos << endl;
		cout << "Ganacia Total del Hotel: " << (int)get_Ganancias() << endl;
	}

	void set_Hotel(string hotel) {
		this->Hotel = hotel;
	}
	void set_Huesped(string huesped) {
		this->Huesped = huesped;
	}
	void set_Costo(int costo) {
		this->Costo = costo;
	}
	void set_Dias(int dias) {
		this->Dias = dias;
	}

	string get_Hotel() {
		return this->Hotel;
	}
	string get_Huesped() {
		return this->Huesped;
	}
	int get_Costo() {
		return this->Costo;
	}
	int get_Dias() {
		return this->Dias;
	}
	float get_Ganancias() {
		return this->Ganancias;
	}

};

