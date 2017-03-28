using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instancia
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Auto Auto1;
            Auto Auto2;
            Auto Auto3;
            Auto Auto4;
            eFabricante Fabricante;                
            
            
            Auto1 = new Auto();
            Auto2 = new Auto();
            Auto3 = new Auto();
            Auto4 = new Auto();
            
            Fabricante = eFabricante.Chevrolet;
            
            //Fabricante = (eFabricante)3; 




            

        }

    }
}
