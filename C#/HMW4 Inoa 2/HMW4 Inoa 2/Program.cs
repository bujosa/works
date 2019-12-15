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

    // Para ordenar de manera Descedente
    public class compare : IComparer<Edge>
    {
        public int Compare(Edge u, Edge v)
        {
            int x = 0;
            if (u.weight == v.weight)
                x = u.id.CompareTo(v.id);
            else
                x = u.weight.CompareTo(v.weight);

            if (x == 1)
                x = -1;
            else if (x == 0)
                x = 0;
            else
                x = 1;
               
            return x;
        }
    }

    enum VERTEX_STATE
    {
        UNVISITED, PROCESSING, VISITED
    }

    VERTEX_STATE[] state;
    int source = 0;
    List<Vertex> currentComponent;
    List<Edge> ejes = new List<Edge>();

    // Devuelve (un) Longest Simple Path del grafo que empieza desde nodo con
    // id 'src'
    public Path LongestSimplePath(int src)
    {
        // TODO: implementa el algoritmo del profesor Halfwit descrito arriba
        // Valor: 6 puntos
        // Complejidad esperada: O(V*log(E) + E)
        // Restriccion: tu DFS debe ser recursivo

        // PRIMER PASO : La idea es explorar primero el edge mas "profundo" / lejos.
        this.source = src;
        state = new VERTEX_STATE[vertices.Count];
        currentComponent = new List<Vertex>();
        Path result = new Path();

        // Para ordenar de mayor weight a menor weight
        for (int i = 0; i < vertices.Count; i++)
            vertices[i].adjacentEdges.Sort(new compare());
     
        dfs(src); // Con respecto al source buscar dfs
        currentComponent.Reverse(); // Con esto invertimos el orden
        var profundo = currentComponent[0]; // primero en la lista es el nodo mas profundo
        result.start = vertices[src];
        result.end = profundo;
        // Ahora partiendo desde el nodo mas profundo encontrar el Path mas largo o con mayor weitgh;
        int weights = 0;
        currentComponent = new List<Vertex>();
        state = new VERTEX_STATE[vertices.Count];
        ejes = new List<Edge>();
        bloked = true;
        dfs(profundo.id);
        ejes.Reverse();
        result.edges = ejes;

        foreach (Edge e in ejes)
            weights += e.weight;

        result.weight = weights;

        // Esta parte comentada es para buscar con respecto a otros vertices pero estamos buscando desde
        // el source el cual es el que nos mandan por parametro

        /*
        for (int u = 0; u < vertices.Count; u++)
        {
            if (state[u] == VERTEX_STATE.UNVISITED)
            {
                currentComponent = new List<Vertex>();
                dfs(u);
            }

        }*/
        
        // Ya con el nodo mas profundo se obtiene el camino mas largo pero ahora hay que saber su path y weight;
           
        return result;
    }

    // Cuando retorne tendremos el nodo mas profundo
    bool bloked = true;
    void dfs(int u)
    {
        if (u == source)
            bloked = false;

        state[u] = VERTEX_STATE.PROCESSING;
        currentComponent.Add(vertices[u]);
        
        foreach (Edge e in vertices[u].adjacentEdges)
        {
            int v = e.OppositeVertexId(u);
            if (state[v] == VERTEX_STATE.UNVISITED)
            {
                if (bloked)
                    ejes.Add(e);
                dfs(v);
            }
        }
        state[u] = VERTEX_STATE.VISITED;
    }

}


public class HW4d
{
    public static void Main(string[] args)
    {
        var G = new WeightedUndirectedGraph(8);
        // TODO: provee un contraejemplo que demuestre que el algoritmo del
        //       profesor Halfwit no funciona
        // Valor: 1 punto
        
        // Para este caso si funciona
        G.AddEdge(2, 1, 3);
        G.AddEdge(1, 3, 5);
        G.AddEdge(3, 0, 2);
        G.AddEdge(0, 5, 7);
        G.AddEdge(0, 4, 4);
        G.AddEdge(4, 3, 3);
        //

        // Ejemplo donde no funciona el del profesor Halfwit

        /*
        G.AddEdge(0, 1, 55);
        G.AddEdge(1, 5, 44);
        G.AddEdge(0, 2, 14);
        G.AddEdge(2, 3, 11);
        G.AddEdge(3, 4, 44);
        G.AddEdge(0, 7, 28);
        G.AddEdge(5, 7, 12);
        G.AddEdge(7, 6, 7);
        */
        // Resultado deberia ser 0 1, 1 5, 5 7, 7 6 weight = 108  
        //  El algoritmo busca el mas profundo no necesariamente el mas grande en weight el cual es el que debe de coger
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
