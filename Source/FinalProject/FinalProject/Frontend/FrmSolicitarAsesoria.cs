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
        Tutor tutor;
        public FrmSolicitarAsesoria()
        {
            InitializeComponent();
        }

        public FrmSolicitarAsesoria(Tutor tutor)
        {
            InitializeComponent();
            this.tutor = tutor;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarDatos() {
            if (cmbMateria.Text.Length == 0)
            {
                MessageBox.Show("Falta el campo:\n - Materia a solicitar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;
            Solicitud solicitud = new Solicitud(
                -1,
                int.Parse(cmbMateria.SelectedValue.ToString()),
                tutor.IdTutor,
                "PENDIENTE",
                "",
                txtTema.Text
            );
            solicitud.Insert(solicitud);
            Close();
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = Alumno.Select(txtNoControl.Text);
            if (alumno == null) {
                MessageBox.Show("Clave del alumno incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnGuardar.Enabled = true;
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
