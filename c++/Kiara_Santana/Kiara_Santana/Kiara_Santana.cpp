// Kiara_Santana.cpp this file is created in visual Studio 2017 
// This code is fully functional for later versions of visual studio.

#include "pch.h" // Esta libreria es para que funcione en visual studio 2017 en adelante
#include <iostream>
#include "Kiara_Santana.h" // Esta libreria es para agregar la clase
#include <string>

//using namespace std;


/*

La clase de Kiara_Santana.h representa a una floristeria 
una tienda que vende flores la clase lo que permite es crear flores
para el sistema, agregarle su nombre su color, el precio que vale,
la cantidad disponible y unas funciones de calculo que le permiten
saber la ganacias que puede tener si vende todas las flores disponibles.

Ese resultado se guarda en un atributo llamada Ganancia_Venta_Total.

Mas las funciones de Set y Get que permiten operar con variables privada
como lo es el caso de las propiedades de la clase.

*/

int main()
{
	// Segmento de variables 
	Kiara_Santana Rosa("","",0,0); // Constructor de la clase
	string Nombre = "", Color = "";
	int Cantidad = 0, Costo = 0;
	bool validar = true;
	// Fin de segmento

	do {

		std::system("cls");
		std::cout << "\t\tFloresteria Azucena\n\n";

		std::cout << "Ingresar Nombre de la Flor: ";
		std::getline(cin,Nombre);
		Rosa.Set_Nombre(Nombre);

		std::cout << "\nIngresar color de la Flor: ";
		std::getline(cin, Color);;
		Rosa.Set_Color(Color);

		std::cout << "\nIngresar Cantidad disponible: ";
		std::cin >> Cantidad;
		Rosa.Set_Cantidad(Cantidad);

		std::cout << "\nIngresar Precio de la Flor: ";
		std::cin >> Costo;
		Rosa.Set_Costo(Costo);

		std::system("cls");

		if (Rosa.Get_Nombre() == "")
			std::cout << "Tiene que asignar un nombre a la flor";
		else if (Rosa.Get_Color() == "")
			std::cout << "Tiene que asignar un color a la flor";
		else if (Rosa.Get_Cantidad() <= 0)
			std::cout << "Advertencia tiene que ser mayor que Cero la cantidad";
		else if (Rosa.Get_Costo() <= 0)
			std::cout << "El precio de la rosa tiene que ser mayor que 0";
		else
			validar = false;

		if(validar)
		  std::system("pause");

	} while (validar == true);

	Rosa.calculo(); // Llama a la funcion de calculo
	std::cout << "\n\n";
	Rosa.RESULTADOS();// Muestra los resultados asignados
	std::cout << "\n\n";
}




