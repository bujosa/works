/*
 * Puntos del ejercicio: 13 + 2 extras
 *
 * Acabas de fundar un nuevo start-up llamado hUBER para proveer servicio de
 * taxi usando carros autonomos (self-driving cars). Como esos carros son caros
 * y tu empresa aun es joven, decides comprar solamente dos vehiculos.
 *
 * Como el trafico en la ciudad es caotica y las autoridades no confian en el
 * funcionamiento de esos vehiculos autonomos, tu licencia te limita a operar
 * en una de las avenidas lejos del eje central de la ciudad. Esa avenida es
 * bidireccional, empieza en el kilometro 0 y se extiende en una sola dimension
 * hasta el infinito.  Tus dos carros comienzan el dia estacionados en el garage
 * de tu empresa, el cual se localiza en el kilometro 'headquarterPos'.
 *
 * El tiempo que toma un vehiculo de llegar de el kilometro X al kilometro Y
 * es la cantidad de kilometros entre las dos posiciones.  Es decir, asume que
 * la velocidad de tus vehiculos es constante de 1 Km por minuto y aceleran de
 * manera instantanea!. Matematicamente, la distancia entre las posiciones X y Y
 * es |X - Y| (donde la barra indica valor absoluto).
 *
 * Para cada viaje, calculas la tarifa de la siguiente manera:
 *   1) Tienes un cargo fijo de 'flatFee' pesos
 *   2) Los primeros 'flatFeeThreshold' kilometros del viaje estan cubiertos por
 *      ese cargo fijo: si tu ride no excede 'flatFeeThreshold' kilometros, el
 *      cliente solamente paga el flat fee.
 *   3) A partir de ahi, el costo es de 'costPerAdditionalKm' por kilometro
 *      adicional recorrido
 *   4) El "millero" empieza a contar a partir de que el pasajero se monte en el
 *      vehiculo y se detiene cuando el pasajero de desmonte en su destino
 *
 * Al final del dia, revisas la bitacora de todas las solicitudes de servicio
 * que recibiste durante el dia.  Cada solicitud tiene registrado los siguientes
 * campos (ver la clase RideRequest):
 *   # 'time': la hora en que el cliente solicito el servicio, medido en minutos
 *             desde el inicio del dia. Puedes asumir que la bitacora esta
 *             ordenada cronologicamente por este campo
 *   # 'start': posicion donde debes recoger el pasajero, medido en unidades de
 *              kilometros desde el kilometro 0
 *   # 'end': posicion destino del viaje, tambien medido desde el kilometro 0
 *
 * Basado en esa bitacora, tu quieres determinar cual es la maxima ganancia que
 * pudiste haber obtenido, siguiendo las siguientes reglas:
 *   a) Tienes la opcion de servir o ignorar cada solicitud de servicio
 *   b) Cada cliente es impaciente y no esta dispuesto a esperar ningun minuto:
 *      si el vehiculo llega a recogerlo 1 minuto despues de haber solicitado
 *      el taxi, ese cliente rechaza el servicio. Si llegas antes o justamente
 *      en el minuto que solicito el servicio, el cliente acepta el servicio
 *   c) Asume que el tiempo que el pasajero se toma para montar y desmontarse
 *      del vehiculo es instantaneo (0 minutos)
 *   d) No se permite desmontar el pasajero antes de llegar a su destino!
 *   e) No se permite ride sharing (varios pasajeros compartiendo el mismo
 *      viaje)
 *   f) Es obvio que mas de un vehiculo no puede aceptar la misma solicitud
 *   g) Una vez que llega al destino y el pasajero se desmonta, el vehiculo se
 *      puede quedar estacionado en el mismo punto destino o ir a otra posicion
 *      (a la velocidad de 1 km/min)
 *
 * Ubica todas las secciones con el tag TODO.  Cada tag les indicara que deben
 * completar.  Para TODOs que requieren respuestas, escribe las respuestas en
 * un comment.
 *
 * Puedes agregar todos los metodos y atributos que desees, pero no debes
 * alterar la firma del metodo Solve.
 * 
 */
using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

// Definicion de una solicitud de tax
public class RideRequest
{
    public int id;
    public int time;        // hora en minutos en que pidieron este ride
    public int start, end;  // posicion de origen y destino del ride
}

// Esta clase abstract define el metodo Solve que debes implementar.  Esto es
// para facilitar la correccion de esta tarea

public abstract class ATaxiRideService
{
    // OJO: tu solucion debe llenar estas dos propiedades:

    public long MaxEarning { get; protected set; } // ganancia optima

    public List<RideRequest>[] AssignedRides { get; protected set; } // Esto se Llena en Assigned Funcion.

    // Este es el metodo que debes implementar
    public abstract void Solve(
        int headquarterPos,
        int flatFee,
        int flatFeeThreshold,
        int costPerAdditionalKm,
        RideRequest[] requests
    );
}

