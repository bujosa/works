
// Creado en visual Studio 2017 si necesita ejecutarlo ahi usar libreria 

#include "pch.h" 
#include <iostream>
#include<vector>

using namespace std;
vector<double> Calcular(double&TOTAL);

double Cargo = 0.03;
double Adicional = 0.01;
vector<double> datos = { 0 };
double precio_articulo = 0;

int main() {

	int TOTAL = 0;


	char data = 'e';
	while (data != 'S')
	{
		while (data != 'N')
		{
			std::system("cls");
			std::cout << "\t Bienvenido a la Tienda Kiara'Store \n\n";
			std::cout << "Para Salir escribir Letra S para continuar N\n";
			std::cin >> data;
			if (data == 'n')
				data = 'N';
			if (data == 's')
			{
				data = 'S';
				break;
			}

		}
		if (data != 'S')
		{
			std::cout << "\n\n\tEscribir Codigo de Promocion Valido para el descuento: \n ";
			std::cin >> data;
		}
		if (data == 's')
		{
			data = 'S';
		}
		switch (data)
		{
		case 'b':
		case 'B':
		case 'D':
		case 'd':
		case 'e':
		case 'E':
		case 'X':
		case 'x':
		case 'j':
		case 'J':
		case 'P':
		case 'p':
			std::system("cls");
			std::cout << "\nIntroduzca el precio del articulo: \n";
			precio_articulo = 0;
			std::cin >> precio_articulo;
			datos = Calcular(precio_articulo);
			system("cls");
			std::cout << "\nPrecio de Compra : " << precio_articulo;
			std::cout << "\nCargo Por Servicio (3%) : " << datos[0];
			std::cout << "\nCodigo de Promocion_ Descuento de promocion(1%) : " << datos[1];
			std::cout << "\nPrecio Final: " << precio_articulo + datos[0] - datos[1] << std::endl;
			std::system("pause");
			break;
		case 'S':
		case 's':
			break;
		default:
			std::cout << "El codigo digitado no aplica para el articulo \n";
			std::cout << "Asi que no tiene descuento para el articulo \n";
			std::cout << "\nIntroduzca el precio del articulo: \n";
			precio_articulo = 0;
			std::cin >> precio_articulo;
			Adicional = 0;
			datos = Calcular(precio_articulo);
			std::system("cls");
			std::cout << "\nPrecio de Compra : " << precio_articulo;
			std::cout << "\nCargo Por Servicio (3%) : " << datos[0];
			std::cout << "\nCodigo de promocion no Aplica \n";
			std::cout << "\nPrecio Final: " << precio_articulo + datos[0] << std::endl;;
			Adicional = 0.01;
			std::system("pause");
			break;

		}
	}
	std::system("CLS");
	std::cout << "Gracias Por visitarnos\n";
}

vector<double> Calcular(double& TOTAL)
{

	vector<double> funcion;
	if (Adicional == 0)
	{
		double a = precio_articulo * Cargo;
		funcion.push_back(a);
	}
	else {
		double a = precio_articulo * Cargo;
		double b = precio_articulo * Adicional;
		funcion.push_back(a);
		funcion.push_back(b);
	}
	return funcion;
}
