using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int Mayor;
            string Dato;
            
            Console.WriteLine("Hola Mundo");
            
            Mayor = Comparadora.RetornarMayor(10, 5);

            Sello.Mensaje = "Mi nombre es roman floris";           
            Sello.Color = ConsoleColor.Blue;



            Sello.ImprimirEnColor();
            Console.ReadLine();





        }
    }
}
