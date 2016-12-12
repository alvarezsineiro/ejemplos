using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    public class Producto
    {
        public string Nombre;
        public int Stock;

        public Producto(string nombre, int stock)
        {
            this.Nombre = nombre;
            this.Stock = stock;
        }

        public static bool operator ==(Producto A, Producto B)
        {
            if (A.Nombre==B.Nombre)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Producto A, Producto B)
        {
            if (A.Nombre != B.Nombre)
            {
                return true;
            }
            return false;
        }
    }
}
