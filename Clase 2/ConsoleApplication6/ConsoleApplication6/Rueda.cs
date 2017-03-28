using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instancia

{
    class Rueda
    {

        public string Marca;
        public  int Tamaño;
        //Constructor de Instancia
        public Rueda()
        {
         //1. Cuando es static se usa - Rueda.Marca ="sinmarca";//         
         //2. Cuando no tiene nada no sabemos, pero suele andar Marca = "sinmarca"; MAL PROGRAMADO//                             
         //3. Forma Correcta para atributos de instancia this.//
           
            this.Marca = "Sin Marca";
        
        
        }

        
    
    
    }
}
