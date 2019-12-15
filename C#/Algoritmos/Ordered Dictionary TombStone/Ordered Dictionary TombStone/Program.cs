using System;
using System.Collections;
using System.Collections.Generic;

namespace Ordered_Dictionary_TombStone
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
                public bool TombStone;

                public Treenode(K Llave, V valor)
                {
                    this.value = valor;
                    this.Key = Llave;
                }

            }

            public int Size { get; private set; }
          
            private Treenode root;

            // Funcion TombStone Ready
            int SubTreeSize(Treenode x)
            {
                if (x == null )
                    return 0;
                else
                    return x.SubTreeSize;

            }

            // Funcion TombStone Ready
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
                while (cur != null)
                {
                    if (key.CompareTo(cur.Key) == 0)
                    {
                        if (cur.TombStone == false)
                          {
                            throw new DuplicateKey();
                        }
                        else
                        {
                            cur.value = value;
                            cur.TombStone = false;
                            Size++;

                            while(cur != null)
                            {
                                cur.SubTreeSize++;
                                cur = cur.Parent;
                            }

                            return;
                        }
                    }
                        

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
                    if (newnode.Parent != null)
                        newnode.Parent.SubTreeSize++;

                    newnode = newnode.Parent;
                }
            }

            // Funcion TombStone Ready
            public V Remove(K key)
            {
                Treenode x = FindNode(key);
                if (x == null || x.TombStone == true)
                    throw new KeyNotFoundException();
                V ret = RemoveNode(x);
                Size--;
                return ret;
            }

            // Funcion TombStone Ready
            private V RemoveNode(Treenode x)
            {

                V ret = x.value;
                x.TombStone = true;
                
            
                    while (x != null)
                    {
                        x.SubTreeSize--;
                        x = x.Parent;
                    }
              
                return ret;
            }

            // Funcion Tombstone Ready;
            public K Max()
            {
                Treenode x = MaxNode(root);
                if (x == null || x.TombStone == true)
                    throw new KeyNotFound();
                return x.Key;
            }

            // Funcion Tombstone Ready
            private Treenode MaxNode(Treenode cur)
            {
                Treenode best = cur;
                if (cur == null)
                    return null;
                while (cur != null)
                { 
                    if (cur.Right != null)
                    {
                        cur = cur.Right;
                    }
                    if (cur.TombStone != true)
                    {
                        best = cur;
                    }
                    if (cur.Right == null)
                    {
                        if (cur.TombStone == true && cur.SubTreeSize > 0)
                        {
                            cur = cur.Left;
                            if (cur.TombStone != true)
                            {
                                best = cur;
                            }
                        }
                    }
                    else
                    {
                        if (cur.TombStone == true && cur.SubTreeSize > 0 && cur.Right.SubTreeSize == 0 && cur.Right.TombStone == true)
                        {
                            cur = cur.Left;
                            if (cur.TombStone == false)
                            {
                                best = cur;
                            }
                        }
                    }
                    if(cur.Right == null)
                    {
                        break;
                    }
                }
                  
                return best;

            }

            // Funcion Tombstone Ready
            public K Min()
            {
                Treenode x = MinNode(root);
                if (x == null || x.TombStone == true)
                    throw new KeyNotFoundException();
                return x.Key;   
            }

            // Funcion Tombstone Ready
            private Treenode MinNode(Treenode cur)
            {
                Treenode best = cur;
         
                if (cur == null )
                    return null;

                while (cur != null)
                {
                   
                    if(cur.Left != null)
                    {
                        cur = cur.Left;
                    }

                    if (cur.TombStone != true)
                    {
                        best = cur;
                    }

                    if (cur.Left == null)
                    {
                        if (cur.TombStone == true && cur.SubTreeSize > 0)
                        {
                            cur = cur.Right;
                            if (cur.TombStone != true)
                            {
                                best = cur;            
                            }
                        }
                    }
                    else
                    {
                        if (cur.TombStone == true && cur.SubTreeSize > 0 && cur.Left.SubTreeSize == 0 && cur.Left.TombStone == true)
                        {
                            cur = cur.Right;
                            if (cur.TombStone != true)
                            {
                                best = cur;
                                
                            }
                        }
                    }
                    if(cur.Left == null)
                    {
                        break;
                    }
                  
                }
                return best;
            }

            // Funcion Tomsbtone Ready
            public V Find(K key)
            {
                Treenode x = FindNode(key);
                if (x == null || x.TombStone == true)
                    throw new KeyNotFoundException();
                return x.value;
            }

            // Funcion Tombstone Ready
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

            // Funcion Tombstone Ready
            public K Successor(K key)
            {
                Treenode cur = root, best = null;

                while (cur != null)
                {
                    if (key.CompareTo(cur.Key) == 0)
                        cur = cur.Right;
                     
                    
                    else if (key.CompareTo(cur.Key) < 0)
                    {
                        if (best == null || best.Key.CompareTo(cur.Key) > 0 && cur.TombStone != true)
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

            // Funcion Tombstone Ready
            public K Predeccessor(K key)
            {
                Treenode cur = root, best = null;
                while (cur != null)
                {
                    if (key.CompareTo(cur.Key) == 0)
                        cur = cur.Left;
                   
                    else if (key.CompareTo(cur.Key) > 0)
                    {
                        if (best == null || best.Key.CompareTo(cur.Key) < 0 && cur.TombStone != true)
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

            // Funcion Tombstone Ready
            public int Rank(K key)
            {
                int contador = 0;
                Treenode cur = root;

                while (cur != null)
                {
                    if (key.CompareTo(cur.Key) > 0)
                    {
                        contador += 1 + SubTreeSize(cur.Left);
                        cur = cur.Right;
                    }
                    else if (key.CompareTo(cur.Key) < 0)
                    {
                        cur = cur.Left;
                    }
                    else
                    {
                        contador += SubTreeSize(cur.Left);
                        break;
                    }
                }

                return contador;
            }

            // Funcion Tombstone Ready
            public K select(int pos)
            {
                if (pos < 0 || pos >= Size)
                    throw new InvalidPosition();

                int contador = pos;

                Treenode cur = root;

                while (cur != null)
                {
                    if (contador > SubTreeSize(cur.Left))
                    {
                        contador -= 1 + SubTreeSize(cur.Left);
                        cur = cur.Right;
                    }
                    else if (contador < SubTreeSize(cur.Left))
                        cur = cur.Left;
                    else if (contador == SubTreeSize(cur.Left))
                    {
                        contador -= SubTreeSize(cur.Left);
                        return cur.Key;
                    }
                    else if (contador < 0)
                        throw new InvalidPosition();
                }

                return cur.Key;

            }

            //Funcion Tombstone Ready
            public int Depth(K key)
            {
                int depth = 0;

                Find(key);

                Treenode cur = root;

                while (cur != null)
                {
                    if (key.CompareTo(cur.Key) == 0)
                        break;

                    else if (key.CompareTo(cur.Key) < 0)
                        cur = cur.Left;
                    else
                        cur = cur.Right;

                    if (cur != null && cur.TombStone!= true)
                        depth++;
                }

                return depth;
            }

            // Funcion Tombstone Ready
            public int Height(K key)
            {
                Treenode cur = FindNode(key);
                if (cur == null || cur.TombStone == true)
                    throw new KeyNotFound();
                int contador = BestHeight(cur);

                return contador;
            }

            // Funcion Tombstone Ready
            private int BestHeight(Treenode cur)
            {
                int best1 = 0, best2 = 0;

                Treenode Izquierdo = cur.Left, Derecho = cur.Right;

                while (cur != null)
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

            // Funcion Tombstone Ready
            public K[] inOrderIteraction()
            {
                List<K> L = new List<K>();

                R(L, root);

                return L.ToArray();

            }

            // Funcion Tombstone ready
            void R(List<K> L, Treenode cur)
            {
                if (cur == null)
                    return;
                R(L, cur.Left);
                if(cur.TombStone == false)
                  L.Add(cur.Key);
                R(L, cur.Right);
            }

        }

        static void Main(string[] args)
        {
            OrderedDictionary<int, int> d = new OrderedDictionary<int, int>();
            d.add(20, 0);
            d.add(10, 0);
            d.add(5, 0);
            d.add(50, 0);
            d.add(30, 0);
            d.add(40, 0);
            d.add(32, 0);
            d.add(35, 0);
            d.add(80, 0);
            d.add(70, 0);
            d.add(60, 0);
            d.add(90, 0);
            d.add(11, 0);
            d.add(9, 0);
            d.add(7, 0);
            d.add(75, 0);
            d.add(74, 0);
            d.Remove(5);
            d.Remove(10);
            d.Remove(80);
            d.Remove(90);
            d.Remove(75);
            Console.WriteLine(d.Max());
            Console.WriteLine(d.Min());
            /*
            leaf.add(50, "Cincuenta");
            leaf.add(25, "Vente y Cinco");
            leaf.add(35, "Trenta y cinco");
            leaf.add(75, "Setenta y cinco");
            leaf.add(90, "Noventa");
            leaf.add(76, "Setenta y Nueve");
            leaf.add(80, "Ochenta");
            leaf.add(12, "Doce");
            leaf.add(20, "Vente");
            leaf.add(40, "Cuarenta");
            leaf.add(45, "Cuarenta y cinco");
            leaf.add(10, "Dies");
            leaf.add(5, "Cinco");
            leaf.add(7, "Siete");
            leaf.add(11, "Once");
            leaf.add(39, "Trenta y Nueve");
            leaf.add(44, "Cuarenta y Cuatro");
            leaf.add(46, "Cuarenta y Seis");
            leaf.add(47, "Cuarenta y Siete");
            Console.WriteLine(leaf.Height(50));
            Console.WriteLine(leaf.Height(25));
            Console.WriteLine(leaf.Depth(45));
            // Console.WriteLine(leaf.Remove(25));
            Console.WriteLine(leaf.Predeccessor(35));
            Console.WriteLine(leaf.Successor(35));
            Console.WriteLine(leaf.Rank(50));
            Console.WriteLine(leaf.Rank(100));
            Console.WriteLine(leaf.Remove(25));
            Console.WriteLine(leaf.Rank(50));
            leaf.add(25, "Revivido Again");
            Console.WriteLine(leaf.Rank(50));
            leaf.Remove(90);
            Console.WriteLine( leaf.Max());
            leaf.Remove(5);
            Console.WriteLine(leaf.Min());
            Console.WriteLine();

            for (int i = 0; i < leaf.Size ; i++)
            {
                Console.Write(leaf.inOrderIteraction()[i] + " ") ;
            }
            */
            Console.ReadKey();
        
        }
    }
}
