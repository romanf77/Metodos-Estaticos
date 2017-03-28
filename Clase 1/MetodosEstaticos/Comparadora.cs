using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Comparadora
    {
        
        /// <summary>
        ///
        /// </summary>
        /// <param name="Numero1"></param>
        /// <param name="Numero2"></param>
        /// <returns></returns>
        public static int RetornarMayor(int Numero1, int Numero2)
       {
        
        int Retorno=0;

        
        if (Numero1 > Numero2)
            Retorno = Numero1;
        else
            Retorno = Numero2;


        return Retorno;

        
       }

       /// <summary>
       /// Retorna el valor del medio
       /// </summary>
       /// <param name="Numero1">Variable 1, Entero</param>
       /// <param name="Numero2">Variable 2, Enetero</param>
       /// <param name="Nuemero3">Variable 3, Enetero</param>
 
       public static void RetornaElDelMedio(int Numero1, int Numero2, int Nuemero3)
       {



       }



    }
}
