#pragma once

#include <iostream>
#include <string>
#include <conio.h>

using namespace std;

class Contactos
{

private:

	string matriz[100][2];
	int contador = 1;
	
public:
	string NombreCompleto; // Atributos
	string Telefono; // Atributos
	Contactos(string x); // contructor por default sin tocar.

	void agregar(string nombre, string telefono) {

		matriz[contador][0] = nombre;
		matriz[contador][1] = telefono;
		contador++;
		cout << "Contacto agregado sastifatoriamente";
		system("pause");
	}
	void Buscar(string nombre) {
		bool validar = true;

		for (int i = 0; i < 100; i++) {
			if (matriz[i][0] == nombre) {
				cout << "El numero es: " << matriz[i][1];
				validar = false;
				break;
			}
		}
		if (validar)
			cout << "El contacto no existe";
		system("pause");
	}
	void CambiarTelefono(string nombre) {
		bool validar = true;
		string modificador;
		for (int i = 0; i < 100; i++) {
			if (matriz[i][0] == nombre) {
				cout << "Ingrese el numero: ";
				getline(cin, modificador);
				matriz[i][1] = modificador;
				validar = false;
				break;
			}
		}
		if (validar)
			cout << "El contacto no existe";
		else
			cout << "Cambio exitoso";
		system("pause");
	}

};


