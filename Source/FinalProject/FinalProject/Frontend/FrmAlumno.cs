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
    public partial class FrmAlumno : Form
    {
        private Alumno alumno = null;

        public FrmAlumno(String nocontrol)
        {
            InitializeComponent();

            this.alumno = Alumno.Select(nocontrol);

            Init();
        }
        public void Init()
        {            
            CargarInformacion();
        }
        public void CargarInformacion()
        {
            lblNoControl.Text = alumno.NoControl;
            lblNombre.Text = alumno.NombreCompleto;
            lblCarrera.Text = alumno.NombreCarrera;
            lblSemestre.Text = alumno.Semestre.ToString();

            txtCorreo.Text = alumno.Correo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            alumno.Correo = txtCorreo.Text;
            if (Alumno.Update(alumno))
                MessageBox.Show("Datos actualizados correctamente.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudieon actualizar los datos.", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
