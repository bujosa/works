/*
 *
 * Puntos ejercicio: 15
 *
 *
 * Este ejercicio consiste en convertir un Binary Search Tree (arbitrario) a un
 * arbol AVL.
 *
 * Todas las secciones a modificar estan marcardas con el tag TODO.
 *
 * Para simplificar este ejercicio:
 *   1) Grabaremos keys de int (sin value asociado al key)
 *   2) Se permite usar las estructuras de datos en System.Collections.Generic
 *
 * A menos que se indique de lo contrario, no se permite:
 *   1) Alterar los atributos existentes de las clases
 *   2) Alterar el funcionamiento de los otros metodos
 *
 * Instrucciones adicionales: 
 *   a) Se permite agregar mas atributos a las clases
 *   b) Se permite crear metodos adicionales auxiliares a los metodos que debes
 *      implementar
 *   c) No borren los comments que existen en este codigo
 *
 *
 */

using System;
using System.Collections.Generic;
using System.Text;



class DuplicateKeyException : Exception { }
class InvalidRotation : Exception { }

class NotAVLTree
{
    class TreeNode
    {
        public int key;
        public TreeNode left, right, parent;
        public int height;
        public int depth;
        //  public int height, depth;  // NOTA: puedes agregar estos atributos si lo deseas
        public TreeNode(int key)
        {
            this.key = key;
            this.height = 0;
        }

