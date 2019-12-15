

// Aeropuerto.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>

using namespace std;

int main(int argc, char** argv)
{
	// Una tonelada equivale a 2204.62 Libra

    cout << "Bienvenido al AeroPuerto internacional de las America (SDQ)\n\n";
	cout << "Tenemos un Vuelo en el Boeing 737 MAX E, tiene una maxima Carga de 2 Tonelada\n ";

	int pasajeros = 0, maletas = 0; // Contador de Pasajeros y Maleta
	double Max_Persona = 210, Max_Maleta = 30; // Examinador de parametros
	double capacidad_Maxima = 4409.25; // Capacidad Maxima del Boeing 737 MAX E
	double capacidad_Maleta = 0, capacidad_persona = 0; // Total en todo momento de ambos
	double Ppasajero = 0, Pmaleta = 0; // Peso del pasajero y maleta en cada entrada.
	bool Comprobacion = true;
	bool falsopositivo = true;

	do {
		Comprobacion = false;
		do {
			cout << "\n\tSistema de Registro al avion \n\n";
			cout << "Peso Total hasta el momento: " << capacidad_Maleta + capacidad_persona << " de " << capacidad_Maxima;
			cout << "\n\nIngrese el peso del pasajero: ";
			cin >> Ppasajero;
			cout << "Ingrese el peso de la maleta: ";
			cin >> Pmaleta;
            
			if (Ppasajero > Max_Persona || Pmaleta > Max_Maleta)
			{
				system("cls");
				cout << "La capacidad Maxima de Persona es 210 Libras y maletas es 30 Libra, ha excedido el peso";
				cout << "\n Favor de ingresar otro pasajero. \n\n";
				system("pause");
				system("cls");
			}
			else
				Comprobacion = true;

			if (Ppasajero + Pmaleta + capacidad_persona + capacidad_Maleta > capacidad_Maxima) {
				system("cls");
				cout << "EL pasajero no puede abordar el avion se ha cerrado\n";
				cout << "debido a la capacidad maxima del avion.\n\n";
				system("pause");
				falsopositivo = false;
			}

		} while (!Comprobacion);
		system("cls");
		if (!falsopositivo)
			break;
		capacidad_persona += Ppasajero;
		capacidad_Maleta += Pmaleta;
		pasajeros++;
		maletas++;
	} while (Comprobacion);
	
	system("cls");
	cout << "\t Se ha cerrado el vuelo, el avion ha llegado a su capacidad maxima \n\n";
	cout << "Hay un total de " << pasajeros << " pasajeros\n";
	cout << "hay un total de " << maletas << " maletas\n\n";
	system("pause");
	
	return 0;
}


