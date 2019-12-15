#include <stdio.h>
#include <stdlib.h>


int main (){
	
	int km = 0;
	int costoKm = 0;
	printf ("Ingrese los KMs a recorrer: ");
	scanf("%d", &km);
	
	if (km >=0 && km <=100){
		costoKm = 25*km;
	}
	else if (km >=101 && km <=200){
		costoKm = 24*km;
	}
	else if (km >=201 && km <=300){
		costoKm = 23*km;
	}
	else if (km >300){
		costoKm = 20*km;
	}
	system("cls");
	printf("KMS Solicitados: %d", km);
	printf("\nCosto de Flete: 300");
	printf("\nCosto de KMS: %d", costoKm);
	printf("\nCosto Total: %d", costoKm+300);
	
}
