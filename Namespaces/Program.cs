using System;
// Alias
//using PAEA = ProyectoA.EquipoA;
//using PAEB = ProyectoA.EquipoB;
using System.Collections;
using ProyectoA.EquipoA;
using AliasProyectoA = ProyectoA.EquipoB;

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oranizar codigo
            /*
             * ProyectoA
             *  EquipoA
             *  EquipoB             *  
             */

            // ProyectoA.EquipoA.ClaseA.Imprimir();
            // Se puede generar ambiguedad si se tiene el mismo nombre de Clase
            // Se arregla definiendo la ruta completa de namespaces o creando alias
            //PAEA.ClaseA.Imprimir();

            //ProyectoA.EquipoB.ClaseA.Imprimir();
            //PAEB.ClaseA.Imprimir();
            AliasProyectoA.ClaseA.Imprimir();

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

// Se agrega a una libreria de clases .net framework
//namespace ProyectoA
//{
//    namespace EquipoA
//    {
//        class ClaseA
//        {
//            public static void Imprimir()
//            {
//                System.Console.WriteLine("Equipo A Clase A metodo Imprimir");
//            }
//        }
//    }
//}


// Se mete a la libreria creada por separado
//namespace ProyectoA
//{
//    namespace EquipoB
//    {
//        class ClaseA
//        {
//            public static void Imprimir()
//            {
//                Console.WriteLine("Equipo B Clase B imprimir");
//            }
//        }

//    }
//}