using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAula
{
    public class Alumno
    {
        private int _Legajo;
        public int Legajo
        {
            get { return this._Legajo; }
            set { this._Legajo = value; }
        }
        
        private string _Nombre;
        public string Nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value;}               
        }
        
        private SexoEnum _Sexo;
        public SexoEnum Sexo 
        {
            get { return this._Sexo; }
            set { this.Sexo = value;}             
        }

        public Alumno(int Legajo, string Nombre, SexoEnum Sexo)
        {
            
            this._Legajo = Legajo;
            this._Nombre = Nombre;
            this._Sexo = Sexo;
                    
        }
       
    }
}
