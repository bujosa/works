/*
 * Este programa es para demostrar el uso de la libreria PriorityQueue, el cual
 * ofrece las siguientes operaciones sobre un Min Priority Queue:
 *
 *   PriorityQueue<Item>()
 *      Constructor que inicia un (Min) Priority Queue vacio
 *      Complejidad: O(1)
 *
 *   void Enqueue(Item x)
 *      Agrega el dato x al priority queue
 *      Complejidad: Theta(log N)
 * 
 *   Item Dequeue()
 *      Extrae y devuelve el dato con mayor prioridad (el de menor valor)
 *      Complejidad: Theta(log N)
 * 
 *   Item Peek()
 *      Devuelve (sin extraer) el dato con mayor prioridad
 *      Complejidad: O(1)
 * 
 *   int Count
 *      Propiedad que contiene la cantidad de datos grabados en este priority
 *      queue
 *      Complejidad: O(1)
 * 
 * 'Item' es un tipo de datos que implementa la interfaz IComparable
 *
 */
using System;

public class Student : IComparable<Student>
{
    public int Age { get; private set; }
    public string Name { get; private set; }

    public Student(int age, string name)
    {   
        this.Age  = age;
        this.Name = name;
    }
    
    public int CompareTo(Student other)
    {
        if (this.Age < other.Age)
            return -1;
        else if (this.Age > other.Age)
            return +1;
        else
            return 0;
    }
}

public class TestPriorityQueue
{
    public static void Main(string[] args)
    {
        // Priority Queue de int
        Console.WriteLine("================================");
        Console.WriteLine("Ejemplo de Priority Queue de int");
        Console.WriteLine("================================");
        int[] A = {2, 6, 1, 5, 2};
        var PQ1 = new PriorityQueue<int>();
        foreach (int x in A)
        {
            PQ1.Enqueue(x);
        }
        while (PQ1.Count > 0)
        {
            Console.WriteLine( PQ1.Dequeue() );
        }
        Console.WriteLine();


        // Priority Queue de String
        Console.WriteLine("===================================");
        Console.WriteLine("Ejemplo de Priority Queue de string");
        Console.WriteLine("===================================");

        string[] B = {"hola", "mundo", "nos", "vemos", "klk"};
        var PQ2 = new PriorityQueue<string>();
        foreach (string x in B)
        {
            PQ2.Enqueue(x);
        }
        while (PQ2.Count > 0)
        {
            Console.WriteLine( PQ2.Dequeue() );
        }
        Console.WriteLine();
        
        // Priority Queue de Student, priorizado por edad (de menor a mayor)
        Console.WriteLine("====================================");
        Console.WriteLine("Ejemplo de Priority Queue de Student");
        Console.WriteLine("====================================");
        var PQ3 = new PriorityQueue<Student>();
        PQ3.Enqueue(new Student(13, "Pedro"));
        PQ3.Enqueue(new Student(12, "Rosa"));
        PQ3.Enqueue(new Student(14, "Rita"));
        PQ3.Enqueue(new Student(10, "Daniel"));
        PQ3.Enqueue(new Student(11, "Elena"));
        PQ3.Enqueue(new Student(13, "Marta"));
        while (PQ3.Count > 0)
        {
            Student s = PQ3.Dequeue();
            Console.WriteLine( "{0} {1}", s.Age, s.Name );
        }
        Console.WriteLine();
    }
}
