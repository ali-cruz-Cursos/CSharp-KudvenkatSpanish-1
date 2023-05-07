using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ventajas
             * Son fuertemente tipados
             * 
             * Desventajas
             * Tamaño fijo una ves definido
             */
            
            int i = 10;
            int[] numerosPares = new int[3];
            numerosPares[0] = 0;
            numerosPares[1] = 2;
            numerosPares[2] = 4;

            Console.WriteLine($"Primer numero par {numerosPares[0]} Segundo par: {numerosPares[1]} tercero {numerosPares[2]}");

            ///
            

            Console.ReadLine();

        }
    }
}


public class ClaseDeEjemplo
{

}