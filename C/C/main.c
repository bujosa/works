#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int onzas_totales = 0;
	printf ("\t Bienvenido al sistema de conversiones de Onzas\n\n");
	printf("Ingrese la cantidad de Onzas para la tabla:");
	scanf("%d",&onzas_totales);
	if(onzas_totales <= 0)
	  {printf("Ingresar una cantidad mayor que 0");
	    return 0;
	  }
	  
	system("cls");
	
	int i = 0;
	
	printf(" Onzas | Libras | Gramos | Kilos\n");
	
	for(i = 1; i <= onzas_totales; i++)
	    printf(" %d | %f | %f | %f  \n", i, i/16.00, i*28.3495, i/35.274);	

	return 0;
}
