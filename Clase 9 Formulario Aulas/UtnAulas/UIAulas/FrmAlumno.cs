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
    public partial class FrmAlumno : Form
    {
        private Alumno _MiAlumno;
        public Alumno MiAlumno
        {
            get { return _MiAlumno;}  
        }
        
        public FrmAlumno()
        {
            InitializeComponent();
        }

        private void FrmAlumno_Load(object sender, EventArgs e)
        {
            this.cmbSexo.Items.Add(SexoEnum.Masculino);
            this.cmbSexo.Items.Add(SexoEnum.Femenino);
        }
        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._MiAlumno = new Alumno(int.Parse(this.txtLegajo.Text), this.txtNombre.Text, (SexoEnum)this.cmbSexo.SelectedItem);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