public class MyTaxiRideService : ATaxiRideService
{

    public long flatFee;
    public long flatFeeThreshold;
    public long costPerAdditionalKm;
    public long headquarterPos;
    public RideRequest[] DataBases; // Para hacer Referencia al Request y no pasarlo a la funcion.

    // Memoria
    public long[,,] Memorization;

    // Cached
    public bool[,,] Cached;

    // Tracker
    public int[,,] Tracker;

    public override void Solve(
        int headquarterPos,
        int flatFee,
        int flatFeeThreshold,
        int costPerAdditionalKm,
        RideRequest[] requests
    )
    {
        // TODO: implementa un algoritmo basado en Dynamic Programming para
        //       calcular la maxima ganancia de hUBER segun la bitacora de
        //       solicitudes grabados en el arreglo 'requests'.  Llena la
        //       propiedad MaxEarnings
        // Complejidad esperada: no exponencial
        // Valor: 8 puntos
        //        +2 puntos extras si tu algoritmo NO es pseudopolinomial (Ready)
        // Answer: Es polinomial no depende de Ninguna Magnitud externa a N


        // TODO: describe la estructura de los subproblemas en tu solucion con
        //       Dynamic Programming: cuales son los parametros de tu DP y que
        //       significan?
        // Valor: 1 punto (En la funcion F esta definido Todo) (Ready)


        // TODO: modifica tu algoritmo para que tambien recupere la asignacion
        //       optima de solicitudes a vehiculo.  Llena la propiedad 
        //       AssignedRides
        // Valor: 3 puntos (READY)


        // TODO: determina la complejidad de tu algoritmo
        // Valor: 1 punto (READY)
        //
        // Answer: O(N^3) Polinomial | Es polinomial porque mi Memu and Cached 
        // No dependen de ninguna Magnitud externa a N. Y la recursion se ejecuta
        // N veces debido a mi Momorization.

        this.DataBases = requests;
        this.flatFee = flatFee;
        this.flatFeeThreshold = flatFeeThreshold;
        this.costPerAdditionalKm = costPerAdditionalKm;
        this.headquarterPos = headquarterPos;

        Memorization = new long[requests.Length + 1, requests.Length + 1, requests.Length + 1];
        Tracker = new int[requests.Length + 1, requests.Length + 1, requests.Length + 1];
        Cached = new bool[requests.Length + 1, requests.Length + 1, requests.Length + 1];

        MaxEarning = F(0, 0, 0);
        Assigned();
    }

    // ESTA FUNCION ES LO QUE HACE POSIBLE MOSTRAR A 
    // Quienes cogio el carro 1 y carro 2 y llena las 
    // Propiedades AssignedRides

    void Assigned()
    {
        AssignedRides = new List<RideRequest>[2];
        AssignedRides[0] = new List<RideRequest>();
        AssignedRides[1] = new List<RideRequest>();

        long CarOne = 0, CarTwo = 0, x = 0;

        // Esta Parte sirve para sacar mi Tracker que tomo mi 
        // Funcion de recursividad.

        while (x < DataBases.Length)
        {

            if (Tracker[x, CarOne, CarTwo] == 1)
            {
                AssignedRides[0].Add(DataBases[x]);
                CarOne = x;
            }
            else if (Tracker[x, CarOne, CarTwo] == 2)
            {
                AssignedRides[1].Add(DataBases[x]);
                CarTwo = x;
            }
            x++;
        }
    }

    // F(N,CarOne, CarTwo): Tiene como objetivo buscar
    // Las maximas ganacias que puede tener la compañia
    // hUber segun la bitacora que le fue mandada 
    // con los dos vehiculos Autonomos que tiene la empresa ademas de eso.
    // Esta funcion sus variables hace lo siguiente:

    /// <summary>
    /// 
    /// </summary>
    /// <param name="N"> La variable N lo que hace  es mostrar 
    /// la posicion que tiene en el arreglo de RideRequest[] </param>
    /// <param name="CarOne"> Esta variable muestra la ultima posicion
    /// En donde se encuentra el carro 1 estacionado por ultima vez</param>
    /// <param name="CarTwo">Esta variable muestra la ultima posicion
    /// En donde se encuentra el carro 1 estacionado por ultima vez </param>
    /// <returns></returns>

    // Ademas se calcula internamente en la funcion X1 T1 donde son los tiempo
    // y distancia respectivamente del Carro 1.
    // X2 Y T2 son la distancia y el tiempo en que se encuentra el Carro 2 de
    // La compañia hUber.

