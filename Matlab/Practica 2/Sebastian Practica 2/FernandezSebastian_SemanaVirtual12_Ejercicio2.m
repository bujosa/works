

numero = 0;
while numero ~= 5 
    
    disp('Ejercicio 2 Calculadora');
 disp('1. Sumar');
 disp('2. Restar');
 disp('3. Multiplicar');
 disp('4. Dividir');
 disp('5. Terminar');
 
 numero=input('Introduce una opcion del menu: ');
 
 switch(numero)
     case 1
         Numero1 = input('Digite el primer numero: ');
         Numero2 = input('Digite el segundo numero: ');
         Numero3 = Numero1+Numero2;
         disp('El resultado de la suma es: '); 
         disp(Numero3);
     case 2
          Numero1 = input('Digite el primer numero: ');
         Numero2 = input('Digite el segundo numero: ');
         Numero3 = Numero1-Numero2;
         disp('El resultado de la resta es: ');
         disp(Numero3);
     case 3
          Numero1 = input('Digite el primer numero: ');
         Numero2 = input('Digite el segundo numero: ');
         Numero3 = Numero1.*Numero2;
         disp('El resultado de la multiplicacion es: ');
         disp(Numero3);
     case 4
         Numero1 = input('Digite el primer numero: ');
         Numero2 = input('Digite el segundo numero: ');
         Numero3 = Numero1/Numero2;
         disp('El resultado de la division es: ');
         disp(Numero3);
     case 5
         disp('Hssta Luego');
         break;
     otherwise
          disp('Opcion Invalidad');
 end  
 
 if numero == 5
     break;
 end
 
end 
