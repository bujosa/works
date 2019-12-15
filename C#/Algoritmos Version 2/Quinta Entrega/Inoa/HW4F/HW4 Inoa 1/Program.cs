/*
 * Puntos ejercicio: 5 puntos
 *
 * Implementa el algoritmo de Shortes Path Faster Algorithm (SPFA) para
 * encontrar un shortest path en un Weighted Directed Graph, representado en
 * forma de adjacency list.
 *
 * Ubica todas las secciones con el tag TODO.  Cada tag les indicara que deben
 * completar.  Para TODOs que requieren respuestas, escribe las respuestas en
 * un comment.
 *
 */

using System;
using System.Collections.Generic;
using System.Text;


// Directed graph representado con Adjacency List
public class WeightedDirectedGraph
{
    public class Vertex
    {
        public int id { get; private set; }
        public Vertex(int id)
        {
            this.id = id;
            this.adjacentEdges = new List<Edge>();
        }
        public List<Edge> adjacentEdges { get; private set; }
    }

    public class Edge
    {
        public int id { get; private set; }
        public Vertex u, v;
        public int weight { get; private set; }
        public Edge(int id, Vertex u, Vertex v, int weight)
        {
            this.id = id;
            this.u = u;
            this.v = v;
            this.weight = weight;
        }
    }

    private List<Vertex> vertices;
    private List<Edge> edges;

    public WeightedDirectedGraph(int numVertices)
    {
        vertices = new List<Vertex>();
        for (int i = 0; i < numVertices; i++)
            vertices.Add(new Vertex(i));
        edges = new List<Edge>();
    }


    public void AddEdge(int u, int v, int weight)
    {
        Vertex uu = vertices[u];
        Vertex vv = vertices[v];

        Edge e = new Edge(edges.Count, uu, vv, weight);
        edges.Add(e);

        uu.adjacentEdges.Add(e);
    }

    // Definicion de un path
    // NOTA: Esta definicion no concuerda exactamente con la definicion teorica
    //       de Walk dada en clase: v1 e1 v2 e2 ... ek-1 ... vk, porque esa
    //       definicion es dificil de representar en una estructura de datos
    //       por la alternacion de vertices y ejes en la secuencia
    public class Path
    {
        public Vertex start;      // vertice donde empieza el path
        public List<Edge> edges;  // secuencia de edges en el path
        public Vertex end;        // vertice donde termina el path
        public long weight;       // suma de los weights de los edges en el path
    }

    // Devuelve el shortest path desde el vertice con id 'src' hasta el vertice
    // con id 'dest'
    // NOTA: Tu algoritmo debe devolver un objeto tipo Path definido arriba
    public Path SPFA(int src, int dest)
    {

        // TODO: Implementa el algoritmo de Shortest Path Faster Algorithm
        //       descrito en Wikipedia:
        //       https://en.wikipedia.org/wiki/Shortest_Path_Faster_Algorithm
        // Valor: 5 puntos
        // Complejidad esperada: la indicada en Wikipedia
        

        // AQui Variables
        long[] D = new long[vertices.Count]; // Distancia
        bool[] Vista = new bool[vertices.Count]; // Para buscar el path 
        Edge[] P = new Edge[vertices.Count];
        Queue<Vertex> Q = new Queue<Vertex>();
        List<Edge> lista = new List<Edge>();
        // Para llenar la lista al final se necesita un arreglo

        for (int z = 0; z < vertices.Count; z++)
        {
            D[z] = int.MaxValue / 2;
            Vista[z] = false;
            P[vertices[z].id] = null;
        } 

        D[src] = 0; // Cero
        Q.Enqueue(vertices[src]);

        while (Q.Count != 0)
        {
            Vertex u = Q.Dequeue();

            foreach (Edge e in u.adjacentEdges)
            {
                if (D[u.id] + e.weight < D[e.v.id])
                {
                    D[e.v.id] = D[u.id] + e.weight;

                    if (!Q.Contains(e.v))
                        Q.Enqueue(e.v);

                    P[e.v.id] = e;
                }
            }
        }


        Path result = new Path();
        result.start = vertices[src];
        result.end = vertices[dest];
        result.weight = D[dest];
      
        // SACAR EL PATH
        Edge paso = P[dest];

        if (paso == null)
            return null;

        while(paso != null)
        {
            int y = paso.u.id;

            if (!Vista[y])
            {
                lista.Add(paso);
                Vista[y] = true;
            }
            paso = P[y];
        }

        lista.Reverse();
        result.edges = lista;
 
        return result;
    }
}



public class Lab4f
{
    public static void Main(string[] args)
    {
        var G = new WeightedDirectedGraph(8);
        G.AddEdge(4, 5, 5);
        G.AddEdge(5, 4, 3);
        G.AddEdge(4, 7, 7);
        G.AddEdge(0, 7, 12);
        G.AddEdge(5, 7, 1);
        G.AddEdge(5, 1, 4);
        G.AddEdge(0, 4, 3);
        G.AddEdge(0, 2, 6);
        G.AddEdge(7, 3, 5);
        G.AddEdge(1, 3, 2);
        G.AddEdge(2, 7, 4);
        G.AddEdge(3, 6, 5);
        G.AddEdge(7, 1, 8);
        G.AddEdge(2, 3, 9);

        int src = 0, dest = 6;
        var path = G.SPFA(src, dest);
        if (path == null)
        {
            Console.WriteLine("There is no path from vertext {0} to vertex {1}",
                              src, dest);
        }
        else
        {
            Console.WriteLine("Shortest Path weight sum: {0}", path.weight);
            Console.WriteLine("Shortest Path:");
            Console.WriteLine("Start vertex: {0}", path.start.id);
            foreach (var e in path.edges)
            {
                Console.WriteLine("Edge id: {0,2}   {1} -> {2}   weight:{3}",
                                  e.id, e.u.id, e.v.id, e.weight);
            }
            Console.WriteLine("End vertex: {0}", path.end.id);
        }

        Console.ReadKey();
    }
}

/*
Mi output:

Shortest Path weight sum: 19
Shortest Path:
Start vertex: 0
Edge id:  6   0 -> 4   weight:3
Edge id:  0   4 -> 5   weight:5
Edge id:  4   5 -> 7   weight:1
Edge id:  8   7 -> 3   weight:5
Edge id: 11   3 -> 6   weight:5
End vertex: 6

*/
