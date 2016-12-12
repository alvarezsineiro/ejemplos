using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Punto_1;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Punto_4;
using Punto_3;

namespace Punto_5
{
    public class Galpon<T>:IEnumerable<T>,IGuardarXML
    {
        private int _cantidad;
        public List<T> Lista;


        public delegate void EventoGalpon(Object objeto, EventArgs evento);

        public event EventoGalpon EsImpar;

        public Galpon()
        {      
            Lista=new List<T>();
        }
        
        
        public int Cantidad
        {
            set
            {
                if (value==0)
                {
                    throw new ArgumentException("El valor que se quiere asignar es 0");
                }
                if (value.EsPar())
                {
                    this._cantidad = value;
                }
                if (value.EsImpar())
                {
                    EsImpar(value,null);
                    this._cantidad = value;
                }
               
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool SerializarXML()
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("archivo.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Galpon<Deposito>));
                    serializador.Serialize(escritor, this);
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
        }
    }
}
