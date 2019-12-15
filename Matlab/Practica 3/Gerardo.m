
estudiante.M =input('Ingresa la Matricula: ');
estudiante.nombre = (input('Ingrese nombre del estudiante: ','s'));

opcion = 's';
while opcion ~= 'N'
    
  estudiante.trimestre = (input('Codigo del cuatrimestre: ','s'));

  N = input('Cuantas asignatura registrara en este cuatrimestre? ');
  
  d = 0;
  while  d < N
    estudiante.datoasignatura = (input('Codigo Asignatura ','s'));
    estudiante.nombreasignatura = (input('Nombre Asignatura: ','s'));
    estudiante.creditos = (input('Creditos: '));
    estudiante.entrada = (input('Entrada: ','s'));
    estudiante.salidad = (input ('Salidad: ','s'));
    d = d + 1; 
  end
  
  opcion = char(input('Desea registrar otro cuatrimestre (S/N) ? ','s'));
  if opcion == 'N'
        break;
  end
end

disp(estudiante);





