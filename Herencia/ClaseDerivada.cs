using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class ClaseDerivada : ClaseBase
    {
        // Se puede especificar a que constructor llamar con base
        //public ClaseDerivada() : base("Llamada desde clase derivada a constructos especifico de clase base.")
        public ClaseDerivada() : base()
        {
            Console.WriteLine("Constructor de la clase Derivada");
        }
        
    }
}
