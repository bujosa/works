#include <stdio.h>

int main(int argc, char** argv) 
{
    float a;
	float b;
	float c;
	float d;
	float f;
	float g;
	printf("Ingrese el monto: ");
	scanf("%f",&a);
    printf("Escriba el interes: ");
	scanf("%f",&b);
	// interes anual
	c = (a/100)*b;
    printf(" El interes actual es: %f \n",c);
    //Interes mensual;
    d = c/b;
	printf(" El interes menusal es: %f \n",d);
    // tOTAL ANUAL
    f = a + (d*b);
    printf(" El interes total anual es: %f \n" ,f);
    // Mensualidad
    g = f/b;
	printf(" La mensualidad es: %f \n",g);
	return 0;
}
