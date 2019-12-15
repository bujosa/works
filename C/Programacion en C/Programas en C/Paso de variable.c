#include <stdio.h>

int main(int argc, char** argv) 
{
    int a;
	int b;
	int c;
	printf("Digite su primer dato en la primera variable: ");
	scanf("%d",&a);
    printf("Digite su Segundo dato en la segunda variable: ");
	scanf("%d",&b);
    printf("Prueba antes dato de a = %d",a);
	printf(" y dato de b = %d \n",b);
    c = a;
    a = b;
    b = c;
    printf("Prueba despues dato de a = %d",a);
	printf(" y dato de b = %d \n",b);
	return 0;
}
