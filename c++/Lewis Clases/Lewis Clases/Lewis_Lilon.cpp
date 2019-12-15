
#include "pch.h" // Esta libreria es necesaria para correrlo en visual Studio 2017 en adelante
#include "Lewis_Lilon.h"
#include <iostream>
#include <string>
#include <conio.h>


using namespace std;

/*
Esta clase que creamos en el archivo .H llamado Lewis_Lilon representa una escuela
y tiene como atributos, cantidad de alumnos que existen en esa escuela,
la tarifa que pagan mensual a la institucion, y tiene funciones de calculo que lo hace
es calcular las ganacias mensuales que tiene la escuela. Ademas un atributo
que hace alusion al nombre de la escuela y codigo de dicha escuela.

La funcion de RESULTADOS simplemente muestra lo que posee cada valor de las
5 propiedades que tiene la clase entre esta el calculo tambien que se realizo
con dicha funcion. 

En este Main que vera a continuacion se procedera a cumplir con la creacion
de un objeto tipo esa clase para proceder asignarles valores.

*/


int main()
{
	int cantida = 0, tarifa = 0;
	string nombre = "", codigo = "";
	Lewis_Lilon Escuela(0, 0, "", ""); // Contructor con valores por default 
	// Se lo asignaremos ahora.
	while (true) {
		system("cls");
		cout << "\t\tBienvenido al sistema Escolar\n\n";
		cout << " Ingrese nombre de la escuela: ";
		getline(cin,nombre);
		Escuela.Set_Nombre(nombre);
		cout << "\n Ingrese Codigo de la escuela: ";
		getline(cin, codigo);
		Escuela.Set_Codigo(codigo);
		cout << "\n Ingrese cantidad de estudiantes: ";
		cin >> cantida;
		Escuela.Set_Cantidad(cantida);
		cout << "\n Ingrese tarifa mensual: ";
		cin >> tarifa;
		Escuela.Set_Tarifa(tarifa);

		system("cls");
		if (Escuela.Get_Nombre() == "") {
			cout << "Tiene que ingresar un nombre para la escuela";
		}
		else if (Escuela.Get_Codigo() == "") {
			cout << "Tienes que ingresar un codigo para la escuela";
		}
		else if (Escuela.Get_Cantidad() <= 0) {
			cout << "Tiene que existir por lo menos un estudiante no menos";
		}
		else if (Escuela.Get_Tarifa() <= 0) {
			cout << "La tarifa de la escuela tiene que ser por lo menos de valor 1 no menos";
		}
		else
			break;

		system("pause");
	}

	Escuela.calculo(); // Realiza la operacion de calculo
	Escuela.RESULTADOS(); // muestra los resultados de las
	// propiedades que aloja la clase + el calculo.
}
