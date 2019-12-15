
prueba = 'vacio';
disp('Universidad UNIBE');
mod.MatriculaEstudiante =input('Ingresa la Matricula del estudiante: ');
mod.NombreEstudiante = input('Nombre del estudiante: ','s');


while prueba ~= 'N'
    
  mod.Trimestre = (input('Codigo del cuatrimestre: ','s'));

  Cantidad = input('Cantidad # de asignatura este cuatrimestre? ');
  
  
  for i =  1:Cantidad
    mod.CodigoAsignatura = (input('Codigo Asignatura: ','s'));
    
    mod.NombreAsignatura = (input('Nombre Asignatura: ','s'));
    
    mod.Creditos = (input('Creditos: '));
    
    mod.HoraEntrada = (input('Entrada del estudiante a la materia: ','s'));
    
    mod.HoraSalidad = (input ('Salidad del estudiante de la materia: ','s'));
  end
  
  prueba = input('Otro cuatrimestre deasea ingresar (S/N) ? ','s');
  
  if prueba == 'N' || prueba == 'n'
        break;
  end
  
end

disp('.......................');
disp('Datos del estudiante de UNIBE: ');
disp(mod);
disp('........................');





