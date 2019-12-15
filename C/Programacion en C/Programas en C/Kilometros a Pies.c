#include <stdio.h>

int main(int argc, char** argv) {
	printf("Digite un numero Para convertirlo de Kilometro a pies: ");
	float b = 3280.84;
	int a;
	scanf("%d",&a);
	b = a*b;
	printf("El numero que escribio en kilometro %d es en pie %f ",a,b);
	return 0;
}
