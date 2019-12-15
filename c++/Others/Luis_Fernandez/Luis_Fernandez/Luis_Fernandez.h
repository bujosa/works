#pragma once
#include <iostream>
#include <string>

using namespace std;

class Luis_Fernandez
{
private:
	string Oficina;
	string NombreUsuario;
	int Costo;
	double impuestos;
	double Gastos;

public:
	Luis_Fernandez(string oficina, string nombre, int costo, double impuesto) {

		this->Oficina = oficina;
		this->NombreUsuario = nombre;
		this->Costo = costo;
		this->impuestos = impuesto;
	}

	void calculo() {
		this->Gastos = ((Costo*impuestos) + Costo);
	}

	void RESULTADOS() {
		cout << "Sistema de Contabilidad para oficinas: \n\n";
		cout << "El nombre de la oficina es: " << get_Oficina() << endl;
		cout << "El nombre del cliente: " << get_Cliente() << endl;
		cout << "El costo que genera: " << get_Costo() << endl;
		cout << "Impuesto que genera: " << (int)(get_Impuesto() *get_Costo()) << endl;
		cout << "Gasto Total del oficina: " << (int)get_Gastos() << endl;
	}
	void set_Oficina(string oficina) {
		this->Oficina = oficina;
	}
	void set_Cliente(string cliente) {
		this->NombreUsuario = cliente;
	}
	void set_Costo(int costo) {
		this->Costo = costo;
	}
	void set_Impuestos(double impuestos) {
		this->impuestos = impuestos;
	}
	string get_Oficina() {
		return this->Oficina;
	}
	string get_Cliente() {
		return this->NombreUsuario;
	}
	int get_Costo() {
		return Costo;
	}
	double get_Impuesto() {
		return impuestos;
	}
	double get_Gastos() {
		return Gastos;
	}
};

