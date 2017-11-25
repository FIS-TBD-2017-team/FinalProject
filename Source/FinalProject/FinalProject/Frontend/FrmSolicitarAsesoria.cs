using FinalProject.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Frontend
{
    public partial class FrmSolicitarAsesoria : Form
    {
        public FrmSolicitarAsesoria()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = Alumno.Select(txtNoControl.Text);
            if (alumno == null) {
                MessageBox.Show("Clave del alumno incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblCarrera.Text = alumno.NombreCarrera;
            lblCorreo.Text = alumno.Correo;
            lblNoSemestre.Text = alumno.Semestre+"";
            lblNombre.Text = alumno.NombreCompleto;
            if (alumno.Correo != null)
                lblNoControl.Text = alumno.NoControl;
            else
                lblCorreo.Text = "No disponible";
            cmbMateria.DataSource = null;
            List<Materia> materias = Materia.SelectSem(alumno.IdCarrera);
            cmbMateria.DataSource = materias;
            cmbMateria.DisplayMember = "nombre";
            cmbMateria.ValueMember = "idMateria";
        }
    }
}
