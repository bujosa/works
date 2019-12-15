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
using System.Collections.Generic;
using System.Text;


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
    public bool[,,] cached;
    public long[,,] memu;
    public int[,,] p;
    public string global;
    public string A;
    public string B;

    public override string Solve(string A, string B, string C)
    {
        cached = new bool[C.Length, C.Length, C.Length];
        memu = new long[C.Length,C.Length, C.Length];
        p = new int[C.Length, C.Length, C.Length];
        global = C;
        this.A = A;
        this.B = B;

        long x = F(0, 0, 0); // Este X guarda el minimo es para tener una idea de
        // cuanto cogio del string 3

        return res();

        // TODO: Implementar algoritmo basado en Dynamic Programming
        // Valor: 7 puntos

        // TODO: Determina cual es la complejidad de tu solucion
        // Valor: 1 punto

        // O(N^3) en el worst case
        // donde la N es el tamaño del string c 
    }


    // Rescata mi solucion
    private string res()
    {
        string D = "";
        int s1 = 0, s2 = 0, s3 = 0;

        while (true)
        {
            if (s1 + s2 + s3 == global.Length)
                break;

            int s = p[s1, s2, s3];

            if (s == 1)
            {
                D += "A";
                s1 += 1;
            }
            else if (s == 2)
            {
                D += "B";
                s2 += 1;
            }
            else
            {
                D += "+";
                s3 += 1;
            }

        }

        return D;
    }

   

    // Esta funcion te retorna el minimo de veces que se coge una letra del string 3
    private long F(int s1, int s2, int s3)
    {
        if (s1 + s2 + s3 == global.Length)
            return s3;

        if (s3 == global.Length)  // Tomando en dado caso de que quiera irse siempre por 3
            return int.MaxValue; // pero en caso de que sea la unica solucion al final lo coge.

        if (cached[s1, s2, s3])
            return memu[s1,s2,s3];
             
        long res = int.MaxValue;
        long res1 = int.MaxValue;
        long res2 = int.MaxValue;
        long res3 = int.MaxValue;

        if (s1 < A.Length)
        {
            if (global.Substring(s1 + s2 + s3, 1) == A.Substring(s1, 1))
                res1 = F(s1 + 1, s2, s3);
        }

        if (s2 < B.Length)
        {
            if (global.Substring(s1 + s2 + s3, 1) == B.Substring(s2, 1))
                res2 = F(s1, s2 + 1, s3);
        }

        res3 = F(s1, s2, s3 + 1); // Coger de C

        if (res1 <= res2 && res1 <= res3){
            res = res1;
            p[s1, s2, s3] = 1; }
        else if (res2 <= res1 && res2 <= res3) {
            res = res2;
            p[s1, s2, s3] = 2; }
        else {
            p[s1, s2, s3] = 3;
            res = res3; }

        memu[s1, s2, s3] = res;
        cached[s1, s2, s3] = true;

        return res;
    }
}

class HW3i
{
    static void Main(string[] args)
    {
        string A = "caradc";
        string B = "abbacura";
        string C = "abracadabra";

        A = "arithmetic";
        B = "lol";
        C = "algorithm";

        A = "batman";
        B = "superman";
        C = "superbadman";

        A = "a";
        B = "baaaaaaaaaa";
        C = "aaaaa";

        A = "cepillo";
        B = "caramelo";
        C = "caramelocepillocaramelo"; 

        Solution s = new MyDPSolution();
        string D = s.Solve(A, B, C);

        Console.WriteLine("D = " + D);

        Console.ReadKey();

        // Mi output: D = BB++AA++BAA

            // TODO: Encuentra un contraejemplo para el siguiente algoritmo greedy:
            //       1) Colocamos las letras del string A en un queue (en orden de
            //          izquierda a derecha) y las del string B en otro queue
            //       2) Por cada letra de C (de izquierda a derecha),
            //          2.1) intento hacer match con la letra en frente del queue
            //               de A. Si coinciden, ejecuto pop del queue A (para que
            //               avance a la siguiente letra).
            //          2.2) De lo contrario, intento hacer el match con la letra
            //               en frente del queue de B. Si coinciden, hago pop de B.
            //          2.3) Si ninguna de las letras en el frente de A ni de B
            //               coincidieron, estoy forzado a agregar una letra de
            //               la tercera fuente
    
        // Valor: 1 punto extra

        // Un contra ejemplo seria:

        // Este A = "abcdegz"
        //      B = "agjhijkx"
        //      C = "gkejidchbj"
        
        // El algoritmo greedy terminaria cogiendo toda de C y no tocaria ninguna de A y B
        // Si se tomara encuenta otro algoritmo si pudiera tomar en cuenta A y B y al final cogeria 
        // todas de esas dos como se ve en el sigueinte desarrollo:

        // Obviaria X y z y cogeria de a y b las sigueintes letras:

        // a: g e d c b 
        // b : k j i h j
        // C: ninguna

    }
}
