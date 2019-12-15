/*
 * Puntos ejercicio: 8 (+ 1 extra)
 *
 * Dado 3 strings A, B y C, construye el string C, letra por letra, desde la
 * primera hasta la ultima, usando tres posibles fuentes de letras: 
 *   a) Las letras del string A
 *   b) Las letras del string B
 *   c) Todas las letras que desees agregar
 *
 * A diferencia de la tercera fuente, las letras del string A y del string B
 * no se pueden tomar en orden arbitrario: solo puedes tomar una letra de una
 * posicion si ya tomaste todas de posiciones anteriores. Por ejemplo, si el
 * string A es "abbcc", no puedes usar la letra 'c' de la posicion 3 hasta que
 * no "consumas" las letras de las posiciones 0 a 2.
 * 
 * Cual es la cantidad minima de letras que se requiere agregar (de la tercera
 * fuente) para lograr construir el string C?
 *
 * Ubica todas las secciones con el tag TODO.  Cada tag les indicara que deben
 * completar.  Para TODOs que requieren respuestas, escribe las respuestas en
 * un comment.
 * 
 */

using System;


// Esta clase abstracta es para facilitar mi trabajo de corregir este homework.
// Tu solucion debe sobreescribir el metodo Solve en la clase MyDPSoltution
public abstract class Solution
{
    // Este es el metodo que debes implementar
    // Devuelve un string D de tamanio C.Length donde:
    //   * D[i] = 'A' si la letra de la posicion i proviene del string A
    //   * D[i] = 'B' si la letra de la posicion i proviene del string B
    //   * D[i] = '+' si la letra de la posicion i fue agregado (3ra fuente)
    // De todas las posibles soluciones, devuelve un string donde se minimice la
    // cantidad de '+'
    public abstract string Solve(string A, string B, string C);
}


// Esta clase es donde debe implementar tu solucion basada en DP
public class MyDPSolution : Solution
{
    public int N;
    public string a, b, c;
    public bool[,,] cached;
    public int[,,] memoria;
    public int[,,] p;

    public override string Solve(string A, string B, string C)
    {

        if (A.Length == 0 || B.Length == 0)
            throw new NotImplementedException("No se puede operar");

        N = C.Length;

        cached = new bool[N, N, N];
        memoria = new int[N, N, N];
        p = new int[N, N, N];

        a = A;
        b = B;
        c = C;

        DP(0, 0, 0);

        string answer = respuesta();

        return answer;

        // TODO: Implementar algoritmo basado en Dynamic Programming
        // Valor: 7 puntos

        // TODO: Determina cual es la complejidad de tu solucion
        // Valor: 1 punto

        // Respuesta: Es Polinomial complejidad o(n^3)
    }

    private string respuesta()
    {

        int N1 = 0;
        int N2 = 0;
        int N3 = 0;
        int decisicion;
        string resultado = "";

        while (N1 + N2 + N3 < N)
        {

            decisicion = p[N1, N2, N3];

            if (decisicion == 1)
            {
                resultado += "A";
                N1 += 1;
                continue;
            }

            if (decisicion == 2)
            {
                resultado += "B";
                N2 += 1;
                continue;
            }

            resultado += "+";
            N3 += 1;
        }

        return resultado;
    }


    private int DP(int N1, int N2, int N3)
    {

        if (N3 == N)
            return int.MaxValue / 2;

        if (N2 == N || N1 == N)
            return N3;

        if (cached[N1, N2, N3])
            return memoria[N1, N2, N3];

        if (N1 + N2 + N3 == N)
            return N3;

        int dec = int.MaxValue / 2, dec1 = int.MaxValue / 2;
        int dec2 = int.MaxValue / 2, dec3 = int.MaxValue / 2;


        // TOMAR DESICION 1
        if (a.Length > N1 && N > N1 + N2 + N3)
        {
            if (a.Substring(N1, 1) == c.Substring(N1 + N2 + N3, 1))
            {
                dec1 = DP(N1 + 1, N2, N3);
            }
        }

        // TOMAR DESICION 2
        if (b.Length > N2 && N > N1 + N2 + N3)
        {
            if (b.Substring(N2, 1) == c.Substring(N1 + N2 + N3, 1))
            {
                dec2 = DP(N1, N2 + 1, N3);
            }
        }

        // TOMAR DESICION 3
        dec3 = DP(N1, N2, N3 + 1);

        int x = desicion(dec1, dec2, dec3);

        // Para guardar las desiciones 
        p[N1, N2, N3] = x;

        if (x == 1)
            dec = dec1;
        else if (x == 2)
            dec = dec2;
        else
            dec = dec3;

        memoria[N1, N2, N3] = dec;
        cached[N1, N2, N3] = true;

        return dec;
    }

    int desicion(int v1, int v2, int v3)
    {
        if (v1 <= v2 && v1 <= v3)
            return 1;
        else if (v2 <= v1 && v2 <= v3)
            return 2;
        else
            return -1;
    }
}

class HW3i
{
    static void Main(string[] args)
    {
        /*
        string A = "caradc";
        string B = "abbacura";
        string C = "abracadabra";
        */
        string A = "cepillo";
        string B = "caramelo";
        string C = "caramelo";
        
        Solution s = new MyDPSolution();
        string D = s.Solve(A, B, C);

        Console.WriteLine("D = " + D);
        Console.ReadLine();

        // Mi output: D = BB++AA++BAA

    }
}
