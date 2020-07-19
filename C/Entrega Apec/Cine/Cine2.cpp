
#include <iostream>
#include <string>
#include <vector>

using namespace std;


string L = "Lunes";
string M = "Martes";
string Mi = "Miercoles";
string J = "Jueves";
string V = "Viernes";
string S = "Sabado";
string D = "Domingo";

int CantidadP = 0;
int CantidadG = 0;
int Combo = 0;
int Tanda = 0;
string Dia = "";
string semana[] = { "Lunes","Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
string tanda[] = { "5:00 Pm" , "7:00pm", "10:00Pm" };
bool validaciones = true;
int Mayores = 0;
int Menores = 0;
int Entrada = 0;
int opcion = 0, opcion2 = 0;
int x = 0;

int **Edades;

struct User {
	int Dia;
	int Tanda;
	int Mayores;
	int Menores;
};

vector <User> datos;

int main(int argc, char** argv)
{
	cout << "\tBienvenido al cine de Downtown Center | Caribean Cinemas\n\n";
	cout << "Actualmente existe una promocion para regalar  a los asistentes \n";
	cout << "un refresco, un chocolate, y unas palomitas de maiz, por persona por grupo\n";
	cout << "Restriccion: Es valido solo si se tiene por lo menos 2 ni�os, para funcion de las 5 pm\n";
	cout << "entre Lunes a Jueves\n\n";

	cout << "Pelicula en Cartelera: Captain Marvel\n\n";
	cout << "Ingresa cantidad de Grupos: ";
	cin >> CantidadG;
	do {
		do {


			cout << "Ingrese cantidad de Personas del grupo: ";
			cin >> CantidadP;


			if (CantidadP <= 0)
			{
				cout << "No se aceptan Nulos ni negativos\n\n";
				system("pause");
				system("cls");
			}
			else
				validaciones = false;
		} while (validaciones);


		system("cls");
		for (int i = 0; i < CantidadP; i++) {
			cout << "Ingrese la Edad del miembro " << i + 1 << " :";
			cin >> Entrada;
			if (Entrada >= 18)
				Mayores++;
			else
				Menores++;
		}

		do {
			system("cls");
			cout << "Eliga que dia de Semana van: \n\n";
			cout << "1. " << L;
			cout << "\n2. " << M;
			cout << "\n3. " << Mi;
			cout << "\n4. " << J;
			cout << "\n5. " << V;
			cout << "\n6. " << S;
			cout << "\n7. " << D << endl << endl;
			cin >> opcion;
			if (opcion < 8 && opcion > 0)
				validaciones = true;
			else {
				cout << "Solo se pueden elegir las opciones establecidas\n\n";
				system("pause");
				system("cls");
			}
		} while (!validaciones);

		do {
			system("cls");
			if (opcion <= 4)
			{
				cout << "Tanda Disponible: \n";
				cout << "1. 5:00 Pm\n";
				cout << "2. 7:00 Pm\n";
				cin >> opcion2;
				if (opcion2 < 3 && opcion > 0)
					validaciones = false;
				else
					validaciones = true;

			}
			else {
				cout << "Tanda Disponible: \n";
				cout << "1. 5:00 Pm\n";
				cout << "2. 7:00 Pm\n";
				cout << "3. 10:00 Pm\n";
				cin >> opcion2;
				if (opcion2 < 4 && opcion > 0)
					validaciones = false;
				else
					validaciones = true;

			}

			if (validaciones)
				cout << "Tiene que elegir las opciones establecidas \n";
			system("pause");
			system("cls");
		} while (validaciones);

		
		x++;

		User nuevo;
		nuevo.Menores = Menores;
		nuevo.Mayores = Mayores;
		nuevo.Dia = opcion;
		nuevo.Tanda = opcion2;

		datos.push_back(nuevo);

	} while (x < CantidadG);

	system("cls");
	
	for (int i = 0; i < CantidadG; i++) {

		cout << "\n\n\tGrupo " << i + 1 << " : \n\n";

		if (datos[i].Menores >= 2 && datos[i].Tanda == 1 && datos[i].Dia > 0 && datos[i].Dia)
		{
			Combo++;
			cout << "\nSe han otorgado: " << Combo;
			cout << "\nMayores de edad hay: " << datos[i].Mayores;
			cout << "\nMenores de edad hay: " << datos[i].Menores;
			cout << "\nDia de la semama: " << semana[datos[i].Dia - 1];
			cout << "\nTanda :" << tanda[datos[i].Tanda - 1];
		}
		else {
			
			cout << "\nNo Se han otorgado para este grupo ";
			cout << "\nMayores de edad hay: " << datos[i].Mayores;
			cout << "\nMenores de edad hay: " << datos[i].Menores;
			cout << "\nDia de la semama: " << semana[datos[i].Dia - 1];
			cout << "\nTanda :" << tanda[datos[i].Tanda - 1];
		}
	}
	system("pause");

return 0;
}



