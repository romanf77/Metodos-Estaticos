using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    class Aula
    {
        private int _NumeroDeAula;
        private List<Alumno> _ListadoDeAlumnos;

        public Aula()
        {
            this._ListadoDeAlumnos = new List<Alumno>();
        
        }

       /* public Alumno this[int Indice]
        {
            get { return this._ListadoDeAlumnos[Indice]; }
            set { si esta se agrega en el lugar, sino se agrega al final}
        
        }*/

    }
}
