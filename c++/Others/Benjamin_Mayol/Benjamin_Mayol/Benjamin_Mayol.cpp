#include "pch.h"
#include <iostream>
#include <string>
#include "Benjamin_Mayol.h"


using namespace std;


// Variables Globales 

string HotelN = "", Huesped = "";
int CostoEstadia = 0, CantidadDias = 0;
long double Impuestos = 0.00;
Benjamin_Mayol Hotel("", "", 0, 0);

void Asignaciones();
void Modificacion();

/*

La clase Benjamin_Mayol: representa el sistema de registro de un hotel, donde se hacen calculos
esos calculos estan relacionados con las propiedades de Costo y cantidad de dias que durara un cliente
en el hotel, ese cliente estara guardada en el atributo de Hueped de la clase junto con el nombre
del hotel en su atributo Hotel, el quinto y ultimo atributo esta relacionado con la variable 
de calculo llamada Ganancias la cual obtiene sus valores de la funcion Calculo, la funcion de RESULTADOS
se encarga de mostrar los resultados mediante get que accedan a los atributos para sacar sus valores que estan
guardados.

*/

int main()
{
    cout << "\t\tBienvenido al sistema Hotelero de Calculo de Estadia\n\n";
	Asignaciones();
	system("cls");
	Modificacion();
	cout << endl << endl;
	system("pause");

}

void Asignaciones() {

	cout << "Ingrese el nombre del Hotel: ";
	getline(cin, HotelN);
	cout << "Ingrese el nombre del Huesped: ";
	getline(cin, Huesped);
	cout << "Ingrese el costo de la noche en el Hotel: ";
	cin >> CostoEstadia;
	cout << "Ingrese la cantidad de noches que durara el cliente en el Hotel: ";
	cin >> CantidadDias;
	cout << "Ingrese el porcentaje de Impuestos ejemplo (0.15):  ";
	cin >> Impuestos;

}

void Modificacion() {

	Hotel.set_Hotel(HotelN);
	Hotel.set_Huesped(Huesped);
	Hotel.set_Costo(CostoEstadia);
	Hotel.set_Dias(CantidadDias);
	Hotel.calculo(Impuestos);
	Hotel.RESULTADOS();
}
