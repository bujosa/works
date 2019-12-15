
% EJERCICIO 1


for i =  1:10
  A = i*6;
  fprintf('%d x 6 es %d \n',i,A);
end
% EJERCICIO 2


% EJERCICIO 3

% indique las diferencias entre los siguientes tipos de imágenes:

%Imágenes de Intensidad esta diferencia de las otras dos, se basa en
%intensidad de los colores teniendo diferente niveles basando de 0 a 1 un
%poco parecida a las de MAP.

%Imágenes Indexadas esta es denominada Matriz I, tiene un rango de 100 *
%100 conteniendo valores de [1..256]

%Imágenes RGB esta solo contienen las intesidades en rojo, verder y azul
%respectivamente de la imagen y es denominada MAP es de 256*3 con rango en
%valores de 0 a 1.

% EJERCICIO 4

mesh(Peaks)
hold on 
alpha(.0)


% EJERCICIO 5

Nombre = input('Nombre Completo: ','s');
Fecha = input('Fecha Solicitud: ','s');
Ingreso = input('Ingreso Anuales: ');
Estado = input ('Estado Civil (S/C): ','s');
hijos = input('Tienen hijos (S/N): ','s');
superior = 12000;
inferior = 8000;
prueba = 10000;
conceder = 0;

if Ingreso > 12000-1
   
    conceder = 1;
elseif Ingreso > prueba -1 && hijos ~= 'S' && Estado ~= 'S'
            conceder = 1;
elseif Ingreso > inferior-1 && Estado ~= 'C'
    conceder = 1;
end 

if conceder ~= 1

fprintf('Nombre Completo: %s\n',Nombre);
fprintf('Fecha Solicitud: %s\n',Fecha);
fprintf('Ingreso Anuales: %d\n',Ingreso);
fprintf('Estado Civil: %s\n',Estado);
fprintf('Tienen hijos (S/N): %s\n',hijos);
fprintf('No Concedido el credito');

else
fprintf('Nombre Completo: %s\n',Nombre);
fprintf('Fecha Solicitud: %s\n',Fecha);
fprintf('Ingreso Anuales: %d\n',Ingreso);
fprintf('Estado Civil: %s\n',Estado);
fprintf('Tienen hijos (S/N): %s\n',hijos);
fprintf('Si Concedido el credito \n');

end

