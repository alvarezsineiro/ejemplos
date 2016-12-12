using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    public class ProdExport:ProdImpuesto
    {
        public string Pais;

        public ProdExport(ProdImpuesto pi, string pais)
            : base(pi.Nombre, pi.Stock, pi.Precio)
        {
            this.Pais = pais;
        }
    }
}
