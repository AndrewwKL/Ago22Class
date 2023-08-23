using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ago22Class
{
    internal class Letras
    {
        public static void CambiarLetras(string first,string second) {
            string nowB = first;
            string nowA = second;
            Console.WriteLine("Ingresaste el valor " + first + " para la primera letra");
            Console.WriteLine("Ingresaste el valor "+second + " para le segunda letra");
            Console.WriteLine("Ahora la primera letra sera: " + nowA + " y la segunda: " + nowB);
        }
    }
}
