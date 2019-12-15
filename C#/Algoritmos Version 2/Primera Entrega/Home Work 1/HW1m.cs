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
 * 1) Divide el arreglo en segmentos consecutivos, donde los elementos de cada
 *    segmento estan ordenados de manera ascendente y la cantidad total de
 *    segmentos sea la mas minima posible.
 *    Por ejemplo, el arreglo [2, 4, 6, 7, 2, 3, 6, 5] se dividiria en los
 *    segmentos [2, 4, 6, 7], [2, 3, 6] y [5].  Nota que la division [2, 4],
 *    [6, 7], [2, 3, 6] y [5] no seria valida porque no seria la mimima division
 *    posible.
 * 2) Por cada segmento, agregamos su primer elemento a un Min Priority Queue.
 * 3) Por cada posicion del arreglo a ordenar,
 *    3.1) Sobreescribimos su valor por el menor valor grabado en el Priority
 *         Queue
 *    3.2) Avanzamos el "indice" correspondiente del segmento
 *
 * La libreria PriorityQueue.dll contiene una implementacion de Min Priority
 * Queue. Para usarlo, agregalo como referencia en tu proyecto de Visual Studio.
 * El source code de esa clase no es relevante para implementar tu algoritmo de
 * este ejercicio.  Como guia de como usar esa clase, revisa el codigo en
 * TestPriorityQueue.cs.
 *
 * HINTS:
 *  a) Mi recomendacion es que conviertas cada segmento en un Queue, asi evitas
 *     trabajar con indices dentro de cada segmento
 *  b) La parte dificil es identificar el segmento al cual el elemento siguiente
 *     mas pequenio pertenece. Si solo encolas datos tipo int al PriorityQueue,
 *     seria dificil (aunque no imposible) identificarlo. Fijate en el ejemplo
 *     de encolar Student en TestPriorityQueue.cs.
 *
 * Ubica todas las secciones con el tag TODO.  Cada tag les indicara que deben
 * completar.
 *
 */

using System;
using System.Text;
using System.Collections.Generic;


public class HW1
{
    public static void Sort(int[] A)
    {
        // TODO: implementar algoritmo descrito arriba
        // Valor: 9 puntos
        //        1 punto extra si logras implementar una version donde ordenas
        //          un arreglo de cualquier tipo de datos (que sea comparable)
        // Complejidad esperada: Theta(N log N) worst-case

    }
    
    public static void Main(string[] args)
    {
        int[] A = {3, 8, 3, 3, 7, 8, 8, 4, 5, 5, 6, 2, 1, 2, 8};
        Sort(A);
        foreach (int x in A)
           Console.Write("{0} ", x);
        Console.WriteLine();
    }
}

 