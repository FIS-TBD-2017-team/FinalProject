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
    public partial class FrmConsultarSolicitud : Form
    {
        private Solicitud solicitud = null;
        /// <summary>
        /// Constructor de la clase
        /// recibe como parámetro una solicitud de asesoria
        /// </summary>
        /// <param name="solicitud"></param>
        public FrmConsultarSolicitud(Solicitud solicitud)
        {
            InitializeComponent();

            this.solicitud = solicitud;

            dtAlumnos.AutoGenerateColumns = false;
            dtAlumnos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dtAsesores.AutoGenerateColumns = false;
            dtAsesores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            CargarInformacion();
            CargarAlumnos();
            CargarAsesores();
        }
        /// <summary>
        /// Carga la información de la solicitud
        /// en las etiquetas correspondientes
        /// </summary>
        public void CargarInformacion()
        {
            lblId.Text = solicitud.IdSolicitud.ToString();
            lblMateria.Text = solicitud.NombreMateria;
            txtNotas.Text = solicitud.Notas;
            lblHorario.Text = solicitud.Horario;
        }
        /// <summary>
        /// Carga la informacion de los alumnos
        /// que solicitan la asesoria
        /// </summary>
        public void CargarAlumnos()
        {
            dtAlumnos.DataSource = null;
            dtAlumnos.DataSource = Solicitud.IntegrantesSP(solicitud.IdSolicitud);
        }
        /// <summary>
        /// Carga la informacion de los asesores a cargo del tutor
        /// </summary>
        public void CargarAsesores()
        {
            dtAsesores.DataSource = null;
            dtAsesores.DataSource = Solicitud.AsesoresPropuestosSP(solicitud.IdSolicitud);
        }
        /// <summary>
        /// Carga la informacion de un alumno seleccionado de la tabla
        /// en una ventana nueva
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
        /// Carga la informacion de un asesor seleccionado de la tabla
        /// en una ventana nueva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtAsesores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtAlumnos.RowCount == 0) return;

            Alumno asesor = (Alumno)dtAsesores.SelectedRows[0].DataBoundItem;
            (new FrmAsesorHorarios(asesor.NoControl)).ShowDialog();
            CargarAsesores();
        }
        /// <summary>
        /// Selecciona un asesor de la lista de candidatos para atender la solicitud
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesignar_Click(object sender, EventArgs e)
        {
            if(dtAsesores.RowCount == 0 || dtAsesores.SelectedRows.Count == 0)
            {
                MessageBox.Show("No hay ningún asesor seleccionado.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Alumno asesor = (Alumno)dtAsesores.SelectedRows[0].DataBoundItem;

            // Crear el registro de asesoría
            int IdAsesoria = Asesoria.InsertAndSelect(
                new Asesoria(
                    -1,
                    asesor.NoControl,
                    solicitud.IdMateria,
                    "ACTIVA"
                )
            );

            // Actualizar el estatus de la solicitud a "ACEPTADA"
            solicitud.IdAsesoria = IdAsesoria;
            solicitud.Estatus = "ACEPTADA";

            Solicitud.ActualizarSP(solicitud);

            // Copiar todos los integrantes de la solicitud a la asesoría
            List<DetalleAsesoria> lista = new List<DetalleAsesoria>();

            foreach (DataGridViewRow row in dtAlumnos.Rows)
                lista.Add(new DetalleAsesoria(IdAsesoria, ((Alumno)row.DataBoundItem).NoControl));

            DetalleAsesoria.Insert(lista);

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Actualizar el estatus de la solicitud a "RECHAZADA"
            solicitud.IdAsesoria = -1;
            solicitud.Estatus = "RECHAZADA";

            Solicitud.ActualizarSP(solicitud);

            Close();
        }
    }
}
