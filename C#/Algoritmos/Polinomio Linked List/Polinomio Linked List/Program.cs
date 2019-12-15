/*
 * Puntos ejercicio: 8 puntos (+3 extra)
 * 
 * En este ejercicio, usaremos un Linked List para representar un polinomio
 * P(x), el cual no es mas que una lista de terminos.  Cada termino tiene un
 * coeficiente y un exponente.  Para simplificar, asumiremos que el polinomio:
 *  1) siempre utiliza la variable x
 *  2) los coeficientes son numeros enteros
 *  3) los exponentes son numeros enteros no negativos
 *
 * Para convertir un string en una secuencia de terminos, he proveido una clase
 * llamada Parser, el cual contiene un constructor que recibe un string.  No
 * tienes que entender la implementacion de Parser, solo debes saber usarlo:
 * Luego construir el Parser, puedes "iterar" el parser con un bucle foreach,
 * tal como se muestra en los ejemplos comentados que se encuentran en el metodo
 * Main de la clase Lab2p.
 *
 * Ubica todas las secciones con el tag TODO.  Cada tag les indicara que deben
 * completar.
 * 
 * Instrucciones adicionales: 
 *   a) No se permite usar las estructuras de datos incluidas en C#
 *   b) No se permite usar arreglos
 *   c) Agrega los metodos, atributos, excepciones adicionales que necesites
 *
 */

using System;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;



namespace Polinomio
{

    /**
     * Define un termino de un polinomio
     */
    public class Termino
    {
        public int coeficiente;
        public uint exponente;
        public Termino(int coeficiente, uint exponente)
        {
            this.coeficiente = coeficiente;
            this.exponente = exponente;
        }
    }


    /**
     * Define un parser de un string en una secuencia (enumerador) de terminos
     * de un polinomio
     */
    public class Parser : IEnumerable<Termino>
    {

        const string pattern = @"([+-]?[0-9]*)(x(?:\^([0-9]+))?)?";
        static Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

        private string expr;
        public Parser(string expr)
        {
            this.expr = expr == null ? "" : expr.Replace(" ", "");
        }

        public IEnumerator<Termino> GetEnumerator()
        {
            Match match = regex.Match(this.expr);
            while (match.Success)
            {
                //  Console.Error.WriteLine("Matched value = " + match.Value);
                if (string.IsNullOrEmpty(match.Value))
                    break;
                string scoeff = match.Groups[1].Value;
                if (string.IsNullOrEmpty(scoeff))
                    scoeff = "1";
                else if (scoeff.Equals("+") || scoeff.Equals("-"))
                    scoeff += "1";
                string sexp = match.Groups[3].Value;
                if (string.IsNullOrEmpty(sexp))
                    sexp = string.IsNullOrEmpty(match.Groups[2].Value) ? "0" : "1";
                //  Console.Error.WriteLine( scoeff + " " + sexp );
                yield return new Termino(int.Parse(scoeff), uint.Parse(sexp));
                match = match.NextMatch();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // Invoke IEnumerator<Termino> GetEnumerator() above.
            return GetEnumerator();
        }

    }


    public class Polinomio
    {
       

        // Define un nodo del linked list
        // Puedes agregar el atributo prev para convertirlo la lista en Doubly
        // Linked List
        class LinkNode
        {
            public Termino value { get; private set; }
            // Restriccion: una vez el Termino es construido, no puedes modificar
            //              el atribudo value (por eso lo puse private)
            public LinkNode next, prev;

            public LinkNode(Termino t)
            {
                value = t;
                next = null;
                prev = null;
            }

            
        }
        public int size { get; set; }
        private LinkNode head = null, tail = null;

        public void addBack(Termino t)
        {
            LinkNode node = new LinkNode(t);

            if (size == 0)
            {
                  head  = node;
                  tail = node;
            }
            else
            {
                tail.next = node;
                node.prev = tail;
                tail = node;
            }

            size++;
        }

        
        public void addFront(Termino t)
        {
            LinkNode node = new LinkNode(t);
            if(size == 0)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.next = head;
                head.prev = node;
                head = node;
            }
            size++;
        }

         LinkNode devuelta ( LinkNode A, Termino H)
         {
            LinkNode B = new LinkNode(H);
            B.next = A.next;
            B.prev = A.prev;
            return B;
         }
         
         LinkNode Eliminar (LinkNode A, Termino H)
        {
            LinkNode B = new LinkNode(H);
            B.next = A.next;
            B.prev = A.prev;
            return B;
        }


        public Polinomio(string expresion)
        {
            // TODO: Usando la clase Polinomio.Parser, construye el linked list con
            //       los terminos del polinomio.
            // NOTA1: Puedes asumir que el string 'expresion':
            //       A) contiene los terminos del polinomio en orden descendente del
            //          exponente.  O sea, el termino con mayor exponente va primero;
            //          le sigue el segundo mayor exponente, etc.
            //       B) no contiene mas de un termino con el mismo exponente.
            //       C) no contiene terminos con coeficiente == 0.
            // Complejidad: O(N) worst-case, donde N es la cantidad de terminos
            //              del polinomio
            // Valor: 1 punto

            var parser = new Parser(expresion);
            foreach(Termino term in parser)
            {
                addBack(term);
            }
           
            

            // TODO: Implementalo sin asumir nada de lo indicado en NOTA1
            // Complejidad: O(N^2) worst-case, donde N es la cantidad de terminos
            //              del polinomio
            // Extra: 3 puntos
        }


