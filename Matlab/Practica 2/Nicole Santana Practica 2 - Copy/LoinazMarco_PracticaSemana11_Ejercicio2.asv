dataoption = 0; 
while dataoption ~= 5 
 disp('1. Sumar');
 disp('2. Restar');
 disp('3. Multiplicar');
 disp('4. Dividir');
 disp('5. Terminar ');
 dataoption=input('Eliga un opcion entre el 1 al 5: ');
 if dataoption < 5 && dataoption > 0
   A = input('Digite el primer numero: ');
   B = input('Digite el segundo numero: '); 
   C = [A+B,A-B,A.*B,A/B];
   D = C(dataoption);
 end
 if dataoption == 5
      break;
 elseif dataoption > 5 || dataoption <= 0
     disp('Solo es valido elegir entre 1 a 5');
 else
     disp('La solucion es:');
     disp(D);
 end
end 