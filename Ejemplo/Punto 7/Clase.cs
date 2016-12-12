using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_7
{
    public class Clase
    {
        public static void excepcionestatica()
        {
            Clase miclase = new Clase();
            try
            {
                miclase.excepcioninstancia();
            }
            catch (MiExcepcion e)
            {    
                throw e;
            }
        }
        public void excepcioninstancia()
        {
            try
            {
                int.Parse("asd");
            }
            catch (Exception e)
            {
                
                throw new MiExcepcion(e.Message);
            }
        }
    }
}
