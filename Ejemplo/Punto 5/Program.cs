using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Galpon<int> ejemplo = new Galpon<int>();
                ejemplo.EsImpar += ejemplo_EsImpar;
                ejemplo.Cantidad = 3;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        static void ejemplo_EsImpar(object objeto, EventArgs evento)
        {
            using (StreamWriter writer = new StreamWriter("log.txt", false))
            {
                writer.Write(DateTime.Today.ToString()+"   Valor: " + objeto);
                writer.Close();
            }
        }

    }
}
