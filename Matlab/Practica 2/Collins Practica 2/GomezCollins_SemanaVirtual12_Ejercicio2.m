

menu = 0; 

while menu ~= 5 
    
 disp('1. Sumar');
 disp('2. Restar');
 disp('3. Multiplicar');
 disp('4. Dividir');
 disp('5. Terminar ');
 
 menu=input('Eliga un opcion entre el 1 al 5: ');

 if menu < 5 && menu > 0
   A = input('Digite el primer numero: ');
   B = input('Digite el segundo numero: '); 
 end
 
 if menu == 1
     C = A+B;
 elseif menu == 2
     C = A-B;
 elseif menu == 3
     C = A.*B;
 elseif menu == 4
     C = A/B;
 elseif menu == 5
     disp('Programa Cerrado');
      break;
 end 
 
 if menu > 5 || menu <= 0
     disp('Opcion elegida incorrecta');
 else
     disp('El resultado es: ');
     disp(C);
 end
 
 
end 