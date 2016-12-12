using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 var = new Int32();
            var =int.Parse( Console.ReadLine());
            Console.WriteLine("Es par: "+var.EsPar());
            Console.WriteLine("Es impar: "+var.EsImpar());

            Console.ReadKey();
        }
    }
}
