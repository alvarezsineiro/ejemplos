using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Punto_5;
using Punto_3;
using Punto_4;

namespace Punto_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Galpon<Deposito> migalpon =new Galpon<Deposito>();
            Producto pro = new Producto("Pala", 22);
            ProdImpuesto pI = new ProdImpuesto(pro.Nombre, pro.Stock, 600.33);
            ProdExport pEX = new ProdExport(pI, "Argentina");
            ProdVendido p = new ProdVendido(pEX, "Cliente Juan");

            Deposito mideposito = new Deposito();
            mideposito= mideposito+pro;
            mideposito = mideposito + pI;
            mideposito = mideposito + pEX;
            mideposito = mideposito + p;

            migalpon.Lista.Add(mideposito);

            migalpon.SerializarXML();
           
            Console.ReadKey();
        }
    }
}
