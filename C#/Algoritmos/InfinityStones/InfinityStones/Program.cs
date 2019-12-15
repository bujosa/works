/*
 * Puntos ejercicio: 12 (+4 extras)
 * 
 * Los Avengers estan tratando de juntar todos los Infinity Stones para reversar
 * el snap de Thanos.  Una de esas gemas es el Time Stone, el cual se encuentra
 * bajo la custodia del Sorcerer Supreme vigente en 2012: The Ancient One.
 * 
 * La mision de recuperar esa gema cayo en manos de The Hulk, quien viaja en el
 * tiempo a 2012.
 * 
 * The Ancient One, presintiendo la presencia de gente desconocida que quieren
 * despojarle la gema, conjura un hechizo para esconder el Time Stone entre
 * otras gemas falsas.
 *
 * El hechizo funciona de la siguiente manera: las N piedras estan alineadas y
 * numeradas desde 0 a N-1 de izquierda a derecha. Tambien sabemos que el Time
 * Stone es la piedra mas ligera de todas y que cada piedra falsa tiene el mismo
 * peso.
 *
 * Para identificar el Time Stone entre las N piedras, dispones de una balanza
 * de dos brazos. En cada brazo, puedes colocar un intervalo (consecutivo) de
 * piedras. La balanza te indicara si el peso total de las piedras en el primer
 * brazo es mas ligero, pesado, o igual el peso total de las piedras en el
 * segundo brazo.
 * 
 * Professor Hulk es sumamente inteligente, pero no es muy diestro en el tema
 * de algoritmos. Por otro lado, Tony Stark, quien si sabe de algoritmos, esta
 * muy ocupado buscando el Teseract en 1970.  Por eso, the Hulk te pide tu
 * ayuda.
 *
 * En este ejercicio, la clase LocateTheTimeStone provee tres metodos publicos:
 *    LocateTheTimeStone(int testId)
 *       Constructor que inicializa la prueba identificada con el numero testId.
 *
 *    int Compare(int L1, int R1, int L2, int R2)
 *       Este metodo compara la suma de los pesos de las piedras en el intervalo
 *       desde L1 a R1 contra la suma de los pesos en el intervalo de L2 a R2.
 *       Este metodo devuelve -1 si las piedras en el primer intervalo pesan
 *       menos que las del segundo intervalo, +1 si pesan mas, y 0 si pesan lo
 *       mismo.
 *
 *    void VerifyAnswer(int answer)
 *       Verifica si tu respuesta coincide con la respuesta correcta.
 *
 * Tu objetivo es localizar el Time Stone: debes determinar la posicion del
 * Time Stone o devolver -1 si todas las piedras son falsas.
 *
 * Ahora, el hechizo de The Ancient One no es tan simple de romper:
 *    a) Existe un limite maximo de veces que puedes usar la balanza: solo se te
 *       permite invocar X veces el metodo Compare, donde X varia segun el caso
 *       de pruebas. Si lo excedes, ese metodo lanzara una excepcion (el cual
 *       no deberias capturar).
 *    b) The Ancient One te pudo haber mentido y escondido The Time Stone en
 *       otro sitio: o sea, todas las piedras son falsas
 *
 * NOTA 1: La clase LocateTheTimeStone se encuentra implementado en el archivo
 * TimeStone.dll, el cual debes agregar como referencia en tu proyecto de Visual
 * Studio.  El source code de esa clase no es relevante para implementar tu
 * algoritmo.  Como guia de como usar el metodo Compare de LocateTheTimeStone,
 * revisa la implementacion del metodo Solve en la clase BruteForceSolution.
 *
 * NOTA 2: Antes de diseniar tus algoritmos, sugiero que primero intentes
 * resolver la prueba interactiva identifica como testId 0.
 *
 * Ubica todas las secciones con el tag TODO.  Cada tag les indicara que deben
 * completar.  Para TODOs que requieren respuestas, escribe las respuestas en
 * un comment.
 * 
 */

using System;

interface Solution
{
    int Solve(LocateTheTimeStone g);
}


class BruteForceSolution : Solution
{
    // Solucion brute force: pasa las pruebas con id 1 y 2
    public int Solve(LocateTheTimeStone g)
    {
        int N = g.NumStones;

        for (int i = 0; i < N; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                int resultadoComparacion = g.Compare(i, i, j, j);
                if (resultadoComparacion > 0)
                    return j;
                else if (resultadoComparacion < 0)
                    return i;
            }
        }

        return -1;   // Ninguna de las piedras es el Time Stone
    }


}


