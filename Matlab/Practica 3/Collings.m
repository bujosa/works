
disp('Collins')

dato.MatriculaEstudiante =input('Ingresa la Matricula: ');
dato.NombreEstudiante = input('Ingrese el nombre del estudiante: ','s');

op = 's';

while op ~= 'N'
    
  dato.Trimestre = (input('Codigo del cuatrimestre: ','s'));

  C = input('Asignatura de este cuatrimestre? ');
  
  
  for i =  1:C
    dato.CodigoAsignatura = (input('Codigo Asignatura ','s'));
    
    dato.NombreAsignatura = (input('Nombre Asignatura: ','s'));
    
    dato.Creditos = (input('Creditos: '));
    
    dato.HoraEntrada = (input('Entrada: ','s'));
    
    dato.HoraSalidad = (input ('Salidad: ','s'));
  end
  
  op = input('Otro cuatrimestre (S/N) ? ','s');
  
  if op == 'N'
        break;
  end
  
end

disp(dato);





