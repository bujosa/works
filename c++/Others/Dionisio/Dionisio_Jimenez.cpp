// Dionisio_Jimenez.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h" // Esta libreria es para que funcione en visual Studio 2017 y 2019 
#include <iostream>
#include "Dionisio_Jimenez.h"
#include <string>

using namespace std;

/*
Descripcion de la clase Dionisio_Jimnez:

Esta clase representa a una Farmacia con sus caracteristicas de nombre
de la farmacia, nombre del producto en otras palabras medicamento, cantidad
existente de ese medicamento en la farmacia, precio de dicho medicamento y 
por ultimo las ganancias que puede generar el medicamento calculado por la funcion
calculo que multiplica La cantidad por el precio asi el resultado es el total 
de ganancia.

las demas funciones que existen en la clase son para mostrar datos o 
modificar datos existentes. 

*/
int main()
{
	// Creacion de un objeto tipo clase Dionisio mediante el constructor
	Dionisio_Jimenez Farmacia("", "", 0, 0);
	string Nombre = "", Medicamento = "";
	int Precio = 0, Cantidad = 0;

	while (true) {

		system("cls");

		cout << "-\t--\t---Sistema de Farmacias\n\n";

		cout << "Ingrese el nombre de su Farmacia: ";
		getline(cin, Nombre);
		Farmacia.set_NombreF(Nombre);
		cout << "\nIngrese el nombre del medicamento: ";
		getline(cin, Medicamento);
		Farmacia.set_NombreM(Medicamento);
		cout << "\nIngrese el precio del medicamento: ";
		cin >> Precio;
		Farmacia.set_PrecioM(Precio);
		cout << "\nIngrese la cantidad existente del medicamento: ";
		cin >> Cantidad;
		Farmacia.set_CantidadM(Cantidad);

		system("cls");

		if (Farmacia.get_NombreF() == "" || Farmacia.get_NombreM() == "")
			cout << "No pueden existir valores nulos \n\n";
		else if (Farmacia.get_PrecioM() <= 0 || Farmacia.get_CantidadM() <= 0)
			cout << "No pueden haber valores iguales o menores que el numero cero\n\n";
		else
			break;
		system("pause");
	}

	Farmacia.calculo(); // Hace el calculo para generar las ganacias totales por la venta de una medicina
	Farmacia.RESULTADOS(); // Muestras los valores de los atributos de la clase Dionisio
	cout << endl;
}



