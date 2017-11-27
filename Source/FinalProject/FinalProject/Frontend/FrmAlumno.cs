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

        /// <summary>
        /// Constructor de la clase
        /// Recibe el id de un alumno
        /// </summary>
        /// <param name="nocontrol"></param>
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
        /// <summary>
        /// Carga la información de un alumno y la
        /// muestra en las etiquetas
        /// </summary>
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
            // Asignar el nuevo correo
            alumno.Correo = txtCorreo.Text;

            // Intenta actualizar
            Alumno.Update(alumno);

            // Como se usa un trigger, para validar compara el correo en la caja
            // de texto contra el correo registrado en la base de datos.
            // Si son iguales significa que se pudo actualizar correctamente,
            // de lo contrario significa que no es un correo válido.
            if (Alumno.Select(alumno.NoControl).Correo.Equals(alumno.Correo))
                MessageBox.Show("Datos actualizados correctamente.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Datos inválidos.", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);

            txtCorreo.Focus();
        }
    }
}
