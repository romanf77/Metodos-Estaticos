using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList miArray;

            miArray = new ArrayList(2);

            Producto miProducto;
            
            miProducto = new Producto();

            miArray.Add(miProducto);

            miArray.Add(3);
                     
            foreach (Producto item in miArray)
            {
                //item.Mostrar(); Esto genera error al no ser todos del mismo tipo              
            }

            Stack Pila = new Stack();

            Pila.Push(1);

            Pila.Pop();

            Pila.Peek();

            Queue Cola = new Queue();

            Cola.Peek();

            Cola.Dequeue();

            Cola.Enqueue(1);










            

            
           

        }
    }
}
