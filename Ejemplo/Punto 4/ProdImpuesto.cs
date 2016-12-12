using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Punto_3;

namespace Punto_4
{
    public class ProdImpuesto:Producto
    {
        public double Precio;
        public ProdImpuesto(string nombre,int stock,double precio):base(nombre,stock)
        {
            this.Precio = precio;
        }
    }
}
