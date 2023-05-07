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
            /*
             * 4 Pilares de la programacion OO
             * Herencia
             * Encapsulamiento
             * Abstraccion
             * Polimorfismo
             * */

            // Solo se puede heredar de una unica clase.
            // PEro existe la herencia multinivel o jerarquica. (En interfaces si es posible)


            EmpleadoTiempoCompleto empleadoTiempoCompleto = new EmpleadoTiempoCompleto();
            empleadoTiempoCompleto.Nombre = "Ali";
            empleadoTiempoCompleto.Apellido = "Cruz";
            empleadoTiempoCompleto.SalarioAnual = 1f;            
            empleadoTiempoCompleto.ImprimirNombreCompleto();
            Console.WriteLine($"Salario Anual: {empleadoTiempoCompleto.SalarioAnual}.");


            EmpleadoTiempoParcial empleadoTiempoParcial = new EmpleadoTiempoParcial();
            empleadoTiempoParcial.Nombre = "Sara";
            empleadoTiempoParcial.Apellido = "D";
            empleadoTiempoParcial.PagoPorHora = 3f;            
            empleadoTiempoParcial.ImprimirNombreCompleto();
            Console.WriteLine($"Pago por hora: {empleadoTiempoParcial.PagoPorHora}.");

            // Herencia Multinivel
            ClaseExtra claseExtra = new ClaseExtra();
            claseExtra.Nombre = "Herencia jerarquica o multinivel";


            // Primero se crea la clase base y posteriormente la clase derivada
            // Primero se llama al constructor de la clase Base y Despues a la clase derivada.
            ClaseDerivada claseDerivada = new ClaseDerivada();


            // ****************************************************************************************//
            // Ocultamiento de métodos Video 22
            EmpleadoTiempoCompleto empleadoTiempoCompleto2 = new EmpleadoTiempoCompleto();
            empleadoTiempoCompleto2.Nombre = "Homero";
            empleadoTiempoCompleto2.Apellido = "Simpson";
            empleadoTiempoCompleto2.ImprimirNombreCompleto();

            EmpleadoTiempoParcial empleadoTiempoParcial2 = new EmpleadoTiempoParcial();
            empleadoTiempoParcial2.Nombre = "Ned";
            empleadoTiempoParcial2.Apellido = "Flanders";
            empleadoTiempoParcial2.ImprimirNombreCompleto();
            // Llamamos al método oculto. Cast Operator
            ((Empleado)empleadoTiempoParcial2).ImprimirNombreCompleto();

            // Otra forma de llamar al método oculto de la clase base (ImprimirNombreCompleto)
            Empleado empParcial = new EmpleadoTiempoParcial();
            empParcial.Nombre = "Empleado Parcial 1 Usando el método de clase base";
            empParcial.Apellido = "apellido1";
            empParcial.ImprimirNombreCompleto();



            Console.ReadLine();

        }
    }
}
