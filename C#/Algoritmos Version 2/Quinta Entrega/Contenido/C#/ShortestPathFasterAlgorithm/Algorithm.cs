using System.Collections.Generic;

namespace ShortestPathFasterAlgorithm
{
    class Algorithm
    {
        // algorithm by Xin Zhou
        // http://airccse.org/journal/ijmit/papers/6114ijmit02.pdf

        public List<Vertex> SPFA(
            List<Vertex> V,
            Vertex s,
            out int[] d)
        {
            d = new int[V.Count];

            List<Vertex> path = new List<Vertex>();
            Queue<Vertex> Q = new Queue<Vertex>();

            for (int i = 0; i < V.Count; i++)
                d[i] = int.MaxValue;

            d[s.Id] = 0;
            Q.Enqueue(s);
            
            while (Q.Count != 0)
            {
                Vertex u = Q.Dequeue();

                foreach (Edge e in u.Edges)
                {
                    if (e.Lt == u)
                    {
                        if (d[e.Lt.Id] + e.Wt < d[e.Rt.Id])
                        {
                            d[e.Rt.Id] = d[e.Lt.Id] + e.Wt;

                            if (!Q.Contains(e.Rt))
                                Q.Enqueue(e.Rt);

                            if (!path.Contains(u))
                                path.Add(u);

                            if (!path.Contains(e.Rt))
                                path.Add(e.Rt);
                        }
                    }

                    else if (e.Rt == u)
                    {
                        if (d[e.Rt.Id] + e.Wt < d[e.Lt.Id])
                        {
                            d[e.Lt.Id] = d[e.Rt.Id] + e.Wt;

                            if (!Q.Contains(e.Lt))
                                Q.Enqueue(e.Lt);

                            if (!path.Contains(u))
                                path.Add(u);

                            if (!path.Contains(e.Lt))
                                path.Add(e.Lt);
                        }
                    }
                }
            }

            for (int i = 0; i < d.Length; i++)
                if (d[i] == int.MaxValue)
                    return null;

            return path;
        }
    }
}