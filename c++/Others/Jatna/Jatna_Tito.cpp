#include "pch.h" // Libreria para que pueda funcionar en una version 
// de visual studio igual a 2017 o superior.
#include "Jatna_Tito.h"
#include <iostream>
#include <string>

using namespace std;


// Constructor llamado e instanciado.
Jatna_Tito Empleado("", "", "", 0);
bool Asignacion();

/*
Descripcion de la clase:

La clase de Jatna_Tito lo que hace es lo siguiente, tiene unas 
series de atributos relacionado con un empleado trata de simular 
un sistema donde tu ingresas a un empleado, de una empresa
con sus respectivo ID de empleado y su salio mensual y te dice 
cuanta gana anualmente mediante la funcion de calculo. 

*/
int main()
{
	bool Aceptado = true;
	do {
		Aceptado = Asignacion();
		if (Aceptado)
			system("pause");
	} while (Aceptado);
    
	Empleado.calculo(); // Realiza el calculo de las ganancias de un 
	// empleado anual.
	Empleado.RESULTADOS(); // Muestra los datos que tienen
	cout << "\n\n";
	// las propiedades de la clase
}

bool Asignacion() {

	string empleado = "" , empresa = "", ID = "";
	int salario = 0;
	system("cls");
	cout << "\tBienvenido al sistema de Empresas y Empleados\n\n";
	cout << "Ingrese el nombre de la empresa: ";
	getline(cin,empresa);
	Empleado.set_Empresa(empresa);
	cout << "\nIngrese el nombre del empleado: ";
	getline(cin, empleado);
	Empleado.set_Empleado(empleado);
	cout << "\nIngrese ID del empleado: ";
	cin >> ID;
	Empleado.set_ID(ID);
	cout << "\nIngrese Salario del empleado: ";
	cin >> salario;
	Empleado.set_Salario(salario);

	system("cls");
	if (Empleado.get_Empresa() == "" || Empleado.get_Empleado() == "" || Empleado.get_ID() == "")
		cout << "No pueden existir valores nulo ingresar otra vez";
	else if (Empleado.get_Salario() <= 0)
		cout << "No puede tener un salio igual o menor de 0";
	else
		return false;
	return true;
}