using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class ClaseBase
    {
        public ClaseBase()
        {
            Console.WriteLine("Llamada al constructor de la Clase Base"); ;
        }

        public ClaseBase(string msg)
        {
            Console.WriteLine($"Mensaje: {msg}");
        }
    }
}
