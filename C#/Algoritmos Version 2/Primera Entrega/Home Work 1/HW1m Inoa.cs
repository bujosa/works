/*
 * Puntos ejercicio: 9 (+1 extra)
 *
 * Este ejercicio consiste en implementar un algoritmo donde haremos merge de
 * multiples segmentos de arreglos ordenados, no solo 2 o 3.  En cada iteracion
 * de un 2-way (o 3-way) merge regular, tomamos el siguiente elemento mas
 * pequenio de los 2 (o 3) segmentos de arreglos ordenados y avanzas el indice
 * del segmento desde donde se tomo el dato.  Para multiples segmentos, haremos
 * lo mismo: de todos los segmentos, tomaremos el elemento (siguiente) mas
 * pequenio y avanzaremos al siguiente elemento en ese segmento. Pero el paso de
 * identificar el (siguiente) elemento mas pequenio seria ineficiente si lo
 * hacemos con un algoritmo lineal.  Es por eso que usaremos un Min Priority
 * Queue para identificar el siguiente elemento mas pequenio (y el ID del
 * segmento al cual ese elemento pertenece).
 *
 * El algoritmo ejecuta los siguientes pasos:
 * 
 * 1) Divide el arreglo en segmentos consecutivos, donde los elementos de cada
 *    segmento estan ordenados de manera ascendente y la cantidad total de
 *    segmentos sea la mas minima posible.
 *    
 *    Por ejemplo, el arreglo [2, 4, 6, 7, 2, 3, 6, 5] se dividiria en los
 *    segmentos [2, 4, 6, 7], [2, 3, 6] y [5].  Nota que la division [2, 4],
 *    [6, 7], [2, 3, 6] y [5] no seria valida porque no seria la mimima division
 *    posible.
 *    
 * 2) Por cada segmento, agregamos su primer elemento a un Min Priority Queue.
 * 
 * 3) Por cada posicion del arreglo a ordenar
 * 
 *    3.1) Sobreescribimos su valor por el menor valor grabado en el Priority
 *         Queue
 *         
 *    3.2) Avanzamos el "indice" correspondiente del segmento
 *
 *
 * HINTS:
 *  a) Mi recomendacion es que conviertas cada segmento en un Queue, asi evitas
 *     trabajar con indices dentro de cada segmento
 *  b) La parte dificil es identificar el segmento al cual el elemento siguiente
 *     mas pequenio pertenece. Si solo encolas datos tipo int al PriorityQueue,
 *     seria dificil (aunque no imposible) identificarlo. Fijate en el ejemplo
 *     de encolar Student en TestPriorityQueue.cs.
 *
 */

using System;
using System.Text;
using System.Collections.Generic;


public class HW1
{
    public class Segmento : IComparable<Segmento>
    {
        public int numero { get;  set; }
        public int segmento { get; set;}

       

        public Segmento(int Num, int segmento)
        {
            this.numero = Num;
            this.segmento = segmento;
        }

        public int CompareTo(Segmento other)
        {
            if (this.numero < other.numero)
                return -1;
            else if (this.numero > other.numero)
                return +1;
            else
                return 0;
        }
    }

    public static void Sort(int[] A)
    {

        var QU = new Queue<int>();
        var PQ1 = new PriorityQueue<Segmento>();
        Queue<int>[] segmentos;
        int x = 1;
        int y = 0;

        // Primera Parte y segunda parte

        // Complejidad N
        for (int i = 1; i < A.Length; i++)
         {
           if(A[i] < A[i - 1])
                x++;
         }

         segmentos = new Queue<int>[x];

         // N log N
         for (int i = 0; i <A.Length; i++)
         {
            if (i == 0)
            {
                segmentos[y] = new Queue<int>();
                segmentos[y].Enqueue(A[i]);
                Segmento dato = new Segmento(A[i], y);
                PQ1.Enqueue(dato);
                continue;
            }
            if (A[i] < A[i - 1])
            {
                y++;
                segmentos[y] = new Queue<int>();
                segmentos[y].Enqueue(A[i]);
                Segmento dato = new Segmento(A[i], y);
                PQ1.Enqueue(dato);
            }
            else
                segmentos[y].Enqueue(A[i]);
         }

        // Tercer parte

        // N log N

        for(int i = 0; i < A.Length; i++)
        {
            Segmento dato = PQ1.Dequeue();

            A[i] = dato.numero;

            segmentos[dato.segmento].Dequeue();

            if (segmentos[dato.segmento].Count != 0)
            {
                dato.numero = segmentos[dato.segmento].Peek();
                PQ1.Enqueue(dato);
            }

           
        }
     


        // TODO: implementar algoritmo descrito arriba
        // Valor: 9 puntos
        //        1 punto extra si logras implementar una version donde ordenas
        //          un arreglo de cualquier tipo de datos (que sea comparable)
        // Complejidad esperada: Theta(N log N) worst-case

    }

    public static void Main(string[] args)
    {

        // 1 2 2 3 3 3 4 5 5 6 7 8 8 8 8
        // 3 8    3 3 7 8 8    4 5 5 6     2     1 2 8

        int[] A = { 3, 8, 3, 3, 7, 8, 8, 4, 5, 5, 6, 2, 1, 2, 8 };
        Sort(A);
        foreach (int x in A)
            Console.Write("{0} ", x);
        Console.WriteLine();
        Console.ReadKey();
    }
}

