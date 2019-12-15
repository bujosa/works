using System;
using System.Collections.Generic;

namespace JSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 3, 5, 6, 2, 7, 8 };
            int Target = 13;
            int J = 3;
            Jsum numero = new Jsum(A,Target,J);
            Console.ReadKey();
        }
    }

    class Jsum
    {
        int[] A;
        int target_sum;
        int J;
        LinkedList<int> P = new LinkedList<int>();

        public Jsum(int[] a, int target_sum, int j)
        {
            A = a;
            this.target_sum = target_sum;
            J = j;
            Rec(J);
        }

       void Rec(int j)
        {
            if(j == 0)
            {
                int sum = 0;
                foreach (int i in P) sum += A[i];
                if(sum == target_sum)
                {
                    foreach (int i in P) Console.Write(A[i] + " ");
                    Console.WriteLine("La suma es Igual a {0} ", target_sum);
                }

                return;
            }
            for(int i = 0; i <A.Length; i++)
            {
                P.AddLast(i);
                Rec(j - 1);
                P.RemoveLast();
            }
       
        }
    }
}
