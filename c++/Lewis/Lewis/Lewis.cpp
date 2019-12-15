// Esta libreria es solo para visual Studio 2017 en adelante  #include "pch.h"

#include <iostream>
#include <string>

using namespace std;


void ESCRITURA();
void LECTURA();
void ALGORITMO();

int **Vector;
int N = 0;

int main() {

	std::string desicion = "ingresa";
	bool Path = true;

	while (desicion != "SI")
	{
		while (Path)
		{
			std::system("CLS");
			std::cout << "\t--------------*---*----------------\t\n";
			std::cout << "\t----------------*------------------\t\n";
			std::cout << "\t--------------*---*----------------\t\n\n";
			std::cout << "Favor de ingresar la dimension de la Matriz: ";
			std::cin >> N;
			if (N < 0)
			{
				std::cout << "\tAviso: ";
				std::cout << "Dimension de Matriz Invalidad, favor volver a ingresar una dimension valida \n\n";
				std::system("pause");
			}
			else
				Path = false;
		}

	
		Vector = new int *[N];
		int i = 0;
		while (i < N)
		{
			Vector[i] = new int[N];
			i++;
		}

		LECTURA();
		ESCRITURA();
		ALGORITMO();
		ESCRITURA();

		std::system("pause");

		while (Path == false)
		{
			std::system("CLS");

			std::cout << "Desea salir del programa (SI/NO):\n";
			std::getline(cin, desicion);

			if (desicion == "SI" || desicion == "si")
			{
				desicion = "SI";
				Path = true;
			}
			if (desicion == "NO" || desicion == "no")
				Path = true;
		}
	}
}

void LECTURA() {

	std::system("CLS");

	int i = 0;
	while(i<N)
	{
		for (int j = 0; j < N; j++)
		{
			std::cout << "[" << i << "][" << j << "]: ";
			std::cin >> Vector[i][j];
		}
		i++;
	}
}


void ESCRITURA() {

	std::system("CLS");

	int i = 0;
	while (i < N) {

		for (int j = 0; j < N; j++)
			std::cout << Vector[i][j] << "\t";
		std::cout << "\n";
		i++;
	}

}


void ALGORITMO() {

	std::system("CLS");
	// Seccio 01
	int columna = 0;
	while (columna < N)
	{
		int fila = 0;
		while(fila < N)
		{
			if (columna == fila)
				Vector[columna][fila] = 0;
			if (columna + fila == N - 1)
				Vector[columna][fila] = 0;
			fila++;
		}
		columna++;
	}
}


