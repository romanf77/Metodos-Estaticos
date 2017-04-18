using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    /// <summary>
    /// En esta clase realizaremos la practica sobre
    /// el concepto de propiedades
    /// </summary>
    public class Aula
    {
        private List<Entidades.Alumno> ListaAlumnos;
        private int _Capacidad;
        private string _Profesor;
        private int _Numero;

        public Aula()
        {
            this.ListaAlumnos = new List<Entidades.Alumno>();       
        }

        public int NumeroLegajo
        {
            set 
            {
                bool esta = false;

                if (value > 0)
                {
                    foreach (Entidades.Alumno auxAlumno in this.ListaAlumnos)
                    {
                        if (auxAlumno == value)
                        {

                            esta = true;

                        
                        }
                      
                    
                    
                    }
                    if (!esta)
                    {

                        this.ListaAlumnos.Add(new Entidades.Alumno("n", "n", value));

                    }
                
                }
            
            
            
            
            }
        
        
        
        }
     

        /// <summary>
        /// asigna o retorna el valor de profesor
        /// </summary>
        public string Profesor
        {          
            get { return this._Profesor; }
            set { this._Profesor = value; }        
        }

        public int Numero
        {
            get { return this._Numero; }
        }


       /*Forma Con metodos
        public int GetterCapacidad()
        {
            return this._Capacidad;

        }
        public void SetterCapacidad(int Dato)
        {
            this._Capacidad=Dato;
        }*/
    

    }
}
