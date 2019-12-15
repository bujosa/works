

using System;


class EmptyException : System.Exception { }

class Deque <T>
{
    public const int GrowFactory = 2;
    private T[] arr = new T[2];  // el arreglo circular
    private int head = 0;  // head es el indice del elemento en frente de la cola
    private int tail = -1;  // tail es el indice del elemento al final de la cola
    private int size = 0;  // cantidad de datos grabados en el Deque

    // Devuelve la cantidad de datos presentes en la cola
    public int Size()
    {
        return size;
    }

    // Agrega el elemento x al final de la cola
    public void AddBack(T x)
    {
        if (arr.Length == size)
            Resize(arr.Length * GrowFactory);

        tail++;
        if (tail == arr.Length)
            tail = 0;
        arr[tail] = x;
        size++;
    }

    // Agrega el elemento x al frente de la cola
    public void addfront(T x)
    {

        if (arr.Length == size)
            Resize(arr.Length * GrowFactory);
        if (size == 0)
        {
            head = 0;
            tail = 0;
        }
        else
        {
            if (head == 0)
            {
                head = arr.Length - 1;
                
            }
            else
            {
                head--;
            }
        }
        arr[head] = x;
        // TODO: implementar
        // Complejidad esperada: la misma de AddLast
        // Valor: 1 punto
        size++;
    }

    // Extrae y devuelve el elemento en frente de la cola
    public T RemoveFront()
    {
        if (size == 0)
            throw new EmptyException();

        T ret = arr[head];
        head++;
        if (head == arr.Length)
            head = 0;

        size--;
        if (size < arr.Length / 4)
            Resize(arr.Length / 2);

        return ret;
    }

    // Extrae y devuelve el elemento al final de la cola
    public T RemoveBack()
    {

        T ret = arr[tail];
        
        if (size == 0)
            throw new Exception("No existe nada que eliminar");
        if (tail == 0 )
        {
            tail = arr.Length - 1;
        }
        else
        {

            tail--;
        }
        // TODO: implementar
        // Complejidad esperada: la misma de RemoveFirst
        // Valor: 1 punto
        size--;
        if (size < arr.Length / 4)
            Resize(arr.Length / 2);

        return ret ;
    }

    // Agranda/reduce la capacidad del arreglo arr, sin perder los datos que
    // estaban presentes en el Deque.
    private void Resize(int newCapacity)
    {
        int contador = 0;
        T[] tmp = new T[newCapacity];
      
        if (head > tail)
        {

            for(int i = head, j = 0; i < arr.Length; i++)
            {
                tmp[j] = arr[i];
                j++;
                contador = j;
               
            }
            for(int i = 0, j = contador; i <=tail; i++)
            {
                tmp[j] = arr[i];
                contador++;
            }            
        }
        else
        {
            for (int i = head, j = 0; i <= tail; i++)
            {
                tmp[j] = arr[i];
                j++;
            }

        }

        head = 0;
        tail = size - 1;
        // TODO: implementar resize de Deque.
        // Complejidad esperada: Theta(C) donde C es la nueva capacidad
        // Valor: 4 puntos
        arr = tmp;
    }

    // Devuelve el elemento al frente de la cola
    public T PeekFirst()
    {
        if (size == 0)
            throw new EmptyException();
        return arr[head];
    }

    // Devuelve el elemento al final de la cola
    public T PeekLast()
    {
        if (size == 0)
            throw new EmptyException();
        return arr[tail];
    }


    // Devuelve el elemento que se encuentra en la posicion pos de la cola,
    // donde Peek(0) equivale a PeekFirst() y Peek(Size()-1) equivale a
    // PeekLast()
    public T Peek(int pos)
    {
        // TODO: implementar
        // Complejidad esperada: O(1) worst-case
        // Valor: 1 punto extra
        if (pos < 0)
            throw new Exception("No puede ser numero negativo");

        T ret = arr[pos - 1];

        return ret;
    }


}


class Practica
{
    static void Main(string[] args)
    {
        Deque<int> d = new Deque<int>();
        d.addfront(7);
        d.addfront(8);
        d.AddBack(9);
        d.AddBack(1);
        d.AddBack(3);
        d.addfront(2);
        Console.WriteLine("RemoveLast: {0}", d.RemoveBack());
        Console.WriteLine("RemoveFirst: {0}", d.RemoveFront());
        Console.WriteLine("RemoveFirst: {0}", d.RemoveFront());
        Console.WriteLine("RemoveFirst: {0}", d.RemoveFront());
        Console.WriteLine("RemoveFirst: {0}", d.RemoveFront());
        d.AddBack(5);
        d.addfront(4);
        d.RemoveBack();
        Console.WriteLine("PeekFirst: {0}", d.PeekFirst());
        Console.WriteLine("PeekLast: {0}", d.PeekLast());
        Console.ReadKey();
        /*
        Resultado esperado:
        RemoveLast: 3
        RemoveFirst: 2
        RemoveFirst: 8
        RemoveFirst: 7
        RemoveFirst: 9
        PeekFirst: 4
        PeekLast: 1
        */
    }
}


