#include <stdio.h>

int main(int argc, char** argv) 
{
    double a = 2.50;
    char nombre[100];
    char apellido[100];
    char fecha[100]; 
    int edad;
    float indice;
    int cuatrimestre;
    char amateria[100];
    char bmateria[100];
	char cmateria[100];
    
	printf("-------------------------------------------\nBienvenido al sistema estudiantil de APEC\n-------------------------------------------\n");
	printf("Ingrese su Nombre: ");
	scanf("%s",&nombre);
		printf("Ingrese su Apellido: ");
	scanf("%s",&apellido);
		printf("Ingrese su Fecha de nacimiento: ");
	scanf("%s",&fecha);
		printf("Ingrese su Edad: ");
	scanf("%d",&edad);
			printf("Ingrese su Indice academico: ");
	scanf("%f",&indice);
		printf("Ingrese su Cuatrimestre: ");
	scanf("%d",&cuatrimestre);
	printf("\nEjemplo de materia: CODGIOMATERIA_NOMBREMATERIA_CREDITOMATERIA");
			printf("\n\nIngrese El codigo de la primera materia con su nombre y credito: ");
	scanf("%s",&amateria);
		printf("\n\nIngrese El codigo de la segunda materia con su nombre y credito: ");
	scanf("%s",&bmateria);
		printf("\n\nIngrese El codigo de la Tercera materia con su nombre y credito: ");
	scanf("%s",&cmateria);
	
   printf("\n\n-------------------------------------------\nUNIVERSIDAD APEC\n-------------------------------------------\n");
   printf("Nombre: %s ", nombre);
     printf("\nApellido: %s ", apellido);
       printf("\nFecha Nacimiento: %s ", fecha);
         printf("\nEdad: %d ", edad);
           printf("\nIndice cuatrimestre\n %0.2f      %d", indice, cuatrimestre);
             printf("\nCodigo Materia Credito\n %s\n %s\n %s ", amateria, bmateria, cmateria);
   
	
	
	
	
	
	
	

	return 0;
}
