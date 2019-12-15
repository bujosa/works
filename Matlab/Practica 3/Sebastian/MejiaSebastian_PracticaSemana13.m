
% UNIBE 

disp('Unibe x Vantroy');
Estudiante.M =input('Ingresar la Matricula del estudiante: ','s');
Estudiante.N = input('Ingresar el Nombre del estudiante: ','s');
opcion = ' ';
CSS = 1;

while opcion ~= 'N'
    
  Estudiante.A(CSS).T = input('Digite Codigo del Cuatrimestre:  ','s'); % Codigo en la estructura

  Estudiante.A(CSS).N = input('Digite Cantidad de Asignatura para este trimestre? '); % Cantidad de materia para ese trimestre
 
  for i =  1:Estudiante.A(CSS).N 
    Estudiante.Ma(i).AC = input('Codigo de la Asignatura: ','s');
    Estudiante.Ma(i).AN = input('Nombre de la Asignatura: ','s');
    Estudiante.Ma(i).CA = input('Creditos de la asignatura: ');
    Estudiante.Ma(i).HE = input('Hora de entrada: ','s');
    Estudiante.Ma(i).HS = input ('Hora de salidad: ','s');
  end
  
  opcion = input('Desea ingresar otro trimestre a la estructura (S/N) ? ','s');
  
  if opcion == 'N'
        break;
  else
        CSS = CSS + 1;
  end

end

fprintf('Matricula estudiante: %s \n',Estudiante.M);
fprintf('Nombre del estudiante: %s \n\n',Estudiante.N);
for m = 1:CSS
    fprintf('Codigo Trimestre: %s \n\n',Estudiante.A(m).T);
    N = Estudiante.A(m).N;
    for n = 1:N
        disp('**********');
        fprintf('Codigo Materia: %s \n', Estudiante.Ma(n).AC);
        fprintf('Nombre Materia: %s \n',Estudiante.Ma(n).AN );
        fprintf('Credito Materia: %d \n',Estudiante.Ma(n).CA);
        fprintf('Hora Entrada Materia: %s \n',Estudiante.Ma(n).HE);
        fprintf('Hora Salida Materia: %s \n', Estudiante.Ma(n).HS);
        disp('**********');
    end
end