class YourSolution : Solution
{
    public int Solve(LocateTheTimeStone g)
    {
        if (g.NumStones == 0)
            throw new InvalidOperationException();

        int N = g.NumStones, MaxComparable = 1, position = 0;
        int L1 = 0, R2 = N - 1, L2 = N / 2, R1 = L2 - 1, i = 0, Tmp = N, J = 0;

        if (N > 3)
        {
            Tmp = N;
            N = N / 3;
            J = (Tmp - (N * 3));
            L1 = 0;
            R1 = L1 + N - 1;
            L2 = R1 + 1;
            R2 = ((2 * N) - 1);
            N = N + J;
        }

        while (MaxComparable <= g.MaxNumComparisons)
        {
            if (N == 1)
                return position;
            if (N > 3)
            {
                i = g.Compare(L1, R1, L2, R2);
                if (i < 0)
                {
                    Tmp = N;
                    N = N / 3;
                    J = (Tmp - (N * 3));
                    R1 = L1 + N - 1;
                    L2 = R1 + 1;
                    R2 = L2 + (N - 1);
                    N = N + J;
                }
                else if (i > 0)
                {
                    Tmp = N;
                    N = N / 3;
                    J = (Tmp - (N * 3));
                    L1 = L2;
                    R1 = (L1 + (N - 1));
                    L2 = R1 + 1;
                    R2 = L2 + (N - 1);
                    N = N + J;
                }
                else
                {
                    Tmp = N;
                    N = N / 3;
                    J = (Tmp - (N * 3));
                    L1 = R2 + 1;
                    R1 = L1 + (N - 1);
                    L2 = R1 + 1;
                    R2 = L2 + (N - 1);
                    N = N + J;
                }
            }
            else
            {
                i = g.Compare(L1, L1, R2, R2);
                if (i < 0)
                    return L1;
                else if (i > 0)
                    return R2;
                else
                {
                    i = g.Compare(R1, R1, L2, L2);
                    if (i < 0)
                        return R1;
                    else if (i > 0)
                        return L2;
                    else
                    {
                        if (R2 + 1 < g.NumStones)
                        {
                            i = g.Compare(R2, R2, R2 + 1, R2 + 1);
                            if (i < 0)
                                return R2;
                            else if (i > 0)
                                return R2 + 1;
                            else
                            {
                                if (R2 + 2 < g.NumStones)
                                {
                                    i = g.Compare(R2, R2, R2 + 2, R2 + 2);
                                    if (i < 0)
                                        return R2;
                                    else if (i > 0)
                                        return R2 + 2;
                                    else
                                        return -1;

                                }
                            }

                        }
                        else
                            return -1;
                    }

                }
       
            }
            MaxComparable++;
        }
        // TODO: Implementar un algoritmo para localizar el Time Stone.
        //       Debes devolver la posicion del Time Stone o -1 si todas las
        //       piedras son falsas.
        // Valor: 4 puntos si logras pasar los tests con IDs del 1 al 100
        //        4 puntos adicionales si logras pasar los tests con IDs del 101 al 200
        //        4 puntos adicionales si logras pasar los tests con IDs del 201 al 300
        //        4 puntos extras si logras pasar los tests con IDs del 301 al 400
        return position;
    }
}



