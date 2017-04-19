using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesAula;
namespace UIAulas
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }
        public Listado(Aula AulaRecibida):this()
        {
            foreach (Alumno item in AulaRecibida.ListaDeAlumnos)
            {
                this.lstListado.Items.Add(item);
            }
        
        
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            
        }
    }
}
