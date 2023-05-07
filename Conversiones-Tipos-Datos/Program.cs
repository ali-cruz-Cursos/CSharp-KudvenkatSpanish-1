using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones_Tipos_Datos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            // Conversion implicita
            float f = i;
            Console.WriteLine(f);

            float ff = 123.45f;
            float f3 = ff;
            int ii = (int)ff; // Operador de casteo...
            int i3 = Convert.ToInt32(ff);

            float f4 = 125412515248558485.45f;
            int if4 = (int)f4;
            // int if4_1 = Convert.ToInt32(f4); // La clase convert si data un error de desbordamiento


            string stringNumero = "100Cien";
            // int tstring = stringNumero; // Da error

            //int intString = int.Parse(stringNumero);
            bool convertido = int.TryParse(stringNumero, out int resultado);

            if (convertido)
            {
                Console.WriteLine(resultado);
            } else
            {
                Console.WriteLine("No se pudo convertir.");
            }


            Console.WriteLine($"Resultado: {stringNumero} resultado {resultado}");
            Console.ReadLine();
        }
    }
}
