#include "pch.h"
#include <iostream>
#include <string>
#include "Laura_Baez.h"


using namespace std;

// Declaraciones de variable 


void Funciones();

Laura_Baez Tienda1("", "", 0, 0);
string Nombre = "";
string Producto = "";
int Cantidad = 0;
int Precio = 0;

/*
			La clase Luisa_Baez.h 

			esta clase define unas series de propiedades que hacen aluccion a un supermercado
			que tiene una serie de productos, permite agregar un nombre de la tienda, nombre
			del producto para saber cual producto es el que se esta registrando, una propiedad
			de canridad que permite saber cuantos productos existen de este tipo, otra de precio
			que permite decir cuanto vale este producto y al final. La quinta propiedad es realizada
			mediante la funcion de calculo la cual calcula la operacion de cuales seria las ganacias
			totales en venta. 

			Funcion RESULTADOS muestra los datos que tienen estas propiedades encapsuladas mediante
			una funcion get que permita acceder esos datos de manera segura sin acceder directamente
			a ellos. Esto es una buena practica. 
*/

int main()
{
	cout << "\t \t Bienvenido al sistema de Calculo de ganancias de un Producto en tienda\n\n";
	cout << "Ingrese el nombre de la tienda: ";
	getline(cin, Nombre);
	cout << "\nIngrese el nombre del producto: ";
	getline(cin, Producto);
	cout << "\nIngrese cantidad existente del producto: ";
	cin >> Cantidad;
	cout << "\Ingrese precio del producto: ";
	cin >> Precio;
   
	Funciones(); // Llamar funcion que se encarga de resto de la parte operativa 
	// del programa.
}

void Funciones() {

	// Acceso a las propiedades mediante Set propiedades que estan privadas
	// Pero que usando estas funciones pueden ser editadas. Sin tocarlas 
	// directamentes a ellas. Esta propiedad se llama Encapsulamiento.

	Tienda1.set_Nombre(Nombre); 
	Tienda1.set_Producto(Producto);
	Tienda1.set_Cantidad(Cantidad);
	Tienda1.set_Precio(Precio);

	Tienda1.calculo(); // Llama a la funcion de Calculo
	system("cls");
	Tienda1.RESULTADOS(); 
	// Muestras los resultados en pantalla y lo que dio el calculo.
	// Teniendo un acceso total a 5 propiedades del sistema.
	cout << "\n";
	system("pause");
}
