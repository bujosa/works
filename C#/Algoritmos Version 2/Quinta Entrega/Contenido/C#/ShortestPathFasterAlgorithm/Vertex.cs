using System;
using System.Collections.Generic;

namespace ShortestPathFasterAlgorithm
{
    class Vertex : IComparable
    {
        public int Id { get; set; }
        public List<Edge> Edges { get; set; }
        public Vertex(int id)
        {
            Id = id;
        }

        public Vertex(int id, List<Edge> edges)
        {
            Id = id;
            Edges = edges;
        }

        public int CompareTo(object obj)
        {
            Vertex other = (Vertex)obj;

            return Id - other.Id;
        }
    }
}
