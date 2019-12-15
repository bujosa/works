using System;
using System.Collections.Generic;

namespace ControlVisual
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Equipos> dato = new Dictionary<int, Equipos>();
            Dictionary<int, Devoluciones> dato2 = new Dictionary<int, Devoluciones>();

            int opcion = 0;
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("\t\tControl de Equipos Visuales INTEC\n");
                Console.WriteLine(" 1. Administrar los equipos ");
                Console.WriteLine(" 2. Prestar Objeto");
                Console.WriteLine(" 3. Devoluciones");
                Console.WriteLine(" 4. Salir ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:          
                        int tmp = 0;
                        while (tmp != 3)
                        {
                            Console.Clear();
                            Console.WriteLine("\tMenu de control\n");
                            Console.WriteLine(" 1. Agregar nuevos equipos");
                            Console.WriteLine(" 2. Listar Equipos");
                            Console.WriteLine(" 3. Salir");
                            tmp = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            switch (tmp)
                            {
                                
                                case 1:
                                    Console.WriteLine("Nombre del equipo");
                                    string equipo = Console.ReadLine();
                                    Equipos objet = new Equipos(true, equipo);
                                    dato.Add(dato.Count, objet);
                                    break;
                                case 2:
                                    for (int i = 0; i < dato.Count; i++)
                                    {
                                        Equipos a = dato[i];
                                        string status;
                                        if (a.EnPropiedad)
                                            status = "disponible";
                                        else
                                            status = "prestado";

                                        Console.WriteLine(a.NombreObjeto + " " + status);
                                    }
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.WriteLine("Eliga solo una de las opciones");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\tPrestaciones\n");
                        for (int i = 0; i < dato.Count; i++)
                        {
                            Equipos a = dato[i];
                            string status;
                            if (a.EnPropiedad)
                            {
                                status = "disponible";


                                Console.WriteLine(i + "." + a.NombreObjeto + " " + status);
                            }
                        }
                        Console.WriteLine("\nEliga un objeto disponible\n");
                        int opcion2 = Convert.ToInt32(Console.ReadLine());
                        if(dato[opcion2].EnPropiedad)
                        {
                            Console.WriteLine("Escriba su nombre:\n");
                            string nombre = Console.ReadLine();
                            Devoluciones devuelto = new Devoluciones(dato[opcion2], nombre);
                            dato2.Add(dato2.Count, devuelto);
                            Console.WriteLine("\nCompletada");
                            dato[opcion2].EnPropiedad = false;
                            
                        }
                        else
                        {
                            Console.WriteLine("Este objeto no esta disponible\n");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\tDevoluciones\n");
                        for (int i = 0; i < dato.Count; i++)
                        {
                            Equipos a = dato[i];
                            string status;
                            int vuelta = 0;
                            if (!a.EnPropiedad)
                            {  
                                status = "Devolver";
                                Console.WriteLine(vuelta + "." + a.NombreObjeto + " " + status);
                                vuelta++;
                            }
                        }
                        Console.WriteLine("\nEliga un objeto para devolver");
                        int opcion3 = Convert.ToInt32(Console.ReadLine());

                        if (dato2.ContainsKey(opcion3))
                        {
                            Console.WriteLine("El objeto lo tiene {0}",dato2[opcion3].nombre + " a la hora " + dato2[opcion3].fecha );
                            Console.WriteLine("\nCompletada\n");
                            dato2.Remove(opcion3);
                        }
                        else
                            Console.WriteLine("Este objeto no esta disponible\n");
                        Console.ReadKey();
            
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Solo puede utilizar los numeros entre 1 a 4");
                        Console.ReadKey();
                        break;
                }
            }
            Console.WriteLine("Hasta Luego");
            Console.ReadKey();
        }
    }

    public class Devoluciones
    {
        public Equipos data;
        public string nombre;
        public DateTime fecha;

        public Devoluciones(Equipos data, string nombre)
        {
            this.data = data;
            this.nombre = nombre;
            this.fecha = DateTime.Now;
        }
    }
    // Clase que define al equipo
    public class Equipos
    {
        public bool EnPropiedad = true;
        public string NombreObjeto;

        public Equipos(bool enPropiedad, string nombreObjeto)
        {
            EnPropiedad = enPropiedad;
            NombreObjeto = nombreObjeto;
        }
        

    }
}
