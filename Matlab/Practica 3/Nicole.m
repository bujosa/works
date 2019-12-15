

% Nicole Santana
% Lunes y Jueves

H.Matricula =input('Ingresa la Matricula del estudiante: ','s');
H.Nombre = input('Nombre del estudiante: ','s');
seguir = ' '; % Variable de desicion

B = 1;
while seguir ~= 'N'
    
  H.Asignatura(B).Trimestre = input('Codigo del Cuatrimestre:  ','s'); % Codigo en la estructura

  H.Asignatura(B).N = input('Cantidad de Asignatura para este trimestre? '); % Cantidad de materia para ese trimestre
 
  for i =  1:H(1).Asignatura(B).N 
    H.Materia(i).Asignatura_Codigo = input('Codigo de la Asignatura: ','s');
    H.Materia(i).Asignatura_Nombre = input('Nombre de la Asignatura: ','s');
    H.Materia(i).Creditos_Asignatura = input('Creditos de la asignatura: ');
    H.Materia(i).HoraEntrada_de_la_asignatura = input('Entrada Hora: ','s');
    H.Materia(i).HoraSalidad_de_la_asignatura = input ('Salidad Hora: ','s');
  end
  
  seguir = input('Ingresar otro trimestre (S/N) ? ','s');
  
  if seguir == 'N' || seguir == 'n'
        break;
  else
        B = B + 1;
  end

end

disp(H.Matricula);
disp(H.Nombre);
for i = 1:B
    disp(' ');
    disp( H.Asignatura(B).Trimestre);
    N = H.Asignatura(B).N;
    disp(' ');
    for j = 1:N
        disp(' ...........');
        disp(H.Materia(j).Asignatura_Codigo);
        disp(H.Materia(j).Asignatura_Nombre );
        disp(H.Materia(j).Creditos_Asignatura);
        disp(H.Materia(j).HoraEntrada_de_la_asignatura);
        disp( H.Materia(j).HoraSalidad_de_la_asignatura);
    end
end





