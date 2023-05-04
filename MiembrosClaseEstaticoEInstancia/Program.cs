using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiembrosClaseEstaticoEInstancia
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(5);  // Se esta reservando memoria para _pi
            float area = circulo.CalcularArea();

            Console.WriteLine($"El area del circulo es: {area}");

            Circulo circulo2 = new Circulo(6); // Se esta reservando memoria para _pi
            float area2 = circulo2.CalcularArea();

            Console.WriteLine($"El area del circulo2 es: {area2}");

            // Llamo a un miembro estatico
            // No cambian entre las diferentes instancias
            Circulo.ImprimirArea();


            Console.ReadLine();
        }
    }

    class Circulo
    {
        static float _pi;
        int _radio; // Es campo de instancia

        public Circulo(int radio) // Constructor de instancia
        {
            Console.WriteLine("Constructor de instancia.\n");
            _radio = radio;
        }

        // public static Circulo() // No se permiten modificadores de acceso
        static Circulo()
        {
            Console.WriteLine("Constructor estatico.\n");
            _pi = 3.1416f;
        }

        public static void ImprimirArea()
        {
            //
        }

        public float CalcularArea()
        {
            return Circulo._pi * (_radio * _radio);
        }


    }
}
