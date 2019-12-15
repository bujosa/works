using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace SistemaResidencial
{
    class Program
    {
        public static List<Residenciales> residencias = new List<Residenciales>(); // Listado de Residenciales
        public static Dictionary<string, Residenciales> Dir = new Dictionary<string, Residenciales>(); // Validador
        public static List<Quejas> qp = new List<Quejas>(); // Listado de Quejas
        public static Dictionary<string, Quejas> QJ = new Dictionary<string, Quejas>(); // Validador de quejas
        public static string NResidencial, Apto, queja, areacomun = "", NombreResidencial = ""; // Variable de Asignacion
        public static int Menu = 0, Cash = 0; // Variables Numericas

        static void Main(string[] args)
        {
            while (Menu != 5)
            {
                Console.Clear();
                Console.WriteLine("\t\tAdministracion de Residenciales\n\n");
                Console.WriteLine("Residencial Vista Hermosa:\n\n " +
                    "1-Registrar Resindencial\n " +
                    "2-Realizar Pago\n " +
                    "3-Residenciales Registrados\n " +
                    "4-Quejas\n " +
                    "5-Salir");

                Menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (Menu)
                {     
                    case 1:
                        Registrar(); // Llamada de la funcion de Registro
                        break;
                    case 2:
                        RealizarPago(); // Llamada de la funcion de Pagar
                        break;
                    case 3:
                        Listar(); // lista todo los residenciales
                        break;
                    case 4:
                        Quejas(); // Llama la funcion de quejas
                        break;
                    case 5:
                        break;
                    default:           
                        Console.WriteLine("Ingrese los numeros permitidos Exclusivamente");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Pulse una tecla para continuar");
                Console.ReadKey();        
            }
            Console.Clear();
            Console.WriteLine("Hasta Luego!!!!");
            Console.ReadKey();        
        }

        /// <summary>
        /// Esta funcion se encargar de Registrar los residenciales 
        /// utilizando la clase residenciales.
        /// </summary>
        public static void Registrar()
        {
            int Monto = 0;
            bool validador = true;
            while (validador)
            {
                Console.Clear();

                Console.WriteLine("\t---Registro---\n");

                Console.WriteLine("Ingrese el nombre del residencial: ");
                NombreResidencial = Console.ReadLine();

                Console.WriteLine("Ingrese la Cantidad de Edificios que existen:");
                NResidencial = Console.ReadLine();

                Console.WriteLine("Ingrese el #numero de Apartamentos por edificio: ");
                Apto = Console.ReadLine();

                Console.WriteLine("Ingrese la Mensualidad del Apartamento: ");
                Monto = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nSe le ha asignado un Area comun a su Residencial {0}", NombreResidencial);
                areacomun = "Area Comun " + NombreResidencial;

                if (!Dir.ContainsKey(NombreResidencial))
                    validador = false;
                else
                {   validador = true;
                    Console.WriteLine("\nEste residencial ya existe favor de Registrar Otro\n");
                    Console.ReadKey();
                }
            }
            Residenciales r = new Residenciales(NombreResidencial, NResidencial, Apto, areacomun , Monto);
            residencias.Add(r);
            Dir.Add(NombreResidencial, r);
        }

        /// <summary>
        /// Esta funcion es la que se encargara de cobrar la mensualidad de los apartamentos
        /// </summary>
        public static void RealizarPago()
        {
            if(residencias.Count == 0)
            {
                Console.WriteLine("No se han agregado residenciales todavia\n");
                Console.ReadKey();
                return;
            }

            Console.Clear();

            bool validar = true;

            string Nombre = "";

            Residenciales Residencial;

            Console.WriteLine("\t--Realizar pago\n");
            while (validar)
            {
                Console.WriteLine("Ingrese Nombre de Residencial: ");
                Nombre = Console.ReadLine();

                if (Dir.ContainsKey(Nombre))
                 validar = false;
                else
                {
                    validar = true;
                    Console.WriteLine("Ese Residencial no existe");
                }
            }
            Residencial = Dir[Nombre];
            int total = Convert.ToInt32(Residencial.Edificio);
            int MaxApartment = Convert.ToInt32(Residencial.Apartamento);
            int Pago = Residencial.MontoXApartamento;
            if(Pago == 0)
            {
                Console.WriteLine("Usted no debe nada\n");
                return;
            }

            while (!validar)
            {
                Console.WriteLine("Numero de edificio desde 1 hasta {0}", total);
                int N = Convert.ToInt32(Console.ReadLine());
                if (N > total || N < 0)
                {
                    Console.Clear();
                    Console.WriteLine("\nIngrese un numero de edificio Valido");
                    Console.ReadKey();
                }
                else
                    validar = true;
            }
            while (validar)
            {
                Console.WriteLine("Numero de apartamento desde 1 hasta {0}", MaxApartment);
                int N = Convert.ToInt32(Console.ReadLine());
                if (N > MaxApartment || N < 0)
                {
                    Console.Clear();
                    Console.WriteLine("\nIngrese un numero de apartamento Valido");
                    Console.ReadKey();
                }
                else
                    validar = false;
            }

            int control = 0;
            while (!validar)
            {
                
                Console.WriteLine("\n Deuda Pendiente de {0} : ", Pago);
                Console.WriteLine("Ingrese Monto para pagar mensualidad: ");
                control = Convert.ToInt32(Console.ReadLine());
                if (control < 1 || control > Pago)
                {
                    Console.Clear();
                    Console.WriteLine("\nNo se permite pagos negativos\b" +
                        "Pagos mayor que lo establecido \n" +
                        "O pagos Nulos");
                    Console.ReadKey();
                }
                else
                    validar = true;
            }

            Dir.Remove(Nombre);
            Residencial.MontoXApartamento = Pago - control;
            Dir.Add(Nombre, Residencial);
        }

        /// <summary>
        /// Esta funcion Lista todo los residenciales Existentes
        /// </summary>
        public static void Listar()
        {
            if(residencias.Count == 0)
                Console.WriteLine("No hay Residencial registrado");
            foreach (var read in residencias)
            {
                Console.WriteLine("\t\tResidencial {0}", read.NombreResidencial);
                Console.WriteLine("\tCantidad de Edificios: " + read.Edificio);
                Console.WriteLine("\tApartamento por Edificios: " + read.Apartamento);
                Console.WriteLine("\t"+read.Areacomun);
                Console.WriteLine();
            }    
        }

        /// <summary>
        /// Esta funcion esta relacionada con la clase Quejas la cual se encarga 
        /// de crear quejas a los residenciales.
        /// </summary>
        public static void Quejas()
        {

            if(residencias.Count == 0)
            {
                Console.WriteLine("No se han agregado residenciales favor de agregar");
                return;
            }
            bool validar = true;
            int vrf = 0;
            string nombre = "";
            while (vrf != 2)
            {
                Console.Clear();
                Console.WriteLine("\t\tForo de Quejas\t\n");
                Console.WriteLine("1-Realizar Queja\n" +
               " 2-Mostrar Quejas");

                vrf = Convert.ToInt32(Console.ReadLine());
                switch (vrf)
                {
                    case 1:
                        while (validar)
                        {
                            Console.Clear();
                            Console.WriteLine("Ingresar Nombre del residencial: ");
                            nombre = Console.ReadLine();

                            if (Dir.ContainsKey(nombre))
                            {
                                validar = false;
                                if (QJ.ContainsKey(nombre))
                                { Console.WriteLine("Ya existe una queja para este Residencial Fix it\n");
                                    return;
                                }
                                else
                                    validar = false;
                            }
                            else
                            {
                                Console.WriteLine("Este Residencial no existe\n");
                                return;
                            }

                        }
                        Console.WriteLine("\tEscribir la queja para el residencial {0} : ", nombre);
                        String queja = Console.ReadLine();
                        Quejas data = new Quejas(queja,nombre);
                        QJ.Add(nombre, data);
                        qp.Add(data);
                        break;

                    case 2:
                        foreach (var readd in qp)
                            Console.WriteLine("Nombre del Residencial {0} Queja: {1}",readd.NombredelResidencial,readd.queja);
                        break;
                    default:
                        Console.WriteLine("\nNo digito una opcion validad ");
                        Console.ReadKey();
                        break;
                }

                if (vrf == 1)
                    vrf = 2;
            }
        }
    }

    
}
