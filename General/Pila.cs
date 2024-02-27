using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class Pila<T>
    {
        private List<T> elementos = new List<T>();
        public void Apilar(T element)
        {
            elementos.Add(element);
        }
        public void DesApilar(T element)
        {
            if(elementos.Count > 0)
            {
               T elementosDesapilador = elementos[elementos.Count - 1];

            }
            
        }
    }
}