        // Convertir el subtree cuya raiz es este nodo a un string (para
        // verificar que su codigo de conversion funciona)
        // Nota: les sugiero que ignoren este codigo
        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('(');
            sb.Append(key);
            if (left != null || right != null)
            {
                sb.Append('-');
                sb.Append(left == null ? "()" : left.ToString());
                sb.Append('-');
                sb.Append(right == null ? "()" : right.ToString());
            }
            sb.Append(')');
            return sb.ToString();
        }
    }

    private int depth(TreeNode x)
    {
        if (x == null)
            return 0;
        else
            return x.depth;
    }

    private int HBF(TreeNode cur)
    {

        int res = Height(cur.right) - Height(cur.left);

        return res;

    }

    private void HeightFuncion(TreeNode x)
    {
        while (x != null)
        {
            if (x.parent == null)
                break;
            x.parent.height = Math.Max(Height(x.parent.left), Height(x.parent.right)) + 1;
            x = x.parent;
        }
    }

    private int Height(TreeNode x)
    {
        if (x == null) return -1;
        else return x.height; 
    }

    private TreeNode root;
    public int size { get; private set; }  // Cantidad de keys grabados en el arbol


    /** 
     *  Agrega key al arbol
     **/
    public void Add(int key)
    {
        if (size == 0)
        {
            root = new TreeNode(key);
            size = 1;
            return;
        }

        TreeNode cur = root, prev = null;
        while (cur != null)
        {
            if (key == cur.key)
                throw new DuplicateKeyException();
            prev = cur;
            if (key < cur.key)
                cur = cur.left;
            else
                cur = cur.right;
        }
        TreeNode newNode = new TreeNode(key);
        newNode.parent = prev;
        if (key < prev.key)
            prev.left = newNode;
        else
            prev.right = newNode;

        size++;
        if (size > 1)
        {
            newNode.depth = 1 + prev.depth; 
        }
        HeightFuncion(newNode);
      
    }


    /** 
     *  Busca y devuelve el nodo que contiene key; devuelve null si no se 
     *  encuentra
     **/
    private TreeNode FindNode(int key)
    {
        TreeNode cur = root;
        while (cur != null)
        {
            if (key == cur.key)
                return cur;
            else if (key < cur.key)
                cur = cur.left;
            else
                cur = cur.right;
        }
        return null;
    }


    /** 
     *  Devuelve true si key existe en el arbol
     **/
    public bool Exists(int key)
    {
        TreeNode x = FindNode(key);
        return x != null;
    }


    /** 
     *  Borra key del arbol; devuelve false si el key NO se encuentra en el
     *  arbol
     **/
    public bool Remove(int key)
    {
        TreeNode cur = FindNode(key);

        if (cur == null) return false;
        else
        {
            RemoveNode(cur);
            size--;
            return true;
        }
        // TODO: implementar el siguiente algoritmo
        //       1) Buscar el nodo X que contiene key
        //       2) Si X es un leaf o tiene un solo hijo, borralo como fue
        //          descrito para Hibbard's Delete
        //       3) Si X tiene 2 hijos
        //            3a) Ubica el sucesor de X, llamemoslo Y
        //            3b) Rota el nodo Y hasta que se convierta en padre de X
        //            3c) En este punto X no tendra hijo derecho y lo puedes
        //                borrar como en el caso de que tiene un solo hijo
        // Valor: 5 puntos
        // Complejidad esperada: Theta(H)
      
    }

    private void RemoveNode(TreeNode x)
    {

        bool removed = true;
       
        TreeNode p = x.parent;
        TreeNode newnode = x.parent;


        if (x.left == null && x.right == null)
        {
            // no tiene hijos

            if (p == null)
            {
                // x == root
                root = null;

            }

            //  if (x.key < p.key)
            if (x == p.left)
                p.left = null;
            else
                p.right = null;
        }

        else if (x.left != null && x.right == null)
        {
            // tiene 1 hijo (izquierdo)
            TreeNode y = x.left;

            if (p == null)
            {
                // x == root
                root = y;
            }
            else if (x == p.left)
            {
                p.left = y;
            }
            else
            {
                p.right = y;
            }
            y.parent = p;

        }
        else if (x.left == null && x.right != null)
        {
            // tiene 1 hijo (derecho)
            TreeNode h = x.right;
            if (p == null)
            {
                // x == root
                root = h;
            }
            else if (x == p.left)
            {
                p.left = h;
            }
            else
            {
                p.right = h;
            }
            h.parent = p;

        }
        else
        {
            // tiene 2 hijos
            TreeNode Y = Successor(x.key);
            
            while(Y != x.parent)
            {
                if (Y.parent == null)
                    break;
                TreeNode h = Y.parent;
                if (Y == h.left)
                    RotateRight(h);
                else
                    RotateLeft(h);

                
            }
            RemoveNode(x);
            removed = true;

        }

        // boleano para ajustar el height 
        if (removed != false)
        {
            HeightFuncion(x);
        }

    }

    /*
     * Sucesor 
    */
    private TreeNode Successor(int key)
            {
                TreeNode cur = root, best = null;
                while (cur != null)
                {
                    if (key.CompareTo(cur.key) == 0)
                        cur = cur.right;

                    else if (key.CompareTo(cur.key) < 0)
                    {
                        if (best == null || best.key.CompareTo(cur.key) > 0)
                            best = cur;
                        cur = cur.left;
                    }
                    else
                        cur = cur.right;
                }
                if (best == null)  // no hay sucesor
                    throw new KeyNotFoundException();
                return best;
            }

     /** 
     *  rotateLeft(P) rota el nodo P hacia la izquierda.
     **/
    private void RotateLeft(TreeNode P)
    {
        // NOTA: Puedes alterar este metodo
        if (P == null || P.right == null)
            throw new InvalidRotation();

        TreeNode par = P.parent;
        TreeNode Q = P.right;
        TreeNode B = Q.left;
        if (B != null)
            B.parent = P;
        P.right = B;
        P.parent = Q;
        Q.left = P;
        Q.parent = par;
        if (par != null)
        {
            if (P == par.left)
                par.left = Q;
            else
                par.right = Q;
        }
        else
            root = Q;
        P.height = Math.Max(Height(P.left), Height(P.right)) + 1;
        Q.height = Math.Max(Height(Q.left), Height(Q.right)) + 1;
    }

    /** 
     *  rotateRight(Q) rota el nodo Q hacia la derecha.
     **/
    private void RotateRight(TreeNode Q)
    {
        // NOTA: Puedes alterar este metodo
        if (Q == null || Q.left == null)
            throw new InvalidRotation();

        TreeNode par = Q.parent;
        TreeNode P = Q.left;
        TreeNode B = P.right;
        if (B != null)
            B.parent = Q;
        Q.left = B;
        Q.parent = P;
        P.right = Q;
        P.parent = par;
        if (par != null)
        {
            if (Q == par.left)
                par.left = P;
            else
                par.right = P;
        }
        else
            root = P;
        Q.height = Math.Max(Height(Q.left), Height(Q.right)) + 1;
        P.height = Math.Max(Height(P.left), Height(P.right)) + 1;

    }


    /**
     * Transformar el Binary Search Tree a AVL Tree
     **/
    private bool FixAVLPropertyOfNode(TreeNode cur)
    {
        if (cur == null)
            throw new KeyNotFoundException();

        int y = HBF(cur);

        if (Math.Abs(y) > 2) return false;
        else
        {
            while (cur != null)
            {
                int hbf = HBF(cur);
                if (Math.Abs(hbf) > 1)
                {
                    if (hbf < 0)
                    {
                        if (HBF(cur.left) > 0) RotateLeft(cur.left);
                        RotateRight(cur);
                    }
                    else
                    {
                        if (HBF(cur.right) < 0) RotateRight(cur.right);
                        RotateLeft(cur);
                    }

                    cur.height = 1 + Math.Max(Height(cur.left), Height(cur.right));
                }
                cur = cur.parent;
            }
            
            return true;
        }

        // TODO: Implementa el algoritmo descrito en clase para corregir la
        //       violacion (si existiese) de la propiedad AVL en el nodo x.
        //       NOTA: el algoritmo descrito en clase NO funciona si el
        //       height balance factor del nodo x es < -2 o > +2, en cuyo caso
        //       este metodo simplemente devuelve false; de lo contrario,
        //       corrigelo y devuelve true
        // Complejidad esperada: O(1)
        // Valor: 4 puntos
        
      
    }


    /**
     * Transformar el Binary Search Tree a AVL Tree
     **/

    private List<TreeNode> inOrderIteraction()
    {
        List<TreeNode> L = new List<TreeNode>();

        R(L, root);

        return L;

    }

    void R(List<TreeNode> L, TreeNode cur)
    {
        if (cur == null)
            return;
        R(L, cur.left);

        cur.depth = Depth(cur); 
            L.Add(cur);

        R(L, cur.right);

    }

    private int sort(TreeNode a, TreeNode b)
    {
        if (a.depth < b.depth) return 1;
        else if (a.depth == b.depth) return 0;
        return -1;
    }

    public bool TransformToAVLTree()
    {
        List<TreeNode> cur = inOrderIteraction(); // Complejida Theta(N*LogN)
       
        cur.Sort(sort); // Complejidad Theta(N*Log(N))
        TreeNode[] arreglo = cur.ToArray();

        for(int i = 0; i < size; i++)  // Complejidad Theta(N)
        {
            FixAVLPropertyOfNode(arreglo[i]);
        }

        // TODO: Implementa el siguiente algoritmo:
        //       1) Computa el depth de cada nodo en el arbol
        //       2) Ordena los nodos por su depth
        //          Puedes consultar en Internet sobre como ordenar datos en C#
        //       3) Itera los nodos de mayor a menor depth
        //         3a) Calcula el height y balance factor de cada nodo
        //         3b) Si un nodo requiere correccion, llama al metodo
        //             FixAVLPropertyOfNode
        //       Si en alguno punto no fue posible corregirse, devuelve false
        // Complejidad esperada: mejor que cuadratico
        // Valor: 5 puntos

        // TODO: determina la complejidad de cada paso en el algoritmo indicado
        // Valor: 1 punto

        // TODO: Implementa otro algoritmo con complejidad lineal
        // Complejidad esperada: Theta(N)
        // Valor: 3 puntos extras

        return false;
    }

    private TreeNode[] NewMethod(TreeNode[] arreglo)
    {

        for(int i = 0; i < size - 1; i++)
        {
            int position = 0;
            int temporal = 0;
            int x = Depth(arreglo[i]);

            for(int z = i + 1; z < size; z++)
            {
                int y = Depth(arreglo[z]);
                if (y > temporal && y > x)
                {
                    temporal = y;
                    position = z;
                }
            }

            if (position != 0)
            {
                if (arreglo[i] == arreglo[position])
                    continue;
                else
                {
                    TreeNode tmp = arreglo[i];
                    arreglo[i] = arreglo[position];
                    arreglo[position] = tmp;
                }
            }
        }

        return arreglo;
    }

    private int Depth(TreeNode cur)
    {
        int res = 0;

        while(cur != null)
        {
            if (cur.parent == null)
                break;
            cur = cur.parent;
            res++;
        }

        return res;
    }
    /**
     * Convertir el arbol a un string (para debugging)
     **/
    override public string ToString()
    {
        if (root == null) return "";
        return root.ToString();
    }
}


class Lab3v
{
    static void Main(string[] args)
    {
        NotAVLTree T = new NotAVLTree();
        T.Add(90);
        T.Add(100);
        T.Add(20);
        T.Add(10);
        T.Add(70);
        T.Add(30);
        T.Add(40);
        T.Add(50);
        T.Add(80);

        Console.WriteLine(T);
        // (90-(20-(10)-(70-(30-()-(40-()-(50)))-(80)))-(100))

        
        T.TransformToAVLTree();

        Console.WriteLine(T);
        // (40-(20-(10)-(30))-(90-(70-(50)-(80))-(100)))
        // NOTA: No estoy seguro si este output esta correcto :-P

        T.Remove(40);
        Console.WriteLine(T.Exists(40));  // False

        Console.WriteLine(T);
        // (50-(20-(10)-(30))-(90-(70-()-(80))-(100)))
        // NOTA: Tampoco estoy seguro si este output esta correcto :-P

     
        Console.ReadKey();
    }
}

