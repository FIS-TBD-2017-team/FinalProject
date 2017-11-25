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

        public void CargarInformacion()
        {
            lblId.Text = asesoria.IdAsesoria.ToString();
            lblMateria.Text = asesoria.NombreMateria;
            lblEstatus.Text = asesoria.Estatus;
            lblNoControl.Text = asesoria.NoControl;
            lblNombre.Text = asesoria.NombreAsesor;
        }
        public void CargarAlumnos()
        {
            dtAlumnos.DataSource = null;
            dtAlumnos.DataSource = Asesoria.Integrantes(asesoria.IdAsesoria);
            lblCantidad.Text = dtAlumnos.Rows.Count.ToString();
        }
        public void CargarSesiones()
        {
            dtSesiones.DataSource = null;
            dtSesiones.DataSource = Sesion.Select(asesoria);
        }

        private void dtAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Alumno alumno = (Alumno)dtAlumnos.SelectedRows[0].DataBoundItem;
            (new FrmAlumno(alumno.NoControl)).ShowDialog();
            CargarAlumnos();
        }

        private void btnAgregarSesion_Click(object sender, EventArgs e)
        {
            (new FrmSesion(asesoria.IdAsesoria)).ShowDialog();
            CargarSesiones();
        }

        private void dtSesiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Sesion sesion = (Sesion)dtSesiones.SelectedRows[0].DataBoundItem;
            if (!sesion.Estatus.Equals("REALIZADA")) return;
            (new FrmSesionAsistencia(sesion)).ShowDialog();
            CargarSesiones();
        }

        private void btnQuitarSesion_Click(object sender, EventArgs e)
        {
            if (dtSesiones.RowCount == 0) return;
            Sesion sesion = (Sesion)dtSesiones.SelectedRows[0].DataBoundItem;
            Sesion.Delete(sesion.IdSesion);
            CargarSesiones();
        }
    }
}
