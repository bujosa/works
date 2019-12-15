/*
 * Puntos ejercicio: 7
 * 
 * Tenemos un arreglo ordenado A que contiene los numeros enteros de 1 a N, con
 * excepcion de uno de ellos que esta ausente.  Inicialmente, el contenido del
 * arreglo te es desconocido, pero sabemos que no hay repeticiones.  En
 * cualquier instante, puedes preguntar por el valor de cualquier celda, pero
 * la cantidad de preguntas que puedes hacer esta limitado.  Tu objetivo es
 * encontrar el elemento faltante del arreglo.
 *
 * La clase MysteryArray provee tres metodos publicos y tres propiedades:
 *    MysteryArray(int testId)
 *       Constructor que inicializa la prueba identificada con el numero testId.
 *
 *    int Reveal(int pos)
 *       Este metodo devuelve el valor grabado en la posicion 'pos' del arreglo.
 *       La posicion es 0-based.
 *
 *    void VerifyAnswer(int answer)
 *       Verifica si tu respuesta coincide con la respuesta correcta.  Tu
 *       solucion no debe llamar este metodo porque el metodo Main ya lo llama.
 *
 *    int N
 *       Esta es la N del enunciado
 * 
 *    int MaxNumAccesses
 *       La cantidad maxima de preguntas permitidas
 * 
 *   int CurNumAccesses
 *       La cantidad de preguntas que ya hiciste
 *
 *
 * La clase MysteryArray esta implementado en el archivo MysteryArray.dll, el
 * cual debes agregar como referencia en tu proyecto de Visual Studio. El source
 * code de esa clase no es relevante para implementar tu algoritmo.
 *
 * NOTA 2: Antes de diseniar tus algoritmos, sugiero que primero intentes
 * resolver las pruebas interactivas con testId 0 o negativos.
 *
 * Ubica todas las secciones con el tag TODO.  Cada tag les indicara que deben
 * completar.
 * 
 */

using System;

interface Solution
{
    int Solve( MysteryArray A );
}


class YourSolution : Solution
{
    public int Solve( MysteryArray A )
    {
        // TODO: Implementar un algoritmo para determinar el elemento faltante
        //       de un arreglo ordenado de elementos de 1 a N, donde siempre
        //       falta un solo elemento.
        //       Debes devolver el valor del elemento faltante.
        // Valor: 2 puntos si logras pasar los tests con IDs del 1 al 100
        //        5 puntos adicionales si logras pasar los demas tests

        return 0;
    }
}



public class HW1m
{
    public static void Main()
    {

        // ===========================================================
        // Test 0 o negativo: 2 <= N <= 100, 100 preguntas permitidas
        // ===========================================================
        /*
        {
            MysteryArray A = new MysteryArray(0);
            InteractiveTest(A);
            return;
        }
        */


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
        // Tests 11-100: N ~ 100, 100 preguntas permitidas
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


    // Para probar tus ideas desde la consola
    public static void InteractiveTest( MysteryArray A )
    {
        Console.WriteLine("Prueba interactiva con N = {0} y {1} preguntas",
                          A.N, A.MaxNumAccesses);
        Console.WriteLine("Escriba uno de los siguientes comandos:");
        Console.WriteLine("V <pos>");
        Console.WriteLine("E <x>");
        Console.WriteLine("* El comando V revela el valor en la posicion 'pos'");
        Console.WriteLine("* El comando E termina la prueba y sometes el valor 'x'");
        Console.WriteLine("  como tu respuesta final");
        while (true)
        {
            Console.Write("[{0}/{1}] > ", A.CurNumAccesses, A.MaxNumAccesses);
            string line = Console.ReadLine();
            if (line == null) break;
            if (line.Length == 0) continue;
            string[] parts = line.Split(' ');
            if (parts.Length == 0) continue;
            if (parts[0] == "V" || parts[0] == "v") {
                if (parts.Length != 2) {
                    Console.WriteLine("Comando acepta un (solo) parametro");
                    continue;
                }
                int pos = int.Parse(parts[1]);
                int x = A.Reveal(pos);
                Console.WriteLine("Valor en posicion {0} es {1}", pos, x);
            }
            else if (parts[0] == "E" || parts[0] == "e") {
                if (parts.Length != 2) {
                    Console.WriteLine("Comando acepta un (solo) parametro");
                    continue;
                }
                int answer = int.Parse(parts[1]);
                try
                {
                    A.VerifyAnswer(answer);
                    Console.WriteLine("Felicidades! Tu respuesta es correcta");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                break;
            }
            else {
                Console.WriteLine("Comando invalido");
                continue;
            }
        }
    }
}

