using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Puntos del ejercicio: 12 puntos (+2 extra)
 *
 * En la clase del miercoles, Axel propuso una nueva manera de manejar el
 * problema de los Remove en Linear Probing y habiamos quedado en que la
 * complejidad de cada operacion era Theta(N / M) en el average case, donde
 * N es la cantidad de datos y M = arr.Length.  Fijense que si variamos M
 * de acuerdo a la cantidad de datos en el Dictionary, Theta(N / M) = O(1),
 * tal como demostramos para Separate Chaining.
 *
 * En este ejercicio, debes implementar la estrategia descrita por Axel y
 * comprobar o refutar la hipotesis de que la complejidad es O(1) en average.
 *
 * La estrategia de Axel es mantener una tabla de frecuencia C, donde C[r] =
 * cantidad de datos cuyo key tiene r como remantente si se divide por M.
 *
 * Para Find:
 *   - T = la cantidad de datos cuyo key tiene el mismo remanente que el key que
 *     estas buscando
 *   - Calcula la posicion inicial
 *   - Itera desde esa posicion inicial avanzando con step size 1
 *      - Si encuentras el key, devuelve el valor asociado a ese key
 *      - Deten el bucle cuando ya inspeccionaste exactamente T keys cuyo
 *        remanente (de dividir por M) coincide con el remanente del key que
 *        estas buscando.
 *
 * Para Remove:
 *   - Encuentra el dato a borrar
 *   - Elimina el dato dejando vacio el bucket donde se encuentra el dato
 *   - Reduce el contador del remantente que corresponde al key que acabas de
 *     eliminar
 *
 * Para Add:
 *   - Busca el siguiente bucket vacio y coloca el dato en esa casilla
 *   - Aumenta el contador del remantente que corresponde al key que acabas de
 *     de grabar
 *
 * Puedes asumir que los keys son numeros enteros sin negativos.
 *
 * Ubica todas las secciones con el tag TODO.  Cada tag les indicara que deben
 * completar.
 * 
 * Instrucciones adicionales: 
 *   a) No se permite usar las estructuras de datos incluidas en C#
 *   b) Agrega todas las clases adicionales que requieras
 *   c) Agrega todos los atributos y metodos que requieras
 *
 */

namespace Lab2h
{

    public class AxelDictionary<V>
    {
        private int size = 0;

        public class KVP
        {
            public int key;
            public V value;


            public KVP(int key, V value)
            {
                this.key = key;
                this.value = value;
            }

        }

        KVP[] arr = new KVP[4];
        int[] frec = new int[4];

        public int Size()
        {
            return size;
        }

        long hash(int key)
        {
            return 31L * key + 903147145;
        }

        private KVP Get(int key)
        {

            long pos = InitialPos(key);
            long initialPos = pos;
            int contador = frec[pos];
            while (contador != 0)
            {

                if (arr[pos] != null)
                {
                    if (arr[pos].key == key) return arr[pos];

                    if (InitialPos(arr[pos].key) == initialPos) contador--;

                }
                pos++;

                if (pos >= arr.Length) pos = 0;

            }
            return null;
        }

        private KVP GetRemove(int key)
        {

            long pos = InitialPos(key);
            long initialPos = pos;
            int contador = frec[pos];
            while (contador != 0)
            {

                if (arr[pos] != null)
                {
                    if (arr[pos].key == key)
                    {

                        KVP p = arr[pos];
                        arr[pos] = null;
                        return p;

                    }

                        ;

                    if (InitialPos(arr[pos].key) == initialPos) contador--;



                }


                pos++;


                if (pos >= arr.Length) pos = 0;

            }
            return null;
        }

        public long InitialPos(int x)
        {
            long ret = Math.Abs(hash(x)) % arr.Length;
            return ret;
        }

        public void Add(int key, V value)
        {
            // TODO: implementar
            // Complejidad esperada: O(1) average?
            // Valor: 1.5 puntos

            KVP p = Get(key);
            if (p != null) throw new Exception("Duplicated key");


            double loadFactor = ((double)Size()) / arr.Length;

            if (loadFactor > 0.7) ResizeAndReindex(2 * arr.Length);

            long pos = InitialPos(key);
            long initialPos = pos;

            while (true)
            {
                if (arr[pos] == null) break;

                pos++;

                if (pos >= arr.Length) pos = 0;
            }

            arr[pos] = new KVP(key, value);

            size++;
            frec[initialPos]++;

            // TODO: Para la estrategia de Axel, en clase mencione incorrectamente
            //       que haremos Resize cuando la tabla se llena 100%.  Esto no
            //       funciona!  Provee un contraejemplo en Main que haga que cause
            //       mal performance
            // Valor: 1 punto extra
        }

        public V Remove(int key)
        {
            // TODO: implementar
            // Complejidad esperada: O(1) average?
            // NOTA: No tienes que hacer resize
            // Valor: 1.5 puntos

            KVP p = GetRemove(key);

            if (p == null)
            {
                Console.WriteLine("Key not Found(Remove)");
                throw new KeyNotFoundException();
            }

            size--;
            frec[InitialPos(key)]--;

            return p.value;


            // TODO: Determina (e implementa) la condicion correcta hacer resize
            // Valor: 1 punto extra


        }

        public V Find(int key)
        {
            // TODO: implementar
            // Complejidad esperada: O(1) average?
            // Valor: 3 puntos
            KVP p = Get(key);

            if (p == null)
            {
                throw new Exception("Key not found");
            }



            return p.value;
        }

        private void ResizeAndReindex(int newCapacity)
        {
            // TODO: implementar
            // Complejidad esperada: O(newCapacity + N)
            // Valor: 3 puntos

            KVP[] temp = new KVP[newCapacity];
            int[] newFrec = new int[newCapacity];

            foreach (KVP p in arr)
            {

                if (p == null) continue;

                long pos = Math.Abs(hash(p.key)) % temp.Length; ;
                long initialPos = pos;

                while (true)
                {

                    if (temp[pos] == null) break;

                    pos++;

                    if (pos >= temp.Length) pos = 0;
                }

                temp[pos] = p;
                newFrec[initialPos]++;
            }
            arr = temp;
            frec = newFrec;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
              var D = new AxelDictionary<string>();
              D.Add(3, "tres");
              D.Add(1, "uno");
              D.Add(4, "cuatro");
            Console.WriteLine( D.Remove(1));

              Random rnd = new Random(123);
              int k = rnd.Next(0, 100);  // Genera un numero aleatorio de 0 a 100
              D.Add(k, "" + k);
              k = rnd.Next(0, 100);      // Genera otro numero aleatorio de 0 a 100
              D.Add(k, "" + k);
           
            Console.WriteLine(D.Find(4));
            Console.ReadKey();
        
            // TODO: Comprueba via un experimento de que la complejidad de los
            //       metodos Add, Remove y Find son O(1) en average.
            //       Debes proveer el codigo que usaste para conducir tus
            //       experimentos
            // Valor: 3 puntos

            // Un ejemplo de como medir tiempo de ejecucion en C#
        
            long startTime = DateTime.Now.Ticks;
            //  Console.WriteLine(startTime);
          
            long endTime = DateTime.Now.Ticks;
            //  Console.WriteLine(endTime);
            long duration = (endTime - startTime) / 10000;
            Console.WriteLine("Duracion: {0}ms", duration);
            Console.Read();
            
       


           
        }
    }
}
