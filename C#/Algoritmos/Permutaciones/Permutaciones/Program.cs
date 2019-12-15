using System;
using System.Collections.Generic;

namespace Permutaciones
{
    class Program
    {
   
            static void Main(string[] args)
            {
                int[] A = { 1, 3, 5 };
                Permutation K = new Permutation(A);
                Console.ReadKey();
            }
       
    }

    class Permutation
    {

        int[] A;
        LinkedList<int> Sol = new LinkedList<int>();

        public Permutation(int[] a)
        {
            A = a;
            Permutaciones(Sol);
        }

        void Permutaciones(LinkedList<int> P)
        {
            if(P.Count == A.Length)
            {
                foreach (int b in P)
                {
                    Console.Write(A[b] + " ");
                }
                Console.WriteLine();
                return;
            }

            for(int i = 0; i <A.Length; i++)
            {
                P.AddLast(i);
                if (!checkDuplicate(P,i))
                {
                    Permutaciones(P);
                }
                P.RemoveLast();

            }
        }

        private bool checkDuplicate(LinkedList<int> p, int i )
        {
            int contador = 0;
            foreach(int k in p)
            {
                if (k == i)
                    contador++;
            }
            if (contador > 1)
                return true;
            return false;
        }
    }
}
