using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Clase.excepcionestatica();
            }
            catch (MiExcepcion e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
