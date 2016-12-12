using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto miproducto1 = new Producto("galletas", 2);
            Producto miproducto2 = new Producto("gaseosa", 2);
            Producto miproducto3 = new Producto("pan", 2);
            Producto miproducto4 = new Producto("carne", 2);

            Deposito mideposito1 = new Deposito();
            Deposito mideposito2 = new Deposito();

            mideposito1 = mideposito1 + miproducto1;
            mideposito1 = mideposito1 + miproducto2;
            mideposito1 = mideposito1 + miproducto3;
            mideposito1 = mideposito1 + miproducto4;

            mideposito2 = mideposito2 + miproducto1;
            mideposito2 = mideposito2 + miproducto1;
            mideposito2 = mideposito2 + miproducto4;
            mideposito2 = mideposito2 + miproducto2;

            List<Producto> Productos =mideposito1 + mideposito2;

            foreach (Producto item in Productos)
            {
                Console.WriteLine(item.Nombre);
                Console.WriteLine(item.Stock);
            }

            Console.ReadKey();
        }
    }
}
