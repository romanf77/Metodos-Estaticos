using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noGenerics
{
    public class Producto
    {
        public int Codigo;
        public string Descripcion;

        public Producto()
        { 
        
        }


        public Producto(string Descripcion)
        {
            this.Descripcion = Descripcion;
               
        }

        public void Mostrar()
        {
            Console.WriteLine(this.Codigo);
            Console.WriteLine(this.Descripcion);
        
        }
    }
}
