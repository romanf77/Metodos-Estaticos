using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    class Alumno
    {
        private int _Legajo;
        private string _Nombre;

        public Alumno(int Legajo)
        { 
            this._Legajo=Legajo;
        
        
        }

        public Alumno(int Legajo, string Nombre): this(Legajo)
        {
            this._Nombre = Nombre;
        
        }

    }
}
