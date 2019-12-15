#include <stdio.h>
#include <stdlib.h> 	

int main(int argc, char** argv) 
{
	
	float Total = 0;
	float Impuestos = 0.00;
	float Sin_Impuestos = 0;
	float producto_Moment = 0;
    int Items = 0;
    float Agrandar = 1.10;
    float Propinas = 0.10;
    float ITBIS = 0.18;
    int opcion = 0;
    int Combos_Agrandados = 0;


do{
	system("cls");
		printf("-------------------------------------------\nBienvenido al Restaurante de Hamburguesas Rapidas HBKING	\n-------------------------------------------\n");
        printf("Las Opciones Son: \n\n") ;
             printf("1. Papas - Costo 60$\n") ;
                printf("2. Bacon Chesse - Costo 150$  \n") ;
                  printf("3. Hamburguesas Sencilla - Costo 150$\n") ;
                       printf("4. Double carne Bacon - Costo 185$  \n") ;
                            printf("5. Agrandar combos - Costo 10 porciento adicional\n") ;
                                 printf("6. Salir\n\n") ;
                                   printf("Digite la opcion deseada: ");
                                 	scanf("%d",&opcion);
		    
	switch(opcion)
	{
		case 1: 
		Items++;
		Sin_Impuestos += 60;
		producto_Moment = 60;
		break;
		case 2:
			Items++;
				Sin_Impuestos += 150;
				producto_Moment = 150;
			break;
			case 3:
				Items++;
					Sin_Impuestos += 150;
					producto_Moment = 150;
				break;
				case 4:
					Items++;
						Sin_Impuestos += 185;
						producto_Moment = 185;
					break;
					case 5:
						Combos_Agrandados = Items;
						Sin_Impuestos = Sin_Impuestos*Agrandar;
						producto_Moment = 0;
						break;
						default: 
						if(opcion != 6)
						  printf("Para salir Digite 6");  
						break;
	}
}while(opcion != 6);

// Aplicar Propina
Propinas = Sin_Impuestos*Propinas;
//Aplicar Impuestos
Impuestos = Sin_Impuestos*ITBIS;
// Suma de impuestos y total sin impuestos

Total = Impuestos + Sin_Impuestos + Propinas;

// Datos Mostrados en Pantalla
system("cls");
   printf("\n\n-------------------------------------------\nCuenta Total Del Cliente\n-------------------------------------------\n");
   printf("Cantidad de productos Ordenados: %d \n",	Items);
   printf("Combos Agrandados: %d \n", Combos_Agrandados);
   printf("Total sin impuestos: %0.2f \n", Sin_Impuestos);
   printf("Impuestos: %0.2f \n", Impuestos);
   printf("Propinas: %0.2f \n", Propinas);
   printf("Total General: %0.2f \n", Total);
	
	return 0;
}
