using System;
using System.Collections.Generic;

namespace ShortestPathFasterAlgorithm
{
    class Edge : IComparable
    {
        public Vertex Lt { get; set; }
        public Vertex Rt { get; set; }
        public int Wt { get; set; }
        public Edge(Vertex lt, Vertex rt, int wt)
        {
            Lt = lt;
            Rt = rt;
            Wt = wt;
        }

        public int CompareTo(object obj)
        {
            Edge other = (Edge)obj;
            int c1 = Lt.CompareTo(other.Lt);
            int c2 = Rt.CompareTo(other.Rt);

            if (c1 != 0)
                return c1;

            if (c2 != 0)
                return c2;

            return Wt - other.Wt;
        }

        public bool InList(List<Edge> elist)
        {
            for (int i = 0; i < elist.Count; i++)
            {
                Edge e = elist[i];

                if (Lt == e.Lt && Rt == e.Rt)
                    return true;
            }

            return false;
        }
    }
}