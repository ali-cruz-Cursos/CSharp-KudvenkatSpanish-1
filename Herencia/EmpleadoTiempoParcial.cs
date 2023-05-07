using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class EmpleadoTiempoParcial: Empleado
    {
        public float PagoPorHora;

        // En este caso que ya existe un método con el mismo nombre en la clase Base entonces
        // Este método de la clase hija sobrepone su propio metodo
        // Se dice que este método esta ocultando al de la clase base.
        // Usando la palabra clave new se especifica que se esta ocultando intencionalmente al método de la clase base.
        public new void ImprimirNombreCompleto()
        {
            Console.WriteLine($"Nombre Completo: {Nombre} {Apellido} - Tiempo Completo");
        }
    }
}
