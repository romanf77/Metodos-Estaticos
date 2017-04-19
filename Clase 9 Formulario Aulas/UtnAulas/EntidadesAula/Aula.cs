using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAula
{
    public class Aula
    {
        private int _Numero;
        public int Numero
        {
            get { return this._Numero; }
            set { _Numero = value; }
        }

        private List<Alumno> _ListaDeAlumnos;
        public List<Alumno> ListaDeAlumnos
        {
            get { return this._ListaDeAlumnos; }
        }

        public Aula(int Numero)
        {
            this._ListaDeAlumnos = new List<Alumno>();
            this._Numero = Numero;
   
        }





    }
}
