using System;

namespace MyStack
{
    class Program
    {
      
        class stack<T>
        {
            private T[] arr;
            public int size { get; private set; }
            const int GROWTH_FACTORY = 2;
            public stack()
            {
                arr = new T [2];
                size = 0;

            }

            public T pop()
            {
                T ret = arr[size - 1];
                if(this.size < arr.Length / 4)
                {
                    resize(arr.Length / 2); 
                }
                if (size == 0)
                    throw new Exception("No hay dato que eliminar");
                size--;
                return ret;
            }

            // busca el valor que esta en la ultima posicion 

            public T peek()
            {
                T ret = arr[size - 1];
                return ret;
            }

            // si hay 0 1 2 3 4 5 el agrega en la posicion 5
            // Lo mismo que addBack

            public void push(T x)
            {
                if (size == arr.Length)
                    resize(arr.Length * GROWTH_FACTORY);
                arr[size] = x;
                size++;
            }


            // rediseña el arreglo el tamaño lo aumenta o disminuye segun su conveniencia 

            private void resize (int newcapacity)
            {
                T[] tmp = new T[newcapacity];
           
                for(int i = 0; i<size; i++)
                {
                    tmp[i] = arr[i];
                }
 
                arr = tmp;
            }

        }

        static void Main(string[] args)
        {
            stack<int> pila = new stack<int>();
            pila.push(5);
            pila.push(4);
            pila.push(3);

            Console.WriteLine(pila.peek());

            Console.ReadLine();

            pila.pop();

            Console.WriteLine(pila.peek());

            Console.ReadLine();
           
        }
    }
}
