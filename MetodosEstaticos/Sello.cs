using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Sello
    {
        public static string Mensaje;
        
        public static string Imprimir()
    
        {
                  
        return Mensaje;
        
        }

        public static void Borrar()
        {

            Sello.Mensaje = "";            
        }
   

    }
}
