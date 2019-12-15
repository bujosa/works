#include <stdio.h>

int main(int argc, char** argv) 
{
    double a = 2.50;
    int y;
	printf("Ingrese el monto de pesos: ");
	scanf("%d",&y);
	
	if(y >= 150 )
	{
		int horas = y/a;
	    int minutos  = horas%60;
		horas = horas/60;
		printf("Usted tiene %d hora ",horas);
		printf("Con %d minutos ",minutos);
	}
	else{
		double lapzo = y/a;
		printf("Usted tiene %e minutos",lapzo);
	}
   
	return 0;
}
