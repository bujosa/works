

% Ejercicio del triangulo
X = input('Introduce el numero para el tamaño del triangulo:');

% Variables
value = '*'; i=0; calculo = X;

% While para correr X veces
while i<X
 i= i+1;
 
 A = calculo;
 A = ((2.*A)- 1);
 
 calculo = calculo -1;
 simbolo = value;
 
    for B = 1:A-1
        simbolo = strcat(simbolo,value);
    end    
    
disp(simbolo)
end 
