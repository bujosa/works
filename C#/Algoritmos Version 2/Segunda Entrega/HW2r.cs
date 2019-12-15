    /*
 * Puntos ejercicio: 15
 *
 * Tenemos una serie de tareas (actividades) a ejecutar.  Cada tarea tiene una
 * duracion (en segundos) y una prioridad (medido como un numero positivo).
 * 
 * Tu objetivo es programar (agendar) K de esas tareas de manera que las tareas
 * se completen lo mas antes posible.  Para cada una de esas K tareas, debes
 * indicar su hora de inicio.  No se permite dividir las tareas para ejecutarse
 * en distintos horarios. En tu agenda, dos tareas no se pueden solapar: solo se
 * puede ejecutar una tarea a la vez.
 *
 * Para medir la eficiencia de la agenda propuesta, asignaremos una penalidad
 * de la siguietne manera: Si una tarea i, con prioridad Pi, se completa en el
 * segundo Ti, se te penaliza un costo igual a Pi * Ti.  El costo total de tu
 * agenda seria la suma de los costos de ejecutar cada una de las K tareas.
 *
 * En este homework, debes implementar dos soluciones:
 *  1) Con Brute force
 *  2) Con Greedy
 *
 * Ubica todas las secciones con el tag TODO.  Cada tag les indicara que deben
 * completar.  Para TODOs que requieren respuestas, escribe las respuestas en
 * un comment.
 *
 */

using System;
using System.Text;
using System.Collections.Generic;


public class Task
{
    public int id;         // identificador para esta tarea
    public int duration;   // duracion en segundos
    public int priority;   // prioridad de la tarea
    
    public Task(int id, int duration, int priority)
    {
        this.id       = id;
        this.duration = duration;
        this.priority = priority;
    }
}


// Esta clase define una tarea agendada.  Tu solucion debe devover una lista de
// objetos de esta clase
public class ScheduledTask
{
    public Task task;       // referencia al objeto tarea agendado
    public int start_time;  // hora de inicio para esa tarea
    
    public ScheduledTask(Task task, int start_time)
    {
        this.task       = task;
        this.start_time = start_time;
    }
}


// Esta clase abstracta es para facilitar mi trabajo de corregir este homework.
// Tu solucion debe sobreescribir el metodo Solve en la clase MySoltution
public abstract class Solution
{
    // Este es el metodo que debes implementar
    // Elige 'K' de las tareas en 'tasks' y asignales una hora de inicio a cada
    // tarea, de manera que minimice la penalidad descrita en el enunciado.
    // Devuelve el listado L de las K tareas agendadas, donde L[i].start_time
    // es la hora de inicio de la tarea L[i].task
    public abstract List<ScheduledTask> Solve(Task[] tasks, int K);
}


// Esta clase es donde debe implementar tu solucion basada en Brute Force
public class MyBruteForceSolution : Solution
{
    // TODO: Agrega los atributos y metodos que necesites

    
    public override List<ScheduledTask> Solve(Task[] tasks, int K)
    {
        // TODO: Implementar algoritmo con Brute Force (recursivo) para resolver
        //       el problema descrito en el enunciado
        // NOTA: tu algoritmo debe usar Brute Force (no Greedy) para elegir las
        //       K tareas a ejecutar
        // Complejidad esperada: exponencial en N
        // Valor: 9 puntos

        
        return null;
    }
}


// Esta clase es donde debe implementar tu solucion basada en Greedy
public class MyGreedySolution : Solution
{
    // TODO: Agrega los atributos y metodos que necesites


    public override List<ScheduledTask> Solve(Task[] tasks, int K)
    {
        // TODO: Implementar algoritmo Greedy para resolver el problema descrito
        //       en el enunciado.  La idea es aplicar dos veces greedy:
        // 1) Para seleccionar las K tareas: elige las tareas con menor producto
        //    priority * duration
        // 2) Para ordenar esas K tareas por la razon (priority / duration) de
        //    manera descendente, tal como explicamos en clase
        // Complejidad esperada: O(N log N)
        // Valor: 6 puntos

        
        return null;
    }
}


