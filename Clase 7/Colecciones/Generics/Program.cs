using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int Contador = 0;

            List<int> miListaEntero = new List<int>();
            List<string> miListaString = new List<string>();
            List<noGenerics.Producto> miListaProductos = new List<noGenerics.Producto>();

            miListaEntero.Add(56);
            
            Stack<noGenerics.Producto> miPila = new Stack<noGenerics.Producto>();

            for (Contador = 0; Contador < 20; Contador++)
            {
                miPila.Push(new noGenerics.Producto("Producto Nº"+Contador));

                
            }
 










        }
    }
}
