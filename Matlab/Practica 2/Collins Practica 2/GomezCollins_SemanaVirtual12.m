% Collins
disp('Triangulo')

Fijo = '*';

Entrada=input('Introduce el tamaño del triangulo');

for i = 0:Entrada-1
 Formula = (((Entrada - i)*2)-1);
 Cambiante = '*';
    for ii = 2:Formula
        Cambiante = strcat(Cambiante,Fijo);
    end 
disp(Cambiante)
end 
