/*
 * Puntos ejercicio: 11 (+1 extra)
 * 
 * Un String no es mas que una secuencia de caracteres.  Como cualquier otra
 * secuencia, lo podemos representar con un arreglo (dinamico).
 * 
 * En este ejercicio, completa los metodos que faltan en la clase DynString.
 *
 * En las complejidades, la variable N se refiere al tamanio (size) del string.
 *
 * Ubica todas las secciones con el tag TODO.  Cada tag les indicara que deben
 * completar.  Para TODOs que requieren respuestas, escribe las respuestas en
 * un comment.
 * 
 */

using System;
using System.Text;

namespace MyClassList
{
    class DynString
    {
        private char[] arr;       // arreglo (dinamico) que representa el string
        public int Size { get; private set; }  // cantidad de caracteres en el string


        // constructor de un string vacio
        public DynString()
        {
            arr = new char[1];
            Size = 0;
        }


        // constructor basado en un string de C#
        public DynString(string s)
        {

            Size = s.Length + Size;
            arr = new char[Size];

            for (int i = 0; i < Size; i++)
            {
                arr[i] = s[i];
            }
            // TODO: Implementar. Inicializa correctamente el arreglo arr y la
            //       propiedad Size.  No tienes que usar la estrategia descrita
            //       en el metodo Insert.
            // Complejidad esperada: O(S), donde S es el length del string s
            // Valor: 1 punto

        }


        // Devolver el substring que empieza en la posicion start hasta la posicion 
        // end (ambos extremos son incluyentes)
        public DynString Substring(int start, int end)
        {

            // TODO: Implementar.
            // Complejidad esperada: O(end - start)
            // Valor: 2 puntos

            DynString ret = new DynString();
            ret.arr = new char[end - start + 1];
            ret.Size = end - start + 1;

            for (int i = start, j = 0; j < Size; i++, j++)
            {
                ret.arr[j] = this.arr[i];
            }
            return null;
        }


        private const int FACTOR_CRECIMIENTO = 2;  // factor de crecimiento a usar

        // Insertar el MyString str justamente antes de la posicion pos. Debes rodar
        // los caracteres desde la posicion pos hasta la ultima hacia la derecha.
        // Si pos == 0, inserta al inicio de MyString; si pos == Size, inserta
        // al final de MyString (ver uso en el metodo Concat)
        public void Insert(DynString str, int pos)
        {
            // TODO: Implementar la siguiente estrategia: Si str no cabe en este
            //       string, "agrandalo" usando el factor de crecimiento hasta que
            //       quepa.  Por ejemplo, si la capacidad actual de arr es 3 y
            //       str.Size == 10, necesitarias por lo menos 13 celdas y la
            //       nueva capacidad de arr seria 3*2*2*2.
            // Complejidad esperada: O(N + M) worst-case, donde M es el size del
            //                       string str. Nota que la nueva capacidad nunca
            //                       se pasa de 2*(N + M)
            // Valor: 5 puntos

        }


        // Concatenar el str al final de este string
        public void Concat(DynString str)
        {
            Insert(str, Size);
        }


        // Borrar el substring que va desde la posicion start hasta la posicion end.
        // Debes rodar los caractetes desde la posicion end hasta la ultima hacia
        // la izquierda.
        public void Erase(int start, int end)
        {
            // TODO: Implementar.  Luego de borrado, no es necesario reducir la
            //       capacidad del arreglo arr.
            // Complejidad esperada: O(N - (end - start))
            // Valor: 3 puntos

        }


        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Size; i++)
                sb.Append(arr[i]);
            return sb.ToString();
        }
    }



    class Mylist
    {
        public static void Main()
        {
            DynString S = new DynString();

            DynString T = new DynString("world");
            S.Concat(T);

            T = new DynString("Hello ");
            S.Insert(T, 0);

            S.Insert(new DynString(" cruel"), 5);
            Console.WriteLine("S = " + S);

            Console.WriteLine("S.Substring(0, 4) = " + S.Substring(0, 4));

            S.Erase(6, 11);
            Console.WriteLine("S = " + S);


            // TODO: Disenia un experimento que muestre cual es la complejidad de la
            //       operacion StringBuilder.Append(char) en C#.  Justifica bien tu
            //       conclusion.
            // Valor: 1 punto extra
        }
    }
}