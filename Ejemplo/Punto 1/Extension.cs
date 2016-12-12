using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    public static class Extension
    {
        public static bool EsPar(this Int32 variable)
        {
            if ((variable%2)==0)
	        {
                return true;
	        }
            return false;
        }

        public static bool EsImpar(this Int32 variable)
        {
            return !(variable.EsPar());
        }
    }
}
