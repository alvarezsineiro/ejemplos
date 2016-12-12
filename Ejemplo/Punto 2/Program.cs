using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<double> pila = new Stack<double>();
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);

            Queue<double> cola = new Queue<double>();

            foreach (double item in pila)
            {
                cola.Enqueue(item);
            }

            foreach (double item in cola)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
