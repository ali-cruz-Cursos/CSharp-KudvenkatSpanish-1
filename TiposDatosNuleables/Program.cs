using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDatosNuleables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Value types: int, float, double, structs, enums, etc. 
             *  Los value types por default son NO NULEABLES (usar ?)
             *  
             * Reference Types: Interfaces, Class, delegates, arrays, etc.
             */
            string nombre = null;
            //int i = null; // No se puede convertir null a int. (No es de referencia)
            int? i = null; //ahora es nulable
            bool? esMayor = null;

            if (esMayor == true)
            {
                Console.WriteLine("Es Mayor");
            } else if (esMayor == false)
            {
                Console.WriteLine("No es mayor.");
            } else
            {
                Console.WriteLine("Es null");
            }

            Console.WriteLine("\n\nBoletos camino largo\n");

            int? boletosEnVenta = 100;
            int boletosDisponibles;

            if (boletosEnVenta == null)
            {
                boletosDisponibles = 0;
            } else
            {
                boletosDisponibles = boletosEnVenta.Value;
                //boletosDisponibles = (int)boletosEnVenta; // casting forzado.
            }

            Console.WriteLine($"Boletos disponibles {boletosDisponibles}\n");

            Console.WriteLine("\n\nBoletos camino corto (NULL COALEASCING ??, operador de uso combinado)\n");

            int? boletosEnVenta1 = 100;
            int boletosDisponibles1 = boletosEnVenta1 ?? 0;



            Console.WriteLine($"Boletos disponibles {boletosDisponibles1}");




            Console.ReadLine();
        }
    }
}
