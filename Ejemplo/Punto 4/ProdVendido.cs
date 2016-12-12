using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    public class ProdVendido:ProdExport
    {
        public string Cliente;

        public ProdVendido(ProdExport pex, string cliente)
            : base(new ProdImpuesto(pex.Nombre, pex.Stock, pex.Precio), pex.Pais)
        {
            this.Cliente = cliente;
        }
    }
}
