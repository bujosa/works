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
        this.id = id;
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
        this.task = task;
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

    Task[] activity;
    int K;
    int penalidad = 0;
    List<ScheduledTask> answer;
    List<ScheduledTask> TMP = new List<ScheduledTask>();
    List<int> id = new List<int>();

   
    public override List<ScheduledTask> Solve(Task[] tasks, int K)
    {
        // TODO: Implementar algoritmo con Brute Force (recursivo) para resolver
        //       el problema descrito en el enunciado
        // NOTA: tu algoritmo debe usar Brute Force (no Greedy) para elegir las
        //       K tareas a ejecutar
        // Complejidad esperada: exponencial en N
        // Valor: 9 puntos
        
        answer = new List<ScheduledTask>();
        this.activity = tasks;
        this.K = K;
        R(K,0);
        return answer;
    }

    // N ^ (N + 2K) equivalente a N^N se toma el termino lineal como priodida
    void R(int J, int time)
    {
        // Tengo una duda este forech de constante K afecta en algo 
        // la complejidad en exponencial N
        // Porque el for de abajo que corre en N cuando entra a recurcion no cuenta
        // al mismo numero sino que sigue.

        if (J == 0)
        {
            int x = 0;

            foreach(ScheduledTask s in TMP) // CONSTANTE K
            {
                int endtime = s.task.duration + s.start_time;
                x += s.task.priority * endtime;
            }

            // EJECUCION DE ESTE TRAMO K
            if (penalidad == 0)
            {
                foreach (ScheduledTask s in TMP)
                    answer.Add(s);
                penalidad = x;
            }
            else
            {
                if (penalidad > x)
                {
                    answer.Clear();
                    foreach (ScheduledTask s in TMP)
                        answer.Add(s);
                    penalidad = x;
                }
            }
            return;
        }

        // COMPLEJIDAD del for N^N por la recurcion
        for(int i = 0; i < activity.Length; i++)
        {

            int x = i;
            int b = activity[i].duration; // Tiempo duracion
            ScheduledTask a = new ScheduledTask(activity[i], time); // Creat Task

            // Este if es para no tomar en cuenta la misma actividad
            if (id.Contains(i) == false)
            {
                id.Add(i);
                TMP.Add(a);
                R(J - 1, time + b); // Reducir en uno y mandarle time
                id.Remove(i);
                TMP.Remove(a);
            }
            
        }
        
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


        /*
         
         JOA para el codigo de MergeSort el codigo (La estructura) fue tomado de esta fuente:
         https://www.geeksforgeeks.org/merge-sort/ 
                    
         Complejidad del MergeSort in Worst case is NLogN 

         ya la adaptacion del codigo con el problema no fue de esta fuente (:

         Dicho esto ya puede seguir leyendo el codigo

         */

        // DECLACION VARIABLES
        int time = 0;
        Task[] activity = new Task[K];
        List<ScheduledTask> answer = new List<ScheduledTask>();
        // 

        // PASO 1: MERGE SORT para ordenar en N log N (p*d)
        mergeSort(tasks,0,tasks.Length-1, true);
        
        // PASO 2 : Escoger la K actividades
        for (int i = 0; i < K; i++)
            activity[i] = tasks[i];

        // PASO 3: MERGE SORT para ordenar en N log N (p/d)
        mergeSort(activity, 0, activity.Length - 1, false);

        // PASO 4: Asignar al list;
        foreach (Task a in activity)
        {   
            ScheduledTask b = new ScheduledTask(a, time);
            time += a.duration;
            answer.Add(b);
        }
        
        return answer;
    }

    // LEER ARRIBA REFERENCIA de pagina 
    void merge(Task[] arr, int l, int m, int r, bool validar)
    {
        int i, j, k;
        int n1 = m - l + 1;
        int n2 = r - m;

        Task[] L = new Task[n1];
        Task[] R = new Task[n2];

        for (i = 0; i < n1; i++)
            L[i] = arr[l + i];
        for (j = 0; j < n2; j++)
            R[j] = arr[m + 1 + j];

        
        i = 0; j = 0; k = l; 

        while (i < n1 && j < n2)
        {
            double a = 0.0000, b = 0.0000;
            if (validar)
            {
                a = L[i].duration * L[i].priority;
                b = R[j].duration * R[j].priority;
            }
            else
            {           
                a = Convert.ToDouble(L[i].priority) / Convert.ToDouble(L[i].duration);
                b = Convert.ToDouble(R[j].priority) / Convert.ToDouble(R[j].duration);
            }
            if (validar)
            {
                if (a <= b)
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
            }
            else
            {
                if (a > b)
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
            }
            k++;
        }

        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

    // LEER ARRIBA REFERENCIA de pagina 
    void mergeSort(Task[]arr, int l, int r, bool validar)
    {
        if (l < r)
        {

            int m = l + (r - l) / 2;

            mergeSort(arr, l, m, validar);
            mergeSort(arr, m + 1, r, validar);

            merge(arr, l, m, r, validar);
        }
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
            List<ScheduledTask> result = sol.Solve((Task[])tasks.Clone(), K);
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
            List<ScheduledTask> result = sol.Solve((Task[])tasks.Clone(), K);
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

        Console.ReadKey();
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

