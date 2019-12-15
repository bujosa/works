using System;
using System.Collections;
using System.Collections.Generic;

namespace Ordered_Dictionary
{
    public class KeyNotFound : Exception { }
    public class DuplicateKey : Exception { }
    public class InvalidPosition : Exception { }


    class Programa
    {
        public class OrderedDictionary<K, V> where K : IComparable<K>
        {
            class Treenode
            {
                public Treenode Left, Right, Parent;
                public V value;
                public K Key;
                public int SubTreeSize;

                public Treenode(K Llave, V valor)
                {
                    this.value = valor;
                    this.Key = Llave;
                }

            }

            public int Size { get; private set; }

            private Treenode root;

            public int SubTreeSize(K key)
            {
                Treenode cur = FindNode(key);

                if (cur == null)
                    throw new KeyNotFound();

                return SubTreeSizeNode(cur);
            }

            private int SubTreeSizeNode(Treenode x)
            {
                if (x == null)
                    return 0;
                else
                    return x.SubTreeSize;

            }

            public void add(K key, V value)
            {
                if (Size == 0)
                {
                    root = new Treenode(key, value);
                    root.SubTreeSize++;
                    Size = 1;
                    return;
                }
                Treenode cur = root, prev = null;
                while(cur != null)
                {
                    if (key.CompareTo(cur.Key) == 0)
                        throw new DuplicateKey();
               
                    prev = cur;

                    if (key.CompareTo(cur.Key) < 0)
                        cur = cur.Left;
                    else
                        cur = cur.Right;
                }
                Treenode newnode = new Treenode(key, value);
                newnode.Parent = prev;
                newnode.SubTreeSize++;
                if (key.CompareTo(prev.Key) < 0)
                    prev.Left = newnode;
                else
                    prev.Right = newnode;

                Size++;

                while (newnode != null)
                {
                    if(newnode.Parent != null)
                         newnode.Parent.SubTreeSize++;

                    newnode = newnode.Parent;
                }
            }

            public V Remove(K key)
            {
                Treenode x = FindNode(key);
                if (x == null)
                    throw new KeyNotFoundException();
                V ret = RemoveNode(x);
                Size--;
                return ret;
            }

            private V RemoveNode(Treenode x)
            {

                bool removed = true;
                V ret = x.value;

                Treenode p = x.Parent;
                Treenode newnode = x.Parent;

              
                if (x.Left == null && x.Right == null)
                {
                    // no tiene hijos

                    if (p == null)
                    {
                        // x == root
                        root = null;
                        
                        return ret;
                    }

                    //  if (x.key < p.key)
                    if (x == p.Left)
                        p.Left = null;
                    else
                        p.Right = null;
                }

                else if (x.Left != null && x.Right == null)
                {
                    // tiene 1 hijo (izquierdo)
                    Treenode y = x.Left;

                    if (p == null)
                    {
                        // x == root
                        root = y;
                    }
                    else if (x == p.Left)
                    {
                        p.Left = y;
                    }
                    else
                    {
                        p.Right = y;
                    }
                    y.Parent = p;

                }
                else if (x.Left == null && x.Right != null)
                {
                    // tiene 1 hijo (derecho)
                    Treenode y = x.Right;
                    if (p == null)
                    {
                        // x == root
                        root = y;
                    }
                    else if (x == p.Left)
                    {
                        p.Left = y;
                    }
                    else
                    {
                        p.Right = y;
                    }
                    y.Parent = p;

                }
                else
                {
                    // tiene 2 hijos
                    Treenode s = MinNode(x.Right);
                    x.Key = s.Key;
                    x.value = s.value;
                    RemoveNode(s);
                    removed = false;
                    
                }


                if (removed != false)
                {
                    while (newnode != null)
                    {
                        if (newnode.Parent == null)
                            break;
                        newnode.SubTreeSize--;
                        newnode = newnode.Parent;
                    }
                    Size--;
                }
               

                return ret;
            }

            public K Max()
            {
                Treenode x = MaxNode(root);
                if (x == null)
                    throw new KeyNotFound();
                return x.Key;
            }

            private Treenode MaxNode (Treenode cur)
            {
                if (cur == null)
                    return null;
                while(cur.Right != null)
                    cur = cur.Right;
                return cur;
                
            }

            public K Min()
            {
                Treenode x = MinNode(root);
                if (x == null)
                    throw new KeyNotFoundException();
                return x.Key;
            }

            private Treenode MinNode(Treenode cur)
            {
                if (cur == null)
                    return null;
                while (cur.Left != null)
                    cur = cur.Left;
                return cur;
            }
    
            public V Find(K key)
            {
                Treenode x = FindNode(key);
                if (x == null)
                    throw new KeyNotFoundException();
                return x.value;
            }

            private Treenode FindNode(K key)
            {
                Treenode cur = root;
                while (cur != null)
                {
                    if (key.CompareTo(cur.Key) == 0)
                        return cur;
                    else if (key.CompareTo(cur.Key) < 0)
                        cur = cur.Left;
                    else
                        cur = cur.Right;
                }
                return null;
            }

