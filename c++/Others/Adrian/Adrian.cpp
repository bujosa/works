// Adrian Clases Solucion.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <conio.h>
#include <string>
#include "Adrian_Dominguez.h"


using namespace std;

/* 
Explicacion de la clase: 

Esta clase llamada Adrian_Dominguez hace la representacion un producto la cual contiene 
los siguientes atributos :

Cantidad representa cantidad existente de un producto, luego le sigue la propiedad
de Itbis la cual guarda el valor de impuestos, tambien esta el de precio que establece 
el costo de ese nombreproducto y la ultima propiedad es ganancia lo cual calcula cuanto 
genera ese producto.

*/

int main()
{
	bool pase = true;
	string nombre = "";
	int cantidad = 0, precio = 0;
    double itbis = 0;

	// Creacion del Obj mediante el constructor
	Adrian_Dominguez obj{ cantidad, itbis, precio, nombre };

	while (pase)
	{
		system("cls");
		cout << "\tBienvenido a la Tienda de Adrian\n\n";
		cout << "Proceder a crear su producto para su tienda:\n\n";
		cout << " Ingrese el nombre del nuevo producto: ";
		cin >> nombre;
		obj.Set_Nombre(nombre); // Set del atributo
		cout << "\n Ingrese la cantidad disponible de ese producto: ";
		cin >> cantidad;
		obj.Set_Cantidad(cantidad);  // Set del atributo
		cout << "\n Ingrese precio del producto: ";
		cin >> precio;
		obj.Set_Precio(precio);  // Set del atributo
		cout << "\n Ingrese Itbis del producto | Rango aceptado entre 0.00 a 0.99 \n Digite Itbis: ";
		cin >> itbis;
		obj.Set_Itbis(itbis);  // Set del atributo

		// Validaciones de datos

		system("cls");

		if ( obj.Get_Nombre() == "")
			cout << " Ingrese un nombre no se acepta Nulo\n";
		else if (obj.Get_Cantidad() <= 0)
			cout << " Tiene que ingresar una cantidad mayor que 0\n";
		else if (obj.Get_Precio() <= 0)
			cout << " Tiene que ingresar un precio mayor que 0\n";
		else if (obj.Get_Itbis() <= 0 || obj.Get_Itbis() > 0.99)
			cout << " Los rango aceptados son entre 0.00 a 0.99\n";
		else
			pase = false;

		if (pase)
			_getch();

	}
	obj.Calculo(); //  Llamada a funcion de Calculo
	obj.RESULTADOS(); // Llamada a funcion Resultados
}