public class HW1s
{
    public static void Main()
    {

        // ===========================================================
        // Test 0 o negativo: entre 2 a 100 piedras, 100 comparaciones
        // ===========================================================
        /*
        {
            LocateTheTimeStone g = new LocateTheTimeStone(0);
            InteractiveTest(g);
        }
        */

        // ===========================================================
        // Test 1: 10 piedras, 100 comparaciones
        // ===========================================================
        {
            Solution s = new BruteForceSolution();
            LocateTheTimeStone g = new LocateTheTimeStone(1);
            int answer = s.Solve(g);
            g.VerifyAnswer(answer);
            Console.WriteLine(
                "Test {0}  OK  #Comparisons: {1} of {2}",
                1, g.CurNumComparisons, g.MaxNumComparisons);
        }


        // ===========================================================
        // Test 2: 10 piedras, todas falsas, 100 comparaciones
        // ===========================================================
        {
            Solution s = new BruteForceSolution();
            LocateTheTimeStone g = new LocateTheTimeStone(1);
            int answer = s.Solve(g);
            g.VerifyAnswer(answer);
            Console.WriteLine(
                "Test {0}  OK  #Comparisons: {1} of {2}",
                2, g.CurNumComparisons, g.MaxNumComparisons);
        }


        // ===========================================================
        // Tests 3-100: 1000 piedras, 1000 comparaciones
        // ===========================================================
        for (int testNum = 3; testNum <= 100; testNum++)
        {

            Solution s = new YourSolution();
            LocateTheTimeStone g = new LocateTheTimeStone(testNum);
            int answer = s.Solve(g);
            g.VerifyAnswer(answer);
            Console.WriteLine(
                "Test {0}  OK  #Comparisons: {1} of {2}",
                testNum, g.CurNumComparisons, g.MaxNumComparisons);
        }


        // ===========================================================
        // Tests 101-200: 1000 piedras, 501 comparaciones
        // ===========================================================
        for (int testNum = 101; testNum <= 200; testNum++)
        {

            Solution s = new YourSolution();
            LocateTheTimeStone g = new LocateTheTimeStone(testNum);
            int answer = s.Solve(g);
            g.VerifyAnswer(answer);
            Console.WriteLine(
                "Test {0}  OK  #Comparisons: {1} of {2}",
                testNum, g.CurNumComparisons, g.MaxNumComparisons);
        }


        // ===========================================================
        // Tests 201-300: 10000 piedras, 15 comparaciones
        // ===========================================================
        for (int testNum = 201; testNum <= 300; testNum++)
        {

            Solution s = new YourSolution();
            LocateTheTimeStone g = new LocateTheTimeStone(testNum);
            int answer = s.Solve(g);
            g.VerifyAnswer(answer);
            Console.WriteLine(
                "Test {0}  OK  #Comparisons: {1} of {2}",
                testNum, g.CurNumComparisons, g.MaxNumComparisons);
        }


        // ===========================================================
        // Tests 301-400: 100000 piedras, 15 comparaciones
        // ===========================================================

        for (int testNum = 301; testNum <= 400; testNum++)
        {

            Solution s = new YourSolution();
            LocateTheTimeStone g = new LocateTheTimeStone(testNum);
            int answer = s.Solve(g);
            g.VerifyAnswer(answer);
            Console.WriteLine(
                "Test {0}  OK  #Comparisons: {1} of {2}",
                testNum, g.CurNumComparisons, g.MaxNumComparisons);
        }


        // ===========================================================
        // Tests 401-500: 1000000 piedras, 15 comparaciones
        // ===========================================================
        
        for (int testNum = 401; testNum <= 500; testNum++)
        {
            Solution s = new YourSolution();
            LocateTheTimeStone g = new LocateTheTimeStone(testNum);
            int answer = s.Solve(g);
            g.VerifyAnswer(answer);
            Console.WriteLine(
                "Test {0}  OK  #Comparisons: {1} of {2}",
                testNum, g.CurNumComparisons, g.MaxNumComparisons);
        }
        


        // ===========================================================
        // Tests 401-500: 10000000 piedras, 17 comparaciones
        // ===========================================================
        
        for (int testNum = 501; testNum <= 600; testNum++)
        {
            Solution s = new YourSolution();
            LocateTheTimeStone g = new LocateTheTimeStone(testNum);
            int answer = s.Solve(g);
            g.VerifyAnswer(answer);
            Console.WriteLine(
                "Test {0}  OK  #Comparisons: {1} of {2}",
                testNum, g.CurNumComparisons, g.MaxNumComparisons);
        }
        


        Console.ReadKey();
    }


    // Para probar tus ideas desde la consola
    public static void InteractiveTest(LocateTheTimeStone g)
    {
        Console.WriteLine("Prueba interactiva con {0} piedras y {1} intentos",
                          g.NumStones, g.MaxNumComparisons);
        Console.WriteLine("Escriba uno de los siguientes comandos:");
        Console.WriteLine("C <L1> <R1> <L2> <R2>");
        Console.WriteLine("E <pos>");
        Console.WriteLine("* El comando C compara el peso del intervalo L1 a R1");
        Console.WriteLine("  contra el intervalo L2 a R2");
        Console.WriteLine("* El comando E termina la prueba y sometes la posicion");
        Console.WriteLine("  pos como tu respuesta final");
        while (true)
        {
            Console.Write("[{0}/{1}] > ", g.CurNumComparisons, g.MaxNumComparisons);
            string line = Console.ReadLine();
            if (line == null) break;
            if (line.Length == 0) continue;
            string[] parts = line.Split(' ');
            if (parts.Length == 0) continue;
            if (parts[0] == "C")
            {
                if (parts.Length != 5)
                {
                    Console.WriteLine("Comando acepta cuatro parametros");
                    continue;
                }
                int L1 = int.Parse(parts[1]);
                int R1 = int.Parse(parts[2]);
                int L2 = int.Parse(parts[3]);
                int R2 = int.Parse(parts[4]);
                int resultadoComparacion = g.Compare(L1, R1, L2, R2);
                if (resultadoComparacion < 0)
                {
                    Console.WriteLine(
                        "Intervalo [{0} .. {1}] es mas liviano que intervalo [{2} .. {3}]",
                        L1, R1, L2, R2);
                }
                else if (resultadoComparacion > 0)
                {
                    Console.WriteLine(
                        "Intervalo [{0} .. {1}] es mas pesado que intervalo [{2} .. {3}]",
                        L1, R1, L2, R2);
                }
                else
                {
                    Console.WriteLine(
                        "Intervalo [{0} .. {1}] tiene el mismo peso que intervalo [{2} .. {3}]",
                        L1, R1, L2, R2);
                }
            }
            else if (parts[0] == "E")
            {
                if (parts.Length != 2)
                {
                    Console.WriteLine("Comando acepta un (solo) parametro");
                    continue;
                }
                int answer = int.Parse(parts[1]);
                try
                {
                    g.VerifyAnswer(answer);
                    Console.WriteLine("Felicidades! Tu respuesta es correcta");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                break;
            }
            else
            {
                Console.WriteLine("Comando invalido");
                continue;
            }
        }
    }
}