        /**
         * Agrega el polinompio 'P' al polinomio 'this'.
         *
         * Luego de esta operacion, el polinomio 'this' debe contener la suma
         * de los dos polinomios.
         */
        public void Add(Polinomio P)
        {

            // TODO: Implementar
            // Complejidad esperada: O(N1 + N2) worst-case, donde N1 y N2 son las
            //                       cantidades de terminos en el polinomio 'this'
            //                       y P respectivamente
            // Restricciones:
            //  1) No se permite crear mas de N2 nuevos nodos
            //  2) En el polinomio resultante, debes mantener los terminos ordenados
            //     de mayor exponente a menor exponente
            //  3) El polinomio resultante no puede contener mas de un termino con
            //     el mismo exponente
            //  4) Si la suma arroja un coeficiente con valor 0, debes omitir dicho
            //     termino del resultado (a menos que el polinomio consiste solo
            //     del termino que es constante)
            // OJO: el polinomio P no debe modificarse
            // Valor: 5 puntos

            
      
            LinkNode TMP3 = new LinkNode(P.head.value);
            LinkNode TMP2 = new LinkNode(P.head.value);
            TMP2 = P.head;
            LinkNode TMP1 = new LinkNode(head.value);
            TMP1 = this.head;

         

            while (TMP2 != null)
            {
               
                    
                    if (TMP1.value.exponente == TMP2.value.exponente)
                    {
                        TMP1.value.coeficiente += TMP2.value.coeficiente;
                       /* if (TMP1.value.coeficiente == 0)
                        {
                        
                        int X = TMP1.prev.value.coeficiente;
                        uint Y = TMP1.prev.value.exponente;
                        Termino H = new Termino(X, Y);
                        TMP3 = TMP1.prev;
                        TMP3.next = TMP1.next; 
                        var node = Eliminar(TMP3, H);
                        TMP1 = node;

                        }*/
                 
                        TMP2 = TMP2.next;
                  
                     }
                    if(TMP2 == null)
                    {
                    break;
                    }
                    if (TMP1.value.exponente > TMP2.value.exponente)
                    {

                       if (TMP1.next.value.exponente < TMP2.value.exponente)
                       { 
                        uint x = TMP2.value.exponente;
                        int y = TMP2.value.coeficiente;
                        Termino H = new Termino(y, x);
                        var linkNode = devuelta( TMP1, H);
                       
                                 
                                              
                        TMP1.next = linkNode;

                        TMP1 = TMP1.next;
                        TMP2 = TMP2.next;

                        

                       }
                       else
                       {
                        
                        TMP1 = TMP1.next;


                       }
                       if (TMP2 == null || TMP1 == null)
                       {
                           break;
                       }
                    }

                     if (TMP1.value.exponente < TMP2.value.exponente)
                      {
                        if (P.tail.value.exponente > head.value.exponente)
                        {
                        head.prev = P.tail;
                        P.tail.next = head;
                        head = P.head;
                        break;

                        }
                    }
                    if (TMP1.prev == null)
                    {
                        addFront(TMP2.value);
                        TMP2 = TMP2.next;
                        
                       
                        
                    }
                   
                       
                        
              }
                
            

            

        }


        public override string ToString()
        {
            string concatenacion = "";
            string exponente = "";
            string X = "X^";
            string positivo = " + ";
            int contador = 0;
            LinkNode h = new LinkNode(head.value);
            h = head;
            while (h != null)
            {
                X = "X^";
                if(contador == 0)
                {
                    positivo = "";
                }
                else
                {
                    positivo = " + ";
                }
                
                

                if(h.value.exponente == 1)
                {
                    exponente = "";
                    X = "X";
                }
                else
                {
                    exponente = "" + h.value.exponente;
                }
                if (h.value.exponente == 0) 
                {
                    exponente = "";
                    X = "";
                    positivo = " + ";
                }
                if (h.value.coeficiente == 0)
                {
                    h = h.next;
                }
                else
                {
                    if (h.value.coeficiente < 0)
                    {
                        concatenacion = concatenacion + " " + h.value.coeficiente + X + exponente;
                    }
                    else
                    {
                        concatenacion = concatenacion + " " + positivo + h.value.coeficiente + X + exponente;
                    }
                    h = h.next;
                }

               
               
            }
            contador++;
            return concatenacion;
        }
    }


}


class Lab2p
{
    public static void Main(string[] args)
    {
        string expr1 = "3x^5 - x^2 - 5x + 13";
        
        Console.WriteLine("Parsing expression: " + expr1);
        var parser = new Polinomio.Parser(expr1);
        foreach (Polinomio.Termino term in parser) {
            Console.WriteLine("coeficiente={0}  exponente={1}",
                              term.coeficiente, term.exponente);
        }
        Console.WriteLine();
        

        string expr2 = "x^8 - 4x^5 + 10x^3 + x^2 + x";
        
        Console.WriteLine("Parsing expression: " + expr2);
        var parser2 = new Polinomio.Parser(expr2);
        foreach (Polinomio.Termino term in parser2) {
            Console.WriteLine("coeficiente={0}  exponente={1}",
                              term.coeficiente, term.exponente);
        }
        Console.WriteLine();
        

        var P1 = new Polinomio.Polinomio(expr1);
        var P2 = new Polinomio.Polinomio(expr2);
        P1.Add(P2);
        Console.WriteLine("Resultado: " + P1.ToString());

        Console.ReadLine();

    }
}

