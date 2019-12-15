/*
 * Puntos ejercicio: 7 puntos
 * 
 * El profesor Halfwit cree haber descubierto un algoritmo para encontrar el
 * longest simple path en un weighted undirected graph.  El longest simple path
 * es el path mas largo (con mayor suma de weights de los edges) donde no se
 * repiten vertices (ver https://en.wikipedia.org/wiki/Longest_path_problem).
 *
 * El algoritmo es una simple variante de Depth First Search (DFS).  Por que
 * el profesor eligio DFS?  El profesor piensa que DFS tiene las siguientes
 * propiedades especiales que se adaptan bien a este problema:
 * 
 *   1) DFS solo visita los nodos una sola vez, por lo tanto, no los repite
 *   2) Su nombre indica que explora los nodos por su "profundidad" con respecto al source
 * 
 * La variante de DFS del profesor explora los edges vecinos de un nodo en orden
 * descendente de sus weights (o sea, del edge con mayor peso hasta el de menor
 * peso).  La idea es explorar primero el edge mas "profundo" / lejos.
 *
 * Implementa el algoritmo del profesor y provee un contraejemplo que demuestre
 * que no funciona.
 *
 * Ubica todas las secciones con el tag TODO.  Cada tag les indicara que deben
 * completar.  Para TODOs que requieren respuestas, escribe las respuestas en
 * un comment.
 *
 * Puedes agregar todos los atributos y metodos que necesites.
 * 
 */

using System;
using System.Collections.Generic;


// Weighted undirected graph representado con Adjacency List
public class WeightedUndirectedGraph
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
        public int OppositeVertexId(int x)
        {
            if (x == u.id) return v.id;
            else return u.id;
        }
    }

    public class CompareTo : IComparer<Edge>
    {
        public int Compare(Edge me, Edge other)
        {
            int y = 0;

                y = me.weight.CompareTo(other.weight);
          
            return y*-1;
        }
    }

    public List<Vertex> vertices { get; private set; }

    public List<Edge> edges { get; private set; }

    public WeightedUndirectedGraph(int numVertices)
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
        vv.adjacentEdges.Add(e);
    }


    // Definicion de un path
    // NOTE: Esta definicion no concuerda exactamente con la definicion teorica
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

  
    int[] estado;

    List<Vertex> visited;
   

    // Devuelve (un) Longest Simple Path del grafo que empieza desde nodo con
    // id 'src'
    public Path LongestSimplePath(int src)
    {
        // TODO: implementa el algoritmo del profesor Halfwit descrito arriba
        // Valor: 6 puntos
        // Complejidad esperada: O(V*log(E) + E)
        // Restriccion: tu DFS debe ser recursivo

        // EL algoritmo source de wikipedia dice que es NP version x dependiendo de lo que se pida
        // entonces ya por ende uno se va dando cuenta que el algoritmo del profesor Halfwit esta mal

        estado = new int[vertices.Count];

        visited = new List<Vertex>();

        // Descrito en el algoritmo sobre ordenar weight de mayor a menor
        for (int i = 0; i < vertices.Count; i++)
        {
            vertices[i].adjacentEdges.Sort(new CompareTo());
        }
     
        dfs(src); // Dfs desde el source 

        visited.Reverse();

        var x = vertices[src]; // solo para coger un valor temporal

        foreach (Vertex a in visited)
        {
            x = a;
            break;
        }

        Path mysol = new Path();

        mysol.start = vertices[src];
        mysol.end = x;
      
        visited = new List<Vertex>();

        estado = new int[vertices.Count];

        paths = new List<Edge>(); // Si no fijamos al dfs retornar entrara a lugares 
        // donde ya no se puede pasar al menos que repita el nodo por eso 
        // ya uno se puede guiar que fallara el algoritmo

        dfs(mysol.end.id);

        paths.Reverse();

        mysol.edges = paths;

        foreach (Edge e in paths)
            mysol.weight += e.weight;
              
        return mysol;
    }

    List<Edge> paths = new List<Edge>();

    // DFS con recursivida
    void dfs(int u)
    {
        estado[u] = 2;
        visited.Add(vertices[u]);
        
        foreach (Edge e in vertices[u].adjacentEdges)
        {
            int v = e.OppositeVertexId(u);
            if (estado[v] == 0)
            {
                paths.Add(e);
                dfs(v);
            }
        }
        estado[u] = 1;
    }

}


public class HW4d
{
    public static void Main(string[] args)
    {
        var G = new WeightedUndirectedGraph(6);
        // TODO: provee un contraejemplo que demuestre que el algoritmo del
        //       profesor Halfwit no funciona
        // Valor: 1 punto


        // Ejemplo donde no funciona el del profesor Halfwit

        /* //G = 6 
        G.AddEdge(0, 1, 5);
        G.AddEdge(0, 2, 5);
        G.AddEdge(1, 3, 12);
        G.AddEdge(3, 4, 19);
        G.AddEdge(0, 3, 8);
        G.AddEdge(0, 4, 5);
        G.AddEdge(0, 5, 2);
        G.AddEdge(2, 5, 81);
        */
        // La solucion deberia de ser E 0 2. E 2 5 el cual es el mayor En relacion con weight
       

        var path = G.LongestSimplePath(0);
        if (path == null)
        {
            Console.WriteLine("WTF");
        }
        else
        {
            Console.WriteLine("Longest Simple Path weight sum: {0}", path.weight);
            Console.WriteLine("Longest Path:");
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
