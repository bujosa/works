// Kiara.cpp : This file contains the 'main' function. 
#include "pch.h"

#include <iostream>
#include <string>

int n = 0;
int **matriz;

using namespace std;

void ESCRITURA();
void LECTURA();
void ALGORITMO();

int main() {

	std::string data = "e";
	bool pass = true;
	while (data != "SI")
	{
		while (pass)
		{

			std::system("cls");
			std::cout << "\t Bienvenido al Sistema de Matriz \n\n";
			std::cout << "Ingrese la dimension de su Matriz: ";
			std::cin >> n;
			if (n < 0)
			{
				std::cout <<"Dimension de Matriz Invalidad, favor volver a ingresar una dimension valida \n\n";
				std::system("pause");
			}
			else
				pass = false;
		}

		LECTURA();
		std::system("CLS");
		ESCRITURA();
		std::system("CLS");
		ALGORITMO();
		std::system("CLS");
		ESCRITURA();

		std::system("pause");

		while (pass == false) 
		{
			std::system("CLS");
			std::cout << "Desea salir del programa (SI/NO):\n";
			std::getline(cin,data);
			
			if (data == "SI" || data == "Si" || data == "si" | data == "sI")
			{
				pass = true;
				data = "SI";
			}
			if (data == "NO" || data == "no" || data == "nO" | data == "No") {
				pass = true;
			}
		}
	}
	std::system("CLS");
	std::cout << "Hasta Luego\n";
}

void LECTURA() {
   
	matriz = new int *[n];

	for (int i = 0; i < n; i++) 
		matriz[i] = new int[n];

	for (int i = 0; i < n; i++) 
	{
		for (int j = 0; j < n; j++)
		{
			std::cout << "Posicion [" << i << "][" << j << "]: ";
			std::cin >> matriz[i][j];
		}
	}
}
void ESCRITURA() {
	for (int i = 0; i < n; i++) {
		
		for (int j = 0; j < n; j++)
			std::cout << matriz[i][j] << "\t";
		std::cout << "\n";
	}
}


void ALGORITMO() {

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			// SECCION 01: 
			if (i == j)
			    matriz[i][j] = 0;
			if (i + j == n - 1)
				matriz[i][j] = 0;
		}
	}
}



// SECCION 03: 
void ALGORITMO() {
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++) {

			if (i ==  0)
				matriz[i][j] = 0;
			if (i == n - 1)
				matriz[i][j] = 0;
			if (j == 0)
				matriz[i][j] = 0;
			if (j == n - 1)
				matriz[i][j] = 0;
	
		}
	}
}

