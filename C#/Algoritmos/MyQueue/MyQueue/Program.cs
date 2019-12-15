using System;

namespace MyQueue
{
    class Program
    {
        public static int GrowFactory = 2;
        public class MyQueue <T>
        {
            T[] arr = new T[2];
            int size = 0;
            int head = 0;
            int tail = -1;


            public T deque()
            {
                if (size == 0)
                    throw new Exception("No hay dato no se puede eliminar nada");
                else
                {
                    T ret = arr[head];
                    size--;
                    if (size < arr.Length /4)
                    {
                        resize( arr.Length / 2);
                    }
                    head++;
                    if (head == arr.Length -1)
                        head = 0;

                    return ret;
                }

            }

            public void Enqueque (T x)
            {
                int temporar = 0;
                if (x == null)
                {
                    throw new Exception("No me mandes valores nulo");
                    
                }
                if (size == arr.Length)
                    resize(GrowFactory * arr.Length);
                tail++;
                temporar = tail;
                if (tail == arr.Length )
                {
                    tail = 0;
                    if (head == tail)
                    {
                        tail = temporar;
                        resize(GrowFactory * arr.Length);
                    }
                }
             
                arr[tail] = x;
                size++;
            }

            public T peak()
            {
                return arr[head];
            }


            private void resize(int newcapacity)
            {
                int contador = 0;
                T[] tmp = new T[newcapacity];

                if (head < tail)
                {
                    for (int i = head, j = 0; i <= tail; j++, i++ )
                    {
                        tmp[j] = arr[i];
                        contador++;
                    }
                }
                else
                {
                    for (int i = head, j = 0; i < arr.Length; j++, i++)
                    {
                        tmp[j] = arr[i];
                        contador++;
                    }

                    for(int i = 0, j = contador -1;i <=tail; i++, j++)
                    {
                        tmp[j] = arr[i];
                        contador++;
                    }
                }
                head = 0;
                tail = size -1; 
                arr = tmp; 

            }
        } 

        

        public static void Main(string[] args)
        {
            MyQueue<int> a = new MyQueue<int>();

            for(int i  = 1; i < 24; i++)
            {
                int x = i;
                a.Enqueque(x);
            }
            for(int i =0; i < 20; i++)
            {
                a.deque();
            }
            Console.WriteLine(a.peak());
            for(int i  = 1; i <8; i++)
            {
                a.Enqueque(i);
            }

            Console.WriteLine(a.peak());
            Console.ReadKey();
        }
    }
}
