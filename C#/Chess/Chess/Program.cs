using System;
using System.Collections.Generic;

class MainClass
{
    public static List<List<char>> tablero = new List<List<char>>();
    public static string Jugador = "";
    public static Dictionary<char, int> calidad = new Dictionary<char, int>();

    public static void llenarTablero(string fen)
    {
        string[] filas = fen.Split('/');
       
        foreach (string fila in filas)
        {
            List<char> row = new List<char>();
            foreach (char c in fila)
            {
                int check = c - '0';
                if (Char.IsDigit(c))
                {
                    for (int spaces = 0; spaces < check; spaces++)
                        row.Add('.');
                }
                else
                    row.Add(c);
            }
            tablero.Add(row);
        }
    }

    public static void imprimirTablero()
    {
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
                Console.Write(tablero[x][y]);
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {

        string input = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
        string[] parametros = input.Split(' ');
        string inputTablero = parametros[0];
        llenarTablero(inputTablero);
        imprimirTablero();
        AlmacenarCalida();
        AnalizarInput(parametros);
        Console.ReadKey();
    }

    static void AlmacenarCalida()
    {
        calidad.Add('p', 1);
        calidad.Add('P', 1);
        calidad.Add('K', 0);
        calidad.Add('k', 0);
        calidad.Add('Q', 9);
        calidad.Add('q', 9);
        calidad.Add('N', 3);
        calidad.Add('n', 3);
        calidad.Add('B', 3);
        calidad.Add('b', 3);
        calidad.Add('R', 5);
        calidad.Add('r', 5);

    }

    static void AnalizarInput(string[] input)
    {

        int LB = 0; // Lado Blanco
        int LN = 0; // Lado Negro
        if (input.Length < 2)
        {
            Console.WriteLine("Error en el input no es el formato de FEN");
            return;
        }

        string[] lados = input[0].Split('/');
        for(int i =0; i < lados.Length; i++)
        {
            if (i > 2)
            {
                foreach (char x in lados[i])
                {
                    if (calidad.ContainsKey(x) != false)
                        LB += calidad[x];
                }

                continue;
            }

            foreach (char x in lados[i])
            {
                if(calidad.ContainsKey(x) != false)
                   LN += calidad[x];
            }
        }

        Jugador = input[1];

        if (Jugador == "w")
            Jugador = "Les Toca a las Blancas jugar";
        else
            Jugador = "Les Toca a las Negras jugar";

        Console.WriteLine(Jugador);
        Console.WriteLine("Las calidad en valor de las blancas son {0}", LB);
        Console.WriteLine("Las calidad en valor de las negras son {0}", LN);
     
    }
}
