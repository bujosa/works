
%Ejercicio 2 simular Calculadora
opcion = 0; % Donde se guardara el numero para evaluar

while opcion ~= 5 
 
 disp('Menu Calculadora');
 disp('.'); 
 disp('1. Sumar');
 disp('2. Restar');
 disp('3. Multiplicar');
 disp('4. Dividir');
 disp('5. Terminar ');
 
 opcion=input('Eliga un opcion entre el 1 al 5: ');
 disp(''); 
 
 % Variables
 NA = 0; NB = 0;
 
 if opcion < 5 && opcion > 0
    NA = input('Digite el primer numero: ');
     NB = input('Digite el segundo numero: '); 
 end
 
 if opcion == 1
     NC = NA+NB;
     disp('El resultado de la suma es: '); 
     disp(NC); 
 elseif opcion == 2
     NC = NA-NB;
     disp('El resultado de la resta es: ');
     disp(NC);
 elseif opcion == 3
     NC = NA.*NB;
     disp('El resultado de la multiplicacion es: ');
     disp(NC);
 elseif opcion == 4
     NC = NA/NB;
     disp('El resultado de la division es: ');
     disp(NC);
     
 elseif opcion == 5
     disp('Programa Cerrado');
 else 
     disp('Opcion elegida incorrecta');
 end
 
 if opcion == 5
     break;
 end
 
end 