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
    public partial class FrmPrincipal : Form
    {
        private Aula MiAula;
        
        public FrmPrincipal()
        {
            InitializeComponent();
             MiAula = new Aula(001);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumno frm = new FrmAlumno();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.MiAula.ListaDeAlumnos.Add(frm.MiAlumno);

            }

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado frm = new Listado(this.MiAula);
            frm.Show();
   
        }
    }
}
