using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Propiedades.Aula MiAula = new Propiedades.Aula();
            string dato;
            MiAula.Profesor = "maxi";
            dato = MiAula.Profesor;
            Console.Write(MiAula.Profesor);

            MiAula.NumeroLegajo = 1;

            

            


           
       
        }


    }
}
