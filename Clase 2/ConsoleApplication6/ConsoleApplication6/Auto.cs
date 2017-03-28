using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instancia
{
    class Auto
    {
        Rueda RuedaDD;
        Rueda RuedaDI;
        Rueda RuedaTD;
        Rueda RuedaTI;
        eFabricante Fabricante;
        public static int CantidadDeInstancias;


        //Constructores de instancia
        //1. Tienenen el mismo nombre que la clase.
        //2. Pueden tener modificadores de visibilidad(Public,Private,ETC).
        //3. No tienen valor de retorno.
        //4. Pueden tener parametros.
        //5. Se ejecutan al crear una instancia de la clase (Objeto).
        //6. Se puede y debe usarse el operador this.
        //7. Puede acceder a los atributos de instancia 
        //8. Puede acceder a los atributos estaticos.

        public Auto()
        { 
            this.RuedaDD = new Rueda();
            this.RuedaDI = new Rueda();
            this.RuedaTD = new Rueda();
            this.RuedaTI = new Rueda();
            this.Fabricante = eFabricante.Ford;
            Auto.CantidadDeInstancias++;
        ///El fabricante cargado se genere de manera random entre las 3 opciones existentes, probar que halla generado 3 objetos random.//
        /// creo un atributo estatico de tipo random
        /// inisializo el objeto en el constructor estatico
        }
        // Constructor Estatico
        //1. No puede tener modificador de visibilidad//
        //2. No se puede utilizar el operador this.// 
        //3. No puede acceder a atributos de instancia
        static Auto()
        {
            Auto.CantidadDeInstancias = 0;        
        
        }
       
        

        
    
        
    
    
    }
}