    long F(int N, int CarOne, int CarTwo)
    {

        if (N == DataBases.Length) // Base Case
            return 0;

        if (Cached[N, CarOne, CarTwo]) // Devuelve lo que esta en memoria si es True
            return Memorization[N, CarOne, CarTwo];

        long X1, X2, T1, T2; // VARIABLES DE CALCULO DE DISTANCIA Y TIEMPO DE LOS DOS VEHICULOS

        // Este bloque de Codigo es donde Asigno X1, X2, T1 y T2 respectivamente.
        if (CarOne == 0) // Asignacion de X1 Y T1 al Carro 1
        {
            X1 = this.headquarterPos;
            T1 = 0;
        }
        else
        {
            X1 = DataBases[CarOne].end;
            T1 = DataBases[CarOne].time + Math.Abs(DataBases[CarOne].end - DataBases[CarOne].start);
        }

        if (CarTwo == 0) // Asignacion de X2 Y T2 al Carro 1
        {
            X2 = this.headquarterPos;
            T2 = 0;
        }
        else
        {
            X2 = DataBases[CarTwo].end;
            T2 = DataBases[CarTwo].time + Math.Abs(DataBases[CarTwo].end - DataBases[CarTwo].start);
        }

        // Fin de Asignaciones.

        long res1 = 0, res2 = 0, res3 = 0, res = 0; // Variables de Resultados Para las deciciones

        long Fee = rate(DataBases[N]); // Calculo de tarifa y asignacion a Fee

        // ESTA PARTE ES DONDE SE DECIDE NO/CarOne/CarTwo para los Request

        // Case 1: Don't Take Request
        res1 = F(N + 1, CarOne, CarTwo);

        // Case 2: Acepar la Solicitud con CarOne and Refresh Position in Array
        if (Math.Abs(X1 - DataBases[N].start) + T1 <= DataBases[N].time)
            res2 = F(N + 1, N, CarTwo) + Fee;

        // Case 3: Aceptar La solicitud con CarTwo and Refresh Position in Array
        if (Math.Abs(X2 - DataBases[N].start) + T2 <= DataBases[N].time)
            res3 = F(N + 1, CarOne, N) + Fee;

        // Fin de Bloque de Codigo.

        res = Math.Max(res1, Math.Max(res2, res3));

        Tracker[N, CarOne, CarTwo] = Choice(res, res1, res2, res3);
        Cached[N, CarOne, CarTwo] = true;
        Memorization[N, CarOne, CarTwo] = res;

        return res; // Complejida de mi Algoritmo es O(N^3) Polinomial
    }

    // Choices
    private int Choice(long res, long res1, long res2, long res3)
    {
        if (res1 == res)
            return 0;  // Don't Take Request
        if (res2 == res)
            return 1; // Aceptar solicitud CarOne
        if (res3 == res)
            return 2; // Aceptar solicitud CarTwo
        return 0;
    }

    // Funcion Para calcular Tarifa para el Pasajero
    private long rate(RideRequest rideRequest)
    {
        long X = this.flatFee;

        long distance = Math.Abs(rideRequest.end - rideRequest.start);

        if (distance > this.flatFeeThreshold)
        {
            distance = distance - this.flatFeeThreshold;
            X += distance * this.costPerAdditionalKm;
        }
        return X;
    }
}

class Lab3u
{

    public static void Main(string[] args)
    {

        string filename = @"input1.txt";

        int headquarterPos, flatFee, flatFeeThreshold, costPerAdditionalKm;
        RideRequest[] requests;

        ReadTestFromFile(filename,
                         out headquarterPos,
                         out flatFee,
                         out flatFeeThreshold,
                         out costPerAdditionalKm,
                         out requests);

        ATaxiRideService s = new MyTaxiRideService();

        s.Solve(headquarterPos, flatFee, flatFeeThreshold, costPerAdditionalKm,
                requests);

        Console.WriteLine("Ganancia optima es ${0}", s.MaxEarning);

        if (s.AssignedRides != null)
        {
            for (int j = 0; j < s.AssignedRides.Length; j++)
            {
                Console.Write("Solicitudes asignadas a vehiculo {0}: ", j);
                foreach (RideRequest r in s.AssignedRides[j])
                {
                    Console.Write(" {0}", r.id);
                }
                Console.WriteLine();
            }
        }
        Console.ReadKey();
    }

    static void ReadTestFromFile(string filename,
                                 out int headquarterPos,
                                 out int flatFee,
                                 out int flatFeeThreshold,
                                 out int costPerAdditionalKm,
                                 out RideRequest[] requests)
    {
        headquarterPos = 0;
        flatFee = 0;
        flatFeeThreshold = 0;
        costPerAdditionalKm = 0;
        requests = new RideRequest[0];

        var fileStream = new FileStream(filename,
                                        FileMode.Open, FileAccess.Read);
        using (var streamReader = new StreamReader(fileStream))
        {
            char[] blanks = { ' ' };
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == null)
                    throw new Exception("Input file ended prematurely");
                line = line.Trim();
                if (line.Length == 0 || line[0] == '#')
                    continue;
                string[] tokens
                    = line.Split(blanks, 4,
                                 StringSplitOptions.RemoveEmptyEntries);
                headquarterPos = (int)uint.Parse(tokens[0]);
                flatFee = (int)uint.Parse(tokens[1]);
                flatFeeThreshold = (int)uint.Parse(tokens[2]);
                costPerAdditionalKm = (int)uint.Parse(tokens[3]);
                break;
            }

