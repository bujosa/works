#pragma once
#include <iostream>
#include <string>

using namespace std;

class Jatna_Tito
{
private:

	string Nombre_Empresa;
	string Nombre_Empleado;
	string Id_Empleado;
	int Salario_Mensual;
	int Salario_Anual; // Variable que sera calculada en la funcion

public:
	Jatna_Tito(string Empresa, string Empleado, string Id, int Salario)
	{
		this->Nombre_Empresa = Empresa;
		this->Nombre_Empleado = Empleado;
		this->Id_Empleado = Id;
		this->Salario_Mensual = Salario;
	}

	void RESULTADOS() {
		cout << "Empresa: " << get_Empresa();
		cout << "\nNombre del Empleado: " << get_Empleado();
		cout << "\nID: " << get_ID();
		cout << "\nSalario mensual: " << get_Salario();
		cout << "\nMonto Anual: " << get_Anual();
	}
	void calculo() {
		Salario_Anual = Salario_Mensual * 12; // El salario por los meses del año
	}

	// SET AND GET del atributo nombre de empresa.
	string get_Empresa() {
		return Nombre_Empresa;
	}
	void set_Empresa(string empresa) {
		this->Nombre_Empresa = empresa;
	}

	// SET AND GET del atributo Nombre_Empelado
	string get_Empleado() {
		return Nombre_Empleado;
	}
	void set_Empleado(string empleado) {
		this->Nombre_Empleado = empleado;
	}

	// SET AND GET del atributo Id_Empleado
	string get_ID() {
		return Id_Empleado;
	}
	void set_ID(string ID) {
		this->Id_Empleado = ID;
	}

	// SET AND GET del atributo Salario_Mensual
	int get_Salario() {
		return Salario_Mensual;
	}
	void set_Salario(int Salario) {
		this->Salario_Mensual = Salario;
	}

	// GET del atributo Salario_Anual
	int get_Anual() {
		return Salario_Anual;
	}
};