            public K Successor(K key)
            {
                Treenode cur = root, best = null;
                while (cur != null)
                {
                    if (key.CompareTo(cur.Key) == 0)
                        cur = cur.Right;

                    else if (key.CompareTo(cur.Key) < 0)
                    {
                        if (best == null || best.Key.CompareTo(cur.Key) > 0)
                            best = cur;
                        cur = cur.Left;
                    }
                    else
                        cur = cur.Right;
                }
                if (best == null)  // no hay sucesor
                    throw new KeyNotFoundException();
                return best.Key;
            }

            public K Predeccessor(K key)
            {
                Treenode cur = root, best = null;
                while (cur != null)
                {
                    if (key.CompareTo(cur.Key) == 0)
                        cur = cur.Left;

                    else if (key.CompareTo(cur.Key) > 0)
                    {
                        if (best == null || best.Key.CompareTo(cur.Key) < 0)
                            best = cur;
                        cur = cur.Right;
                    }
                    else
                        cur = cur.Left;
                }
                if (best == null)  // no hay sucesor
                    throw new KeyNotFoundException();
                return best.Key;
            }

            public int Rank(K key)
            {
                int contador = 0;
                Treenode cur = root;

                while(cur != null)
                {
                    if (key.CompareTo(cur.Key) > 0)
                    {
                        contador += 1 + SubTreeSizeNode(cur.Left);
                        cur = cur.Right;
                    }
                    else if (key.CompareTo(cur.Key) < 0)
                    {
                        cur = cur.Left;
                    }
                    else
                    {
                        contador += SubTreeSizeNode(cur.Left);
                        break;
                    }
                }

                return contador;
            }

            public K select(int pos)
            {
                if (pos < 0 || pos >= Size)
                    throw new InvalidPosition();

                int contador = pos;

                Treenode cur = root;

                while(cur != null)
                {
                    if (contador > SubTreeSizeNode(cur.Left))
                    {
                        contador -= 1 + SubTreeSizeNode(cur.Left);
                        cur = cur.Right;
                    }
                    else if (contador < SubTreeSizeNode(cur.Left))
                        cur = cur.Left;
                    else if (contador == SubTreeSizeNode(cur.Left))
                    {
                        contador -= SubTreeSizeNode(cur.Left);
                        return cur.Key;
                    }
                    else if (contador < 0)
                        throw new InvalidPosition();
                }

                return cur.Key;

            }

            public int Depth(K key)
            {
                int depth = 0;

                Treenode cur = root;

                while (cur != null)
                {
                    if (key.CompareTo(cur.Key) == 0)
                        break;

                    else if (key.CompareTo(cur.Key) < 0)
                        cur = cur.Left;
                    else
                        cur = cur.Right;

                    if (cur != null)
                        depth++;
                }
               
                return depth;
            }

            public int Height(K key)
            {
                Treenode cur = FindNode(key);
                if (cur == null)
                    throw new KeyNotFound();
                int contador = BestHeight(cur);

                return contador;
            }

            private int BestHeight(Treenode cur)
            {
                int best1 = 0, best2 = 0;

                Treenode Izquierdo = cur.Left, Derecho = cur.Right;
                
                while(cur != null)
                {

                    if (Izquierdo != null)
                    {
                        best1 = 1 + BestHeight(Izquierdo);
                        Izquierdo = Izquierdo.Left;
                    }

                    if (Derecho != null)
                    {
                        best2 = 1 + BestHeight(Derecho);
                        Derecho = Derecho.Right;
                    }
                    
                    break;
                   
                }
                if (best2 >= best1)
                    return best2;
                else
                return best1; 
            }

            public K[] inOrderIteraction()
            {
                List<K> L = new List<K>();

                R(L, root);

                return L.ToArray();
                
            }
            
            void R(List<K> L, Treenode cur)
            {
                if (cur == null)
                    return;
                R(L, cur.Left);
                L.Add(cur.Key);
                R(L, cur.Right);

            }

        }

        static void Main(string[] args)
        {
            OrderedDictionary<int, string> leaf = new OrderedDictionary<int, string>();
            leaf.add(50, "Cincuenta");
            leaf.add(25, "Cuanrenta y nueve");
            leaf.add(35, "Trenta y cinco");
            leaf.add(75, "Setenta y cinco");
            leaf.add(80, "Ochenta");
            leaf.add(12, "Doce");
            leaf.add(20, "Venta");
            leaf.add(40, "Cuarenta");
            leaf.add(45, "Cuarenta y cinco");
            leaf.add(10, "Dies");
            leaf.add(5, "Cinco");
            leaf.add(7, "Siete");
            leaf.add(11, "Once");
            leaf.add(39, "Treta y Nueve");
            leaf.add(44, "Cuarenta y Cuatro");
            leaf.add(46, "Cuarenta y Seis");
            leaf.add(47, "Cuarenta y Siete");
            leaf.add(34, "Trenta y Cuatro");
            Console.WriteLine(leaf.Height(25));
            //Console.WriteLine(leaf.Depth(45));
            Console.WriteLine(leaf.Remove(25));
            Console.WriteLine(leaf.SubTreeSize(34));
            Console.WriteLine(leaf.Predeccessor(35));
            Console.WriteLine(leaf.Successor(35));
            
            Console.WriteLine(leaf.Rank(50));
            Console.WriteLine(leaf.Rank(100));

            for(int i = 0; i<leaf.Size; i++)
            {
                Console.Write(leaf.inOrderIteraction()[i] + " ");
            }

            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
