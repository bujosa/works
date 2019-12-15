
#include <iostream>
#include <string>
#include "pch.h"

int **  Lectura(int n);
void Escritura(int n, int ** matriz);
int ** Algoritmo(int n, int ** matriz);

using namespace std;

int main(int argc, const char * argv[]) {
	// insert code here...
	bool terminar = false;
	while (!terminar) {
		int n = 0;
		cout << "Tamano de la matriz: ";
		cin >> n;

		if (n < 0) {
			cout << "Dimension de Matriz invalida, favor volver a ingresar una dimension valida" << endl;
		}
		else {
			int ** matriz;
			matriz = Lectura(n);
			Escritura(n, matriz);
			matriz = Algoritmo(n, matriz);
			Escritura(n, matriz);

			bool ny = true;
			while (ny) {
				string res;
				cout << "Desea salir del programa (SI/NO): ";
				cin >> res;

				if (res == "SI") {
					ny = false;
					terminar = true;
				}
				else if (res == "NO") {
					ny = false;
				}
				else {
					cout << "Ingrese SI o NO";
				}

			}
		}
	}
	return 0;
}

int ** Lectura(int n) {
	int ** matriz = new int*[n];

	cout << "LLenar: " << endl;

	for (int i = 0; i < n; i++) {
		matriz[i] = new int[n];
		for (int j = 0; j < n; j++) {
			int num = 0;
			cout << "matriz[" << i << "," << j << "] = ";
			cin >> num;
			matriz[i][j] = num;
		}
	}

	return matriz;
}

void Escritura(int n, int ** matriz) {
	cout << endl;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++) {
			cout << matriz[i][j] << " ";
		}
		cout << "\n";
	}
}

int ** Algoritmo(int n, int ** matriz) {
	int ** M = new int*[n];
	for (int i = 0; i < n; i++) {
		M[i] = new int[n];
		for (int j = 0; j < n; j++) {
			if (j == i) {
				M[i][j] = 0;
			}
			else if (j == (n - 1) - i) {
				M[i][j] = 0;
			}
			else {
				M[i][j] = matriz[i][j];
			}
		}
	}

	return M;
}
