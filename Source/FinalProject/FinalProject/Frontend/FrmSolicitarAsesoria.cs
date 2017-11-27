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
        List<Alumno> alumnos = new List<Alumno>();
        Alumno alumnoAct = new Alumno();
        public FrmSolicitarAsesoria()
        {
            InitializeComponent();
        }

        public FrmSolicitarAsesoria(Tutor tutor)
        {
            InitializeComponent();
            this.tutor = tutor;
            cargarComboMaterias();
        }
        /// <summary>
        /// Carga el nombre de todas las materias en el comboBox
        /// </summary>
        public void cargarComboMaterias() {
            cmbMateria.DataSource = null;
            List<Materia> materias = new List<Materia>();
            materias = Materia.Select();
            cmbMateria.DataSource = materias;
            cmbMateria.DisplayMember = "Nombre";
            cmbMateria.ValueMember = "IdMateria";
        }
        /// <summary>
        /// Recarga la información de los alumnos que solicitan la asesoria
        /// de la tabla
        /// </summary>
        public void llenarTabla() {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alumnos;
            dataGridView1.Refresh();
        }
        /// <summary>
        /// Limpia la informacion del numero de control
        /// </summary>
        public void limpiarAlumno() {
            txtNoControl.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Verifica que se hayan llenado los campos necesarios
        /// De no ser asi manda un mensaje de error
        /// </summary>
        /// <returns></returns>
        private bool ValidarDatos() {
            if (cmbMateria.Text.Length == 0)
            {
                MessageBox.Show("Falta el campo:\n - Materia a solicitar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        /// <summary>
        /// Guarda la inforacion de la solicitud mediante procedimientos almacenados
        /// Si el procedimiento falla en alguna consulta se cancelan todos los registros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;
            Solicitud solicitud = new Solicitud(
                -1,
                int.Parse(cmbMateria.SelectedValue.ToString()),
                tutor.IdTutor,
                "PENDIENTE",
                txtHoras.Text,
                txtTema.Text    
            );
            Solicitud.RegistrarSP(solicitud,alumnos);
            Close();
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Agrega la informacion de las horas en las que se puede recibir la asesoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarModulo_Click(object sender, EventArgs e)
        {
            String dia = "";
            switch (cmbDia.SelectedIndex)
            {
                case 0:
                    dia = "LUN";
                    break;
                case 1:
                    dia = "MAR";
                    break;
                case 2:
                    dia = "MIE";
                    break;
                case 3:
                    dia = "JUE";
                    break;
                case 4:
                    dia = "VIE";
                    break;
            }
            String hora = cmbHora.SelectedItem + ":00";
            txtHoras.Text = txtHoras.Text + dia + " " + hora + " ";
        }
        /// <summary>
        /// Carga la información de un alumno en la tabla mediante el numero de control
        /// Si el numero de control es incorrecto manda un mensaje de error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno alumno = Alumno.Select(txtNoControl.Text);
            if (alumno == null)
            {
                MessageBox.Show("Clave del alumno incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cargarComboMaterias();
            btnGuardar.Enabled = true;
            bool encontrado = false;
            for (int i = 0; i < alumnos.Count; i++) {
                if (alumnos[i].NoControl == alumno.NoControl)
                    encontrado = true;
            }
            if (!encontrado)
            {
                alumnos.Add(alumno);
                llenarTabla();
                limpiarAlumno();
            }
        }
    }
}
