/*
 * Puntos ejercicio: 5
 *
 * "Avengers Assemble!" es el grito de guerra del Captain America para que el
 * equipo de vengadores ataquen juntos contra el ejercito de Thanos.
 *
 * Desafortunadamente, en vez de una sola fila, los Avengers se alinearon en dos
 * filas.  Por suerte, cada fila de superheroes esta ordenada por el nombre del
 * del superheroe (en orden alfabetico).  Pero, para colmo, las filas son Linked
 * Lists!
 *
 * Tu mision es hacer un "merge" de las dos filas en una sola.
 *
 * Ubica todas las secciones con el tag TODO.  Cada tag les indicara que deben
 * completar.  Para TODOs que requieren respuestas, escribe las respuestas en
 * un comment.
 *
 * Para mas informacion sobre LinkedList de C#, consulta la documentacion en:
 * https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=netframework-4.5.2
 *
 */


using System;
using System.Text;
using System.Collections.Generic;

class Lab1a
{
    static LinkedList<string>
        Assemble(LinkedList<string> fila1, LinkedList<string> fila2)
    {
        LinkedList<string> merge = new LinkedList<string>();

        int ValueMax = fila1.Count + fila2.Count;
        string comparacion = "";
        string comparacion2 = "";


        for (int i = 0; i < ValueMax; i++)
        {
       
            if (fila1.First != null && fila2.First != null)
            {
                comparacion = fila1.First.Value;
                comparacion2 = fila2.First.Value;
                int z = comparacion.CompareTo(comparacion2);

                if (z <= 0)
                {
                    if (fila1.First == null)
                        break;
                    var tmp3 = fila1.First;
                    fila1.RemoveFirst();
                    merge.AddLast(tmp3);
                }
                else
                {
                    if (fila2.First == null)
                        break;
                    var tmp4 = fila2.First;
                    fila2.RemoveFirst();
                    merge.AddLast(tmp4);
                }
            }
            else if( fila1.First == null)
            {
                while (fila2.First != null)
                {
                    var tmp = fila2.First;
                    fila2.RemoveFirst();
                    merge.AddLast(tmp);
                }
                break;
            }
            else
            {
                while(fila1.First != null)
                {
                    var tmp2 = fila1.First;
                    fila1.RemoveFirst();
                    merge.AddLast(tmp2);
                }
                break;
            }            
        }
        // TODO: implementar
        // Restriccion: tu solucion NO debe crear nodos nuevos.
        // HINT: C# provee metodos especificos que trabajan con parametros de
        //       tipo LinkedListNode
        // Complejidad esperada: O(N1 + N2)
        // Valor: 6 puntos

        return merge;
    }

    public static void Main()
    {
        LinkedList<string> fila1 = new LinkedList<string>(
            new string[] {

                "Ant-Man",
                "Black Panther",
                "Captain America",
                "Captain Marvel",
                "Falcon",
                "Hulk",
                "M'Baku",
                "Okoye",
                "Shuri",
                "Thor",
                "Valkyrie",
                "Wasp",
                "Winter Soldier"
            }
        );

        LinkedList<string> fila2 = new LinkedList<string>(
            new string[] {
                "Doctor Strange",
                "Drax",
                "Groot",
                "Hawkeye",
                "Iron Man",
                "Mantis",
                "Nebula",
                "Pepper Potts",
                "Rocket",
                "Star-Lord",
                "Scarlet Witch",
                "Spider-Man",
                "War Machine",
                "Wong"
            }
        );

        LinkedList<string> fila = Assemble(fila1, fila2);
        foreach (string name in fila)
        {
            Console.WriteLine(name);
        }
        Console.ReadKey();
    }
}
