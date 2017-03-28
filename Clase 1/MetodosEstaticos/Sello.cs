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
        public static ConsoleColor Color;
        
        public static string Imprimir()    
        {
                  
            return Sello.armarMensaje();
        
        }

        public static void Borrar()
        {

            Sello.Mensaje = "";            
        }

        public static void ImprimirEnColor()
        {
          
            Console.ForegroundColor = Sello.Color;
           
            Console.WriteLine(Sello.Imprimir());
               
        
        }
        private static string armarMensaje()
        {
            string retorno = "";
            retorno = Sello.Mensaje;
            int Auxiliar=0;
            int Contador=0;
            string AuxiliarFormato="";
            Auxiliar = Sello.Mensaje.Length;

            for (Contador = 0; Contador <= Auxiliar+1; Contador++)
            { 
               

                AuxiliarFormato=AuxiliarFormato+"*";

            
            
            }

            AuxiliarFormato=AuxiliarFormato+"\n*"+retorno+"*\n";

            for (Contador = 0; Contador <= Auxiliar+1; Contador++)
            {


                AuxiliarFormato = AuxiliarFormato + "*";



            }


            retorno = AuxiliarFormato;
            
            

            return retorno;
        }

   

    }
}
