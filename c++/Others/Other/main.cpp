

#include <iostream>
#include "Contactos.h"
#include <string>
#include <conio.h>

using namespace std;


Contactos c(""); // Contrusctor por default
int main(int argc, char** argv)
{
	int opcion = 0;

	do
	{
		system("cls");
		cout << "\t\t Agenda de Contactos\n\n";
		cout << "\n1. Agregar un Contacto";
		cout << "\n2. Cambiar datos del Contacto";
		cout << "\n3. Visualizar datos del Contacto";
		cout << "\n4. Salir";

		cin >> opcion;

		system("cls");

		switch (opcion) {
		case 1:
			cout << "\tNuevo contacto\n\n";
			cout << "Ingrese el nombre: ";
			getline(cin, c.NombreCompleto);
			cout << "Ingrese el numero: ";
			getline(cin, c.Telefono);
			c.agregar(c.NombreCompleto, c.Telefono);
			break;
		case 2:
			cout << "\t Cambio de datos \n\n";
			cout << "Ingrese el nombre para buscar el contacto: ";
			getline(cin, c.NombreCompleto);
			c.CambiarTelefono(c.NombreCompleto);
			break;
		case 3:
			cout << "\t Busquedad \n\n";
			cout << "\t Ingrese nombre de usuario para buscarlo: ";
			getline(cin, c.NombreCompleto);
			break;
		case 4:
			break;
		default:
			cout << "Solo escribir las opciones permitidas";
			system("pause");
			break;
		}
	} while (opcion != 4);

	system("cls");
	cout << "Gracias por usar nuestra aplicacion";
	system("pause");

return 0;
}




