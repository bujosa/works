#include<stdio.h>
 
#define N 3
#define M 4
 
void mostrarMatriz(float matriz[N][M]);
 
int main(int argc, char** argv)
{
	//Función para mostrar la matriz
 
	float matriz[N][M]={
	{15,30,3,3},
	{1,3,1,-6},
	{5,1,3,12}
	};
 
	float x[N],suma;
 
	int j,i,k;
 
 	//Orden de la matriz
	float division;
    
	mostrarMatriz(matriz);
    
    /*El siguiente algoritmo hace lo siguiente : (ELIMINACION GAUSIANA)
    
	aliza lo que se llama una reducción de filas en una matriz donde 
	se realizan una serie de operaciones sobre los valores hasta que 
	la esquina izquierda inferior de la matriz consiste solamente 
	en ceros.

         Existen tres tipos de operaciones elementales de filas

        Intercambiar dos filas
        Multiplicar una fila por un escalar diferente de cero
        Sumar el múltiplo de una fila a otra fila*/
	
	//Recorrer la matriz 
	
	for(j=0;j<=N;j++){
		for(i=0; i<=(N-1); i++){
			if(i>j){
				//Divir los elementos de la matriz
				division=matriz[i][j]/matriz[j][j];
				for(k=0;k<=N;k++){
					//Obterner el nuevo valor para los elementos en la diagonal inferior
					matriz[i][k]=matriz[i][k]-division*matriz[j][k];
				}
			}
		}
	}
    
	//Recorrer la matriz
	for(i=N-1;i>=0;i--){
		suma=0;
		for(j=i+1;j<=N-1;j++){
			suma=suma+matriz[i][j]*x[j];
		}
		//Obtener los valores de las variables
		x[i]=(matriz[i][N]-suma)/matriz[i][i];
	}
	
	//Mostrar los valores de las variables    
	for(i=0; i<=N-1; i++){
		printf("x%d =\t%.2f\n",i+1,x[i]);
	}
	printf("\n\n");
    	system("pause");
	return 0;
}
 
void mostrarMatriz(float matriz[N][M]){
	int i,j;
	printf("\n");
	for(i=0;i<=(N-1);i++){
		printf("|\t");
		for(j=0;j<=N;j++){
			printf("%.2f\t",matriz[i][j]);
		}
		printf("|\t\n");
	}
	printf("\n\n");

}
