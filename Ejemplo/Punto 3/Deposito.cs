using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    public class Deposito
    {
        public List<Producto> Lista;

        public Deposito()
        {
            this.Lista = new List<Producto>();
        }

        public static Deposito operator +(Deposito A, Producto B)
        {
          
            if (A == B)
            {
                for (int i = 0; i < A.Lista.Count; i++)
                {
                    if (A.Lista[i] == B)
                    {
                        A.Lista[i].Stock = A.Lista[i].Stock + B.Stock;
                    }
                }
            }
            else if (A.Lista.Count() < 3)
            {
                A.Lista.Add(B);
            }
            else
            {
                Console.WriteLine("No se pueden agregar mas productos");
            }
            return A;
        }

        public static bool operator ==(Deposito A, Producto B)
        {
            foreach (Producto item in A.Lista)
            {
                if (item == B)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Deposito A, Producto B)
        {
            foreach (Producto item in A.Lista)
            {
                if (item != B)
                {
                    return true;
                }
            }
            return false;
        }

        public static List<Producto> operator +(Deposito A, Deposito B)
        {
            foreach (Producto item in B.Lista)
            {
                if (A == item)
                {
                    for (int i = 0; i < A.Lista.Count(); i++)
                    {
                        if (A.Lista[i] == item)
                        {
                            A.Lista[i].Stock = A.Lista[i].Stock + item.Stock;
                        }
                    }
                } 
                else
                {
                    A.Lista.Add(item);
                }
            }
            return A.Lista;     
        }
    }
}
