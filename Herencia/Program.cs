using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Video 21 Herencia
            // Clase Base
            // Clase derivada

            EmpleadoTiempoCompleto empleadoTiempoCompleto = new EmpleadoTiempoCompleto();
            empleadoTiempoCompleto.Nombre = "Ali";
            empleadoTiempoCompleto.Apellido = "Cruz";
            empleadoTiempoCompleto.SalarioAnual = 110_000;
            empleadoTiempoCompleto.ImprimirNombreCompleto();
            Console.WriteLine($"Salario: {empleadoTiempoCompleto.SalarioAnual}.");

            Console.ReadLine();

        }
    }
}
