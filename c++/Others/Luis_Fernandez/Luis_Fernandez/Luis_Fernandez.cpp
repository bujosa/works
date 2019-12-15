// Luis_Fernandez.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h" // Esta libreria es para que funcione en visual Estudio 2017 y 2019
#include <iostream>
#include <string>
#include "Luis_Fernandez.h"

using namespace std;

/*

   Mi clase llamada Luis_Fernandez trata de emitar una especie de contabilidad financiera
   para oficinas la cual tendra 5 propiedades o atributos privado los cuales contiene
   los siguientes atributos uno para el Nombredelcliente, uno para el nombre de la oficina
   otro donde se almacenan los gastos que genera la oficina llamada costo, la de impuestos
   guarda el porciento en estilo decimal para luego ser calculado y decir los gastos mensuales que
   genera la oficina mediante una funcion de calculo que es almacenada en la propiedad Gastos.

*/
int main()
{
	Luis_Fernandez Oficina("", "", 0, 0);
	string oficina = "", cliente = "";
	double costo = 0, impuesto = 0;

	cout << "\tBienvenido al sistema de Contabilidad para oficinas\n\n";
	cout << "Ingrese el nombre de la oficina: ";
	getline(cin, oficina);
	cout << "Ingrese el nombre del cliente: ";
	getline(cin, cliente);
	cout << "Ingrese el costo que tiene la oficina: ";
	cin >> costo;
	cout << "\n(Parametro del impuesto entre 0.00 a 0.99) \nIngrese el porciento que le cobran a la oficina:  ";
	cin >> impuesto;

	Oficina.set_Oficina(oficina);
	Oficina.set_Cliente(cliente);
	Oficina.set_Costo(costo);
	Oficina.set_Impuestos(impuesto);
	system("cls");
	Oficina.calculo();
	Oficina.RESULTADOS();
	cout << endl;
	system("pause");
	
}

