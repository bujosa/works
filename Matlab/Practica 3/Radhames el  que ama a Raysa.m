

% Radhames Reyes
Reyes.MatriculaEstudiante =input('Ingresa la Matricula del estudiante: ','s');
Reyes.NombreEstudiante = input('Nombre del estudiante: ','s');
seguir = ' '; % Variable de desicion

while seguir ~= 'N'
    
  Reyes.Trimestre = (input('Cuatrimestre Codigo:  ','s')); % Codigo en la estructura

  N = input('Cantidad de Asignatura para este trimestre? '); % Cantidad de materia para ese trimestre
 
  for j =  1:N
    Reyes.Asignatura_Codigo = input('Codigo de la Asignatura: ','s');
    Reyes.Asignatura_Nombre = input('Nombre de la Asignatura: ','s');
    
    Reyes.Creditos_Asignatura = input('Creditos de la asignatura: ');
    Reyes.HoraEntrada_de_la_asignatura = input('Entrada Hora: ','s');
    Reyes.HoraSalidad_de_la_asignatura = input ('Salidad Hora: ','s');
  end
  
  seguir = input('Ingresar otro (S/N) ? ','s');
  
  if seguir == 'N' || seguir == 'n'
        break;
  end
  
end

disp(Reyes);






