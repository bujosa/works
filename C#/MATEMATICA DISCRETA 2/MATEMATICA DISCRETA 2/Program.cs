using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BST_Rotation
{
    public class KeyNotFound : Exception { }
    public class DuplicateKey : Exception { }
    public class InvalidPosition : Exception { }
    public class InvalidRotation : Exception { }


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
                public int height;
                public int hbf;

                public Treenode(K Llave, V valor)
                {
                    this.value = valor;
                    this.Key = Llave;
                    this.SubTreeSize = 1;
                    this.height = 0;
                    this.hbf = 0;
                }

                override public string ToString()
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append('(');
                    sb.Append(Key);
                    if (Left != null || Right != null)
                    {
                        sb.Append('-');
                        sb.Append(Left == null ? "()" : Left.ToString());
                        sb.Append('-');
                        sb.Append(Right == null ? "()" : Right.ToString());
                    }
                    sb.Append(')');
                    return sb.ToString();
                }

            }

            public int Size { get; private set; }

            private Treenode root;

            public K dame()
            {
                K dato = root.Key;
                return dato;
            }

            private int hbf(Treenode cur)
            {

                if (cur == null)
                    return 0;
                else
                    return cur.hbf;
            }

            public int hbf(K key)
            {
                Treenode cur = FindNode(key);
                if (cur == null)
                    throw new KeyNotFound();

                return cur.hbf;
            }

            private void hbfPlus(Treenode cur)
            {
                while (cur != null)
                {
                    cur.hbf = Height(cur.Right) - Height(cur.Left);
                    cur = cur.Parent;
                }
            }

            private int HBF(Treenode cur)
            {

                int res = Height(cur.Right) - Height(cur.Left);

                return res;

            }

            private void RR(Treenode x)
            {
                if (x == null || x.Left == null)
                    throw new InvalidRotation();

                Treenode P = x.Left; // El nodo hijo izquierdo se guarda
                Treenode B = P.Right; // El hijo derecho se guarda
                Treenode par = x.Parent; // El padre se guarda

                if (B != null)
                    B.Parent = x;
                //Aqui se hacen los cambios.
                x.Left = B; 
                x.Parent = P;
                P.Right = x;
                P.Parent = par;
                //Se ajusta quien sera el nuevo padre
                if (par != null)
                {
                    if (x == par.Left)
                        par.Left = P;
                    else
                        par.Right = P;
                }
                else
                    root = P;

                // Funcion para sacar Altura de un Nodo retorna menos uno si no tiene 
                x.height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
                P.height = Math.Max(Height(P.Left), Height(P.Right)) + 1;
                x.hbf = HBF(x);
                P.hbf = HBF(P);
                x.SubTreeSize = SubTreeSizeNode(x.Left) + SubTreeSizeNode(x.Right) + 1;
                P.SubTreeSize = SubTreeSizeNode(P.Left) + SubTreeSizeNode(P.Right) + 1;

            }

            private void LR(Treenode x)
            {
                if (x == null || x.Right == null)
                    throw new InvalidRotation();

                Treenode Q = x.Right; // Hijo derecho guardado
                Treenode B = Q.Left; // Hijo izquierdo guardado
                Treenode par = x.Parent; // Padre de los hijos guardados.

                x.Right = B;
                if (B != null)
                    B.Parent = x;
                //Aqui se hacen los cambios.
                Q.Left = x;
                x.Parent = Q;
                Q.Parent = par;
                //Se ajusta quien sera el nuevo padre
                if (par != null)
                {
                    if (x == par.Left)
                        par.Left = Q;
                    else
                        par.Right = Q;
                }
                else
                    root = Q;
                // Funcion para sacar Altura de un Nodo retorna menos uno si no tiene
                x.height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
                Q.height = Math.Max(Height(Q.Left), Height(Q.Right)) + 1;
                x.hbf = HBF(x);
                Q.hbf = HBF(Q);
                x.SubTreeSize = SubTreeSizeNode(x.Left) + SubTreeSizeNode(x.Right) + 1;
                Q.SubTreeSize = SubTreeSizeNode(Q.Left) + SubTreeSizeNode(Q.Right) + 1;
            }

            public void add(K key, V value)
            {
                if (Size == 0)
                {
                    root = new Treenode(key, value);
                    Size = 1;
                    return;
                }

                Treenode cur = root, prev = null;

                while (cur != null)
                {
                    if (key.CompareTo(cur.Key) == 0)
                        throw new DuplicateKey();

                    prev = cur;

                    if (key.CompareTo(cur.Key) < 0) cur = cur.Left;
                    else
                        cur = cur.Right;
                }

                Treenode newnode = new Treenode(key, value);
                newnode.Parent = prev;

                if (key.CompareTo(prev.Key) < 0)
                    prev.Left = newnode;
                else
                    prev.Right = newnode;

                Size++;

                SubTreeSizePlus(newnode);

                HeightFuncion(newnode);

                AVL(prev);

                hbfPlus(newnode);

            }

            private void AVL(Treenode cur)
            {
                while (cur != null)
                {
                    int hbf = HBF(cur);
                    if (Math.Abs(hbf) > 1)
                    {
                        if (hbf < 0)
                        {
                            if (HBF(cur.Left) > 0) LR(cur.Left);
                            RR(cur);
                        }
                        else
                        {
                            if (HBF(cur.Right) < 0) RR(cur.Right);
                            LR(cur);
                        }
                    }
                    cur.height = 1 + Math.Max(Height(cur.Left), Height(cur.Right));
                    cur.SubTreeSize = SubTreeSizeNode(cur.Left) + SubTreeSizeNode(cur.Right) + 1;
                    cur = cur.Parent;
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

                    HeightFuncion(newnode);
                    SubTreeSizePlus(newnode);


                    Treenode mandato = newnode;

                    AVL(mandato);

                    hbfPlus(newnode);

                }


                return ret;
            }

            override public string ToString()
            {
                if (root == null) return "";
                return root.ToString();
            }

            // Aqui

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

            private void SubTreeSizePlus(Treenode x)
            {
                while (x != null)
                {
                    if (x.Parent != null)
                    {
                        Treenode a = x.Parent.Left;
                        Treenode b = x.Parent.Right;
                        x.Parent.SubTreeSize = SubTreeSizeNode(a) + SubTreeSizeNode(b) + 1;

                    }


                    x = x.Parent;
                }
            }

            public K Max()
            {
                Treenode x = MaxNode(root);
                if (x == null)
                    throw new KeyNotFound();
                return x.Key;
            }

            private Treenode MaxNode(Treenode cur)
            {
                if (cur == null)
                    return null;
                while (cur.Right != null)
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

                while (cur != null)
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

                while (cur != null)
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

            // Todo en orden desde aqui hasta 

            private void HeightFuncion(Treenode x)
            {

                while (x != null)
                {
                    if (x.Parent == null)
                        break;
                    x.Parent.height = Math.Max(Height(x.Parent.Left), Height(x.Parent.Right)) + 1;
                    x = x.Parent;
                }
            }

            private int Height(Treenode x)
            {
                if (x == null) return -1;
                else return x.height;
            }

            public int Height(K key)
            {
                Treenode cur = FindNode(key);

                if (cur == null)
                    throw new KeyNotFoundException();

                return cur.height;
            }
        }

        static void Main(string[] args)
        {
            OrderedDictionary<int, string> leaf = new OrderedDictionary<int, string>();

            leaf.add(50, "cincuenta");
            leaf.add(25, "Vente y Cinco");
            leaf.add(15, "Quince");
            leaf.add(10, "Dies");
            leaf.add(60, "Sesenta");
            leaf.add(16, "Dies y Seis");
            leaf.add(70, "Setenta");
            Console.WriteLine(leaf.ToString());

            Console.ReadKey();

        }
    }
}
