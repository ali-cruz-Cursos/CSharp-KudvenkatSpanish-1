using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Empleado
    {
        // Se debería de usar propiedades en lugar de campos publicos.
        public string Nombre;
        public string Apellido;
        public string  Email;

        public void ImprimirNombreCompleto()
        {
            Console.WriteLine($"Nombre Completo: {Nombre} {Apellido}");

        }
    }
}