public class HW2s
{
    public static void Main(string[] args)
    {
        Task[] tasks = {
            new Task( 1, 200, 10),
            new Task( 2, 120, 9),
            new Task( 3, 240, 12),
            new Task( 4, 150, 12),
            new Task( 5, 125, 20),
            new Task( 6, 225, 18),
            new Task( 7, 200, 15),
            new Task( 8, 190, 16),
            new Task( 9, 180, 14),
            new Task(10, 150, 21),
            new Task(11, 100,  7)
        };
        int K = 7;

        {
            Console.WriteLine("-------");
            Console.WriteLine("Greedy:");
            Console.WriteLine("-------");
            Solution sol = new MyGreedySolution();
            List<ScheduledTask> result = sol.Solve((Task[]) tasks.Clone(), K);
            long penalty = 0;
            foreach (ScheduledTask s in result)
            {
                int end_time = s.start_time + s.task.duration;
                penalty += s.task.priority * end_time;
                Console.WriteLine(
                    "Task id {0,2}  priority: {1,2}  duration: {2,3}  " +
                    "start: {3,4}  end: {4,4}  penalty: {5,5}",
                    s.task.id, s.task.priority, s.task.duration,
                    s.start_time, end_time, s.task.priority * end_time
                );
            }
            Console.WriteLine("Total penalty: {0}", penalty);
            Console.WriteLine();
        }

        {
            Console.WriteLine("------------");
            Console.WriteLine("Brute Force:");
            Console.WriteLine("------------");
            Solution sol = new MyBruteForceSolution();
            List<ScheduledTask> result = sol.Solve((Task[]) tasks.Clone(), K);
            long penalty = 0;
            foreach (ScheduledTask s in result)
            {
                int end_time = s.start_time + s.task.duration;
                penalty += s.task.priority * end_time;
                Console.WriteLine(
                    "Task id {0,2}  priority: {1,2}  duration: {2,3}  " +
                    "start: {3,4}  end: {4,4}  penalty: {5,5}",
                    s.task.id, s.task.priority, s.task.duration,
                    s.start_time, end_time, s.task.priority * end_time
                );
            }
            Console.WriteLine("Total penalty: {0}", penalty);
            Console.WriteLine();
        }
    }

/*
Output de mi solucion:

-------
Greedy:
-------
Task id  5  priority: 20  duration: 125  start:    0  end:  125  penalty:  2500
Task id  4  priority: 12  duration: 150  start:  125  end:  275  penalty:  3300
Task id  9  priority: 14  duration: 180  start:  275  end:  455  penalty:  6370
Task id  2  priority:  9  duration: 120  start:  455  end:  575  penalty:  5175
Task id 11  priority:  7  duration: 100  start:  575  end:  675  penalty:  4725
Task id  3  priority: 12  duration: 240  start:  675  end:  915  penalty: 10980
Task id  1  priority: 10  duration: 200  start:  915  end: 1115  penalty: 11150
Total penalty: 44200

------------
Brute Force:
------------
Task id  5  priority: 20  duration: 125  start:    0  end:  125  penalty:  2500
Task id  4  priority: 12  duration: 150  start:  125  end:  275  penalty:  3300
Task id  9  priority: 14  duration: 180  start:  275  end:  455  penalty:  6370
Task id  2  priority:  9  duration: 120  start:  455  end:  575  penalty:  5175
Task id 11  priority:  7  duration: 100  start:  575  end:  675  penalty:  4725
Task id  1  priority: 10  duration: 200  start:  675  end:  875  penalty:  8750
Task id  3  priority: 12  duration: 240  start:  875  end: 1115  penalty: 13380
Total penalty: 44200

*/
    
}

