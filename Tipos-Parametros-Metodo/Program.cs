using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tipos_Parametros_Metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int i2 = 0;

            MetodoSimple(i); // Se pasa como valor, se pasa una copia
            Console.WriteLine($"i {i}");

            MetodoPorReferencia(ref i2); // Se pasa por referencia.            
            Console.WriteLine($"i2 {i2}");

            int totSum = 0;
            int totMult = 0;

            Calcular(3, 5, out totSum, out totMult);
            Console.WriteLine($"Tot sum {totSum} totMul {totMult}");

            var res = Calcular2(5, 10);

            totSum = res.Item1;
            totMult = res.Item2;
            Console.WriteLine($"Tot sum {totSum} totMul {totMult}");

            int tipoCambio = 19;
            int dolares = 100;
            int pesos = ConvertirAPesos(dolares, in tipoCambio); // tipoCambio se para por referencia

            Console.WriteLine($"Tipo Cambio {tipoCambio} Dolares: {dolares}. Convertido {pesos}");

            int[] arregloNumeros = new int[3] { 101, 102, 103 };

            /* Al usar un arreglo sin la palabra params entonces se vuelve
             * obligatorio el argumento.
             * Si se usa params es opcional el argumento
             */
            MetodoConParams("array", arregloNumeros);

            MetodoConParams("valores separados por coma", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            Console.ReadLine();
        }

        // Se pasa como valor
        public static void MetodoSimple(int j)
        {
            j = 101;
        }


        // Se pasa por referencia
        public static void MetodoPorReferencia(ref int i2)
        {
            i2 = 150;
        }


        public static void Calcular(int x, int y, out int suma, out int multi)
        {
            suma = x + y;
            multi = x * y;
        }

        // Tuplas
        public static (int, int) Calcular2(int x, int y)
        {
            int suma = x + y;
            int mult = x * y;
            return (suma, mult);
        }

        public static int ConvertirAPesos(int dolares, in int tipoCambio)
        {
            //tipoCambio = 25; // Es de solo lectura al usar "in" se pasa por referencia
            return dolares * tipoCambio;
        }


        // params debe ser el último elemento en la lista de parametros y solo puede existir uno solo.
        public static void MetodoConParams(string value, params int[] numeros)
        {
            Console.WriteLine($"Total de elementos en el arreglo: {numeros.Length} (Se pasan como {value})");

            foreach (int num in numeros)
            {
                Console.WriteLine($"Elemento {num}");
            }
        }

    }
}
