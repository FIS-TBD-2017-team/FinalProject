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
    public partial class FrmAtenderSolicitud : Form
    {
        private Tutor tutor = null;
        private Solicitud solicitud = null;

        /// <summary>
        /// Constructor de la clase
        /// recibe como parámetro un objeto de tipo tutor y un obejto
        /// tipo solicitud
        /// </summary>
        /// <param name="tutor"></param>
        /// <param name="solicitud"></param>
        public FrmAtenderSolicitud(Tutor tutor, Solicitud solicitud)
        {
            InitializeComponent();

            this.tutor = tutor;
            this.solicitud = solicitud;

            dtAlumnos.AutoGenerateColumns = false;
            dtAlumnos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dtAsesores.AutoGenerateColumns = false;
            dtAsesores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtAsesores.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            CargarInformacion();
            CargarAlumnos();
            CargarAsesores();
        }
        /// <summary>
        /// Carga la información de la solicitud en las etiquetas correspondientes
        /// </summary>
        public void CargarInformacion()
        {
            lblId.Text = solicitud.IdSolicitud.ToString();
            lblMateria.Text = solicitud.NombreMateria;
            txtNotas.Text = solicitud.Notas;
            lblHorario.Text = solicitud.Horario;
        }
        /// <summary>
        /// Carga los alumnos correspondientes a la solicitud en un combo
        /// </summary>
        public void CargarAlumnos()
        {
            dtAlumnos.DataSource = null;
            dtAlumnos.DataSource = Solicitud.IntegrantesSP(solicitud.IdSolicitud);
        }
        public void CargarAsesores()
        {
            dtAsesores.DataSource = null;

            // Obtiene la lista de asesores capaces de asesorar en dicha materia,
            // que sean tutorados del usuario actual
            var list = Alumno.SelectAsesor(tutor, solicitud.IdMateria);

            // Si no hay asesores capaces elimina el filtro de materia, y muestra
            // la lista completa de asesores del tutor.
            if (list.Count == 0)
                list = Alumno.SelectAsesor(tutor);

            dtAsesores.DataSource = list;
        }
        /// <summary>
        /// Carga la inormación de un asesor seleccionado de una tabla
        /// en una nueva ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtAsesores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Alumno asesor = (Alumno)dtAsesores.SelectedRows[0].DataBoundItem;
            (new FrmAsesor(asesor.NoControl)).ShowDialog();
            CargarAsesores();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // TODO: Actualizar la basura
        }
        /// <summary>
        /// Rechaza una peticion de aseesoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRechazar_Click(object sender, EventArgs e)
        {
            Respuesta.Insert(new Respuesta(-1, solicitud.IdSolicitud, tutor.IdTutor, "RECHAZADA"));
            Close();
        }
        /// <summary>
        /// Manda una respuesta a una solicitud de asesoria
        /// con la información del asesor candidato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesignar_Click(object sender, EventArgs e)
        {
            List<Alumno> list = new List<Alumno>();

            foreach (DataGridViewRow row in dtAsesores.Rows)
                if (Convert.ToBoolean(row.Cells[4].Value) == true)
                    list.Add(new Alumno(row.Cells[0].Value.ToString()));

            if(list.Count == 0)
            {
                MessageBox.Show("No se seleccionaron asesores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int IdRespuesta = 
                Respuesta.InsertAndSelect(new Respuesta(-1, solicitud.IdSolicitud, tutor.IdTutor, "ACEPTADA"));

            foreach (Alumno alm in list)
                DetalleRespuesta.Insert(new DetalleRespuesta(IdRespuesta, alm.NoControl));

            Close();
        }
    }
}