            List<RideRequest> requestList = new List<RideRequest>();
            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == null)
                    throw new Exception("Input file ended prematurely");
                line = line.Trim();
                if (line.Length == 0 || line[0] == '#')
                    continue;
                string[] tokens
                    = line.Split(blanks, 3,
                                 StringSplitOptions.RemoveEmptyEntries);
                RideRequest r = new RideRequest()
                {
                    id = requestList.Count + 1,
                    time = (int)uint.Parse(tokens[0]),
                    start = (int)uint.Parse(tokens[1]),
                    end = (int)uint.Parse(tokens[2])
                };
                if (requestList.Count > 0)
                    if (requestList[requestList.Count - 1].time > r.time)
                        throw new Exception("Bitacora no esta ordenada cronologicamente");
                requestList.Add(r);
            }
            requests = requestList.ToArray();
        }
    }

}

/*
Mi resultado para el ejemplo:
Ganancia optima es $1328
Solicitudes asignadas a vehiculo 0:  1 3 6 10 13 16
Solicitudes asignadas a vehiculo 1:  2 8 12 17
*/

/*
Solicitud #1 asignada a vehiculo 0
  Minuto 0: parte desde km 10
  Minuto 5: llega a km 5
  Minuto 75: recoge pasajero de solicitud #1 en km 5
  Minuto 79: llega a km 9 y desmonta pasajero de la solicitud #1
  Tarifa de viaje: 50

Solicitud 2 asignada a vehiculo 1
  Minuto 0: parte desde km 10
  Minuto 20: llega a km 30
  Minuto 90: recoge pasajero de solicitud #2 en km 30
  Minuto 102: llega a km 18 y desmonta pasajero de la solicitud #2
  Tarifa de viaje: 92

Solicitud #3 asignada a vehiculo 0
  Minuto 79: parte desde km 9
  Minuto 85: llega a km 15
  Minuto 100: recoge pasajero de solicitud #3 en km 15
  Minuto 110: llega a km 25 y desmonta pasajero de la solicitud #3
  Tarifa de viaje: 80

Solicitud #6 asignada a vehiculo 0
  Minuto 110: parte desde km 25
  Minuto 128: llega a km 7
  Minuto 132: recoge pasajero de solicitud #6 en km 7
  Minuto 154: llega a km 29 y desmonta pasajero de la solicitud #6
  Tarifa de viaje: 152

Solicitud 8 asignada a vehiculo 1
  Minuto 102: parte desde km 18
  Minuto 136: llega a km 52
  Minuto 150: recoge pasajero de solicitud #8 en km 52
  Minuto 171: llega a km 31 y desmonta pasajero de la solicitud #8
  Tarifa de viaje: 146

Solicitud #10 asignada a vehiculo 0
  Minuto 154: parte desde km 29
  Minuto 158: llega a km 25
  Minuto 177: recoge pasajero de solicitud #10 en km 25
  Minuto 192: llega a km 10 y desmonta pasajero de la solicitud #10
  Tarifa de viaje: 110

Solicitud 12 asignada a vehiculo 1
  Minuto 171: parte desde km 31
  Minuto 190: llega a km 50
  Minuto 200: recoge pasajero de solicitud #12 en km 50
  Minuto 230: llega a km 20 y desmonta pasajero de la solicitud #12
  Tarifa de viaje: 200

Solicitud #13 asignada a vehiculo 0
  Minuto 192: parte desde km 10
  Minuto 207: llega a km 25
  Minuto 209: recoge pasajero de solicitud #13 en km 25
  Minuto 224: llega a km 10 y desmonta pasajero de la solicitud #13
  Tarifa de viaje: 110

Solicitud #16 asignada a vehiculo 0
  Minuto 224: parte desde km 10
  Minuto 256: llega a km 42
  Minuto 260: recoge pasajero de solicitud #16 en km 42
  Minuto 289: llega a km 13 y desmonta pasajero de la solicitud #16
  Tarifa de viaje: 194

Solicitud 17 asignada a vehiculo 1
  Minuto 230: parte desde km 20
  Minuto 252: llega a km 42
  Minuto 260: recoge pasajero de solicitud #17 en km 42
  Minuto 289: llega a km 13 y desmonta pasajero de la solicitud #17
  Tarifa de viaje: 194

*/
