    /*
     * Puntos ejercicio: 7
     * 
     * Tenemos un arreglo ordenado A que contiene los numeros enteros de 1 a N, con
     * excepcion de uno de ellos que esta ausente.  Inicialmente, el contenido del
     * arreglo te es desconocido, pero sabemos que no hay repeticiones.  En
     * cualquier instante, puedes preguntar por el valor de cualquier celda, pero
     * la cantidad de preguntas que puedes hacer esta limitado.  Tu objetivo es
     * encontrar el elemento faltante del arreglo.
     */

    using System;

    interface Solution
    {
        int Solve(MysteryArray A);
    }


    class YourSolution : Solution
    {
        public int Solve(MysteryArray A)
        {

            int N = A.N;
            int L = 0, R = N, x = 0;
            int y = N;
            if (y % 2 == 1)
               y++;
            int CurrentPosition = (y-2) / 2;
    
            while (A.CurNumAccesses <= A.MaxNumAccesses)
            {

             if (CurrentPosition % 2 != 0 && R-L > 10)
                CurrentPosition += 1;

               if (R - L > 2 && A.CurNumAccesses != A.MaxNumAccesses)
                 x = A.Reveal(CurrentPosition);

              if (A.CurNumAccesses == A.MaxNumAccesses)
                return L + 2;

              if (CurrentPosition + 2 == x)
                R = x-1;
              else if (CurrentPosition + 2 > x)
                L = x;
           
            // Caso de diferencia 2

                if (L + 2 == R)
                {
                    if ( A.CurNumAccesses == A.MaxNumAccesses)
                       return R;

                    x = A.Reveal(L);
                  
                    if (L + 1 == x)
                        return R;
                    else
                        return R - 1;              
                }

                // caso de diferencia 1

                if(L + 1 == R)
                    return R;

                CurrentPosition = (L + ((R - L) / 2)); // Organizacion del current
     
            }

         return 0;
        }
    }



    public class HW1m
    {
        public static void Main()
        {

   

        
            // ===========================================================
            // Test 1 a 10: N = 10, 10 preguntas permitidas
            // ===========================================================
        
            for (int testNum = 1; testNum <= 10; testNum++)
            {
                Solution s = new YourSolution();
                MysteryArray A = new MysteryArray(testNum);
                int answer = s.Solve(A);
                A.VerifyAnswer(answer);
                Console.WriteLine(
                    "Test {0}  OK  #Accesses: {1} of {2}",
                    testNum, A.CurNumAccesses, A.MaxNumAccesses);
            }
        
            // OJO: en el test 10, N = 10 y el elemento que falta es 10


            // ===========================================================
            // Tests 11-100: N ~ 100, 10 preguntas permitidas
            // ===========================================================
        
            for (int testNum = 11; testNum <= 100; testNum++)
            {
                Solution s = new YourSolution();
                MysteryArray A = new MysteryArray(testNum);
                int answer = s.Solve(A);
                A.VerifyAnswer(answer);
                Console.WriteLine(
                    "Test {0}  OK  #Accesses: {1} of {2}",
                    testNum, A.CurNumAccesses, A.MaxNumAccesses);
            }

         
            // ===========================================================
            // Tests 101-200: N ~ 1000, 10 preguntas permitidas
            // ===========================================================
           
            for (int testNum = 101; testNum <= 200; testNum++)
            {
            if (testNum == 104)
                Console.ReadKey();
                Solution s = new YourSolution();
                MysteryArray A = new MysteryArray(testNum);
                int answer = s.Solve(A);
                A.VerifyAnswer(answer);
                Console.WriteLine(
                    "Test {0}  OK  #Accesses: {1} of {2}",
                    testNum, A.CurNumAccesses, A.MaxNumAccesses);
            }
        

        
            // ===========================================================
            // Tests 201-300: N ~ 10000, 15 preguntas permitidas
            // ===========================================================
            for (int testNum = 201; testNum <= 300; testNum++)
            {
           
            Solution s = new YourSolution();
                MysteryArray A = new MysteryArray(testNum);
                int answer = s.Solve(A);
                A.VerifyAnswer(answer);
                Console.WriteLine(
                    "Test {0}  OK  #Accesses: {1} of {2}",
                    testNum, A.CurNumAccesses, A.MaxNumAccesses);
            }

        
            // ===========================================================
            // Tests 301-400: N ~ 100000, 20 preguntas permitidas
            // ===========================================================
            for (int testNum = 301; testNum <= 400; testNum++)
            {
                Solution s = new YourSolution();
                MysteryArray A = new MysteryArray(testNum);
                int answer = s.Solve(A);
                A.VerifyAnswer(answer);
                Console.WriteLine(
                    "Test {0}  OK  #Accesses: {1} of {2}",
                    testNum, A.CurNumAccesses, A.MaxNumAccesses);
            }


            // ===========================================================
            // Tests 401-500: N ~ 1000000, 20 preguntas permitidas
            // ===========================================================
            for (int testNum = 401; testNum <= 500; testNum++)
            {
                Solution s = new YourSolution();
                MysteryArray A = new MysteryArray(testNum);
                int answer = s.Solve(A);
                A.VerifyAnswer(answer);
                Console.WriteLine(
                    "Test {0}  OK  #Accesses: {1} of {2}",
                    testNum, A.CurNumAccesses, A.MaxNumAccesses);
            }
    
        }

    }

