
V = 0;
a = 0;
b = 0;
c = 0;

while V ~= 5 
    
 disp('1. Sumar');
 disp('2. Restar');
 disp('3. Multiplicar');
 disp('4. Dividir');
 disp('5. Terminar');
 
 V=input('Introduce una opcion: ');
 
 if V < 5 && V > 0
  a = input('Primer numero: ');
         b = input('Segundo numero: ');
 end
         
 switch(V)
     case 1
         c = a+b;
     case 2
         c = a-b;
     case 3
         c = a.*b;
     case 4
         c = a/b;
     case 5
         break;
     otherwise
          disp('Digite solo numeros entre 1 a 5');
 end  
 
 if V == 5
     break;
 end
 
 if V < 5 && V > 0
     disp('El resultado es: ');
         disp(c);
 end
 
end 