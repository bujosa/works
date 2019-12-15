

% EJERCICIO 1


for i =  1:10
  num = i*8;
  fprintf(' 8 x %d es %d \n',i,num);
end


% ejercicio 2

F = cell(18);
for i = 1:3
    disp('---------------')
    fprintf('Estudiante #%d',i)
    disp('---------------')
    F(i,1) = cellstr(input('Matricula : ','s'));
    F(i,2) = cellstr(input('Nombre : ','s'));
    F(i,3) = cellstr(input('Apellido : ','s'));
    F(i,4) = cellstr(input('Correo : ','s'));
   
     disp('---------------')
     fprintf('Materia #%d',i)
     disp('---------------')
     For = i*5+1;
    F(For,1) = cellstr(input('Codigo : ','S'));
    F(For,2) = cellstr(input('Nombre : ','s'));
    F(For,3) = cellstr(input('creditos : ','s'));
   
     disp('---------------')
     fprintf('Nota #%d',i)
     disp('---------------')
     For = i*10+1;
    F( For,1) = cellstr(input('Nota : ','s'));
    F(For,2) = cellstr(input('Letra : ', 's'));
   
end



% ejercicio 3



% indique las diferencias entre los siguientes tipos de imágenes:

%Imágenes de Intensidad esta diferencia de las otras dos, se basa en
%intensidad de los colores teniendo diferente niveles basando de 0 a 1 un
%poco parecida a las de MAP.

%Imágenes Indexadas esta es denominada Matriz I, tiene un rango de 100 *
%100 conteniendo valores de [1..256]

%Imágenes RGB esta solo contienen las intesidades en rojo, verder y azul
%respectivamente de la imagen y es denominada MAP es de 256*3 con rango en
%valores de 0 a 1.


% Ejercicio 4

mesh(Peaks)
hold on 
alpha(.57)


% Ejercicio 5

disp('VANTROY');

% Aprendido usando Input 
Name = input('Nombre Completo del cliente: ','s');
Date = input('Fecha de la Solicitud: ','s');
Mon = input('Ingreso Anuales del cliente: ');
Est = input ('Estado Civil (S/C): ','s');
Son = input('Tienen hijos (S/N): ','s');

t = 0;

if Mon > 6000-1   
    t = 1;
elseif Mon > 4000 -1 &&  Est ~= 'S'
            t = 1;
elseif Mon > 2000 -1 && Est ~= 'C' && Son ~= 'S'
    t = 1;
end 

%Usando fprint del ejercicio 1
fprintf('Nombre Completo: %s\n',Name );
fprintf('Fecha Solicitud: %s\n',Date);
fprintf('Ingreso Anuales: %d\n',Mon);
fprintf('Estado Civil S(Soltero) o C(Casado): %s\n',Est);
fprintf('Tienen hijos (S/N): %s\n',Son);

% Desicion final
if t ~= 1
fprintf('No Concedido el credito al cliente');
else
fprintf('Si Concedido el credito al cliente');
end
