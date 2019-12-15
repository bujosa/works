
% EJERCICIO 1


for i =  1:10
  A = i*6;
  fprintf('%d x 6 es %d \n',i,A);
end
% EJERCICIO 2



% arreglo de celda da errores 
push = cell(9);
for i = 1:3
    
    disp('Estudiante ')
    disp('*****************')
    push(i,1) = cellstr(input('Matricula : ','s'));
    push(i,2) = cellstr(input('Nombre : ','s'));
    push(i,3) = cellstr(input('Apellido : ','s'));
    push(i,4) = cellstr(input('Correo : ','s'));
    
     disp('Materia')
     disp('*****************')
     data = i*5+1;
    push(data,1) = cellstr(input('Codigo : ','S'));
    push(data,2) = cellstr(input('Nombre : ','s'));
    push(data,3) = cellstr(input('creditos : ','s'));
    
     disp('Nota')
     disp('*****************')
     data = i*10+1;
    push( data,1) = cellstr(input('Nota : '));
    push(data,2) = cellstr(input('Letra : ', 's'));
    
end


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
alpha(.5)


% EJERCICIO 5



disp('Banco de Unibe');
disp('Concepcion de Creditos');
A = input('Nombre Completo del cliente: ','s');
B = input('Fecha de la Solicitud: ','s');
money = input('Ingreso Anuales del cliente: ');
stage = input ('Estado Civil (S/C): ','s');
son = input('Tienen hijos (S/N): ','s');


confirmacion = 0;

if money > 12000-1   
    confirmacion = 1;
elseif money > 10000 -1 && son ~= 'S' && stage ~= 'S'
            confirmacion = 1;
elseif money > 8000-1 && stage ~= 'C'
    confirmacion = 1;
end 
% Fin del algoritmo de desicion

fprintf('Nombre Completo: %s\n',A );
fprintf('Fecha Solicitud: %s\n',B);
fprintf('Ingreso Anuales: %d\n',money);
fprintf('Estado Civil S(Soltero) o C(Casado): %s\n',stage);
fprintf('Tienen hijos (S/N): %s\n',son);

if confirmacion ~= 1
disp('No Concedido el credito al cliente');
else
disp('Si Concedido el credito al cliente');
end

