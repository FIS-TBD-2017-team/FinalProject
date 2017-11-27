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
    public partial class FrmAsesoria : Form
    {
        private Asesoria asesoria;

        /// <summary>
        /// Constructor de la clase
        /// Carga la información de una asesoría en los campos correspondiente
        /// </summary>
        /// <param name="asesoria"></param>
        public FrmAsesoria(Asesoria asesoria)
        {
            InitializeComponent();

            this.asesoria = asesoria;

            dtAlumnos.AutoGenerateColumns = false;
            dtAlumnos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtSesiones.AutoGenerateColumns = false;

            CargarInformacion();
            CargarAlumnos();
            CargarSesiones();
        }
        
        /// <summary>
        /// Carga la información de la asesoría en las etiquetas correspondientes
        /// </summary>
        public void CargarInformacion()
        {
            lblId.Text = asesoria.IdAsesoria.ToString();
            lblMateria.Text = asesoria.NombreMateria;
            lblEstatus.Text = asesoria.Estatus;
            lblNoControl.Text = asesoria.NoControl;
            lblNombre.Text = asesoria.NombreAsesor;
        }
        /// <summary>
        /// Carga la información de los alumnos que pertenecen a una asesoria
        /// </summary>
        public void CargarAlumnos()
        {
            dtAlumnos.DataSource = null;
            dtAlumnos.DataSource = Asesoria.Integrantes(asesoria.IdAsesoria);
            lblCantidad.Text = dtAlumnos.Rows.Count.ToString();
        }
        /// <summary>
        /// Carga la información de las sesiones realizadas
        /// de una asesoria
        /// </summary>
        public void CargarSesiones()
        {
            dtSesiones.DataSource = null;
            dtSesiones.DataSource = Sesion.Select(asesoria);
        }
        /// <summary>
        /// Carga la información de un alumno seleccionado de una tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Alumno alumno = (Alumno)dtAlumnos.SelectedRows[0].DataBoundItem;
            (new FrmAlumno(alumno.NoControl)).ShowDialog();
            CargarAlumnos();
        }
        /// <summary>
        /// Abre una ventana para registrar la información de una sesion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarSesion_Click(object sender, EventArgs e)
        {
            (new FrmSesion(asesoria.IdAsesoria)).ShowDialog();
            CargarSesiones();
        }

        /// <summary>
        /// Carga la información de una sesion seleccionada de una tabla
        /// en una ventana nueva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtSesiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Sesion sesion = (Sesion)dtSesiones.SelectedRows[0].DataBoundItem;
            if (!sesion.Estatus.Equals("REALIZADA")) return;
            (new FrmSesionAsistencia(sesion)).ShowDialog();
            CargarSesiones();
        }
        /// <summary>
        /// Elimina la información de una sesion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitarSesion_Click(object sender, EventArgs e)
        {
            if (dtSesiones.RowCount == 0) return;
            Sesion sesion = (Sesion)dtSesiones.SelectedRows[0].DataBoundItem;
            Sesion.Delete(sesion.IdSesion);
            CargarSesiones();
        }
    }
}
