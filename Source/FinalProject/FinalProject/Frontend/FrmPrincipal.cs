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
    public partial class FrmPrincipal : Form
    {
        Tutor tutor = null;
        bool CerrarApp = true;
        /// <summary>
        /// Constructor de la clase
        /// Recibe un objeto tutor como parametro
        /// </summary>
        /// <param name="IdTutor"></param>
        public FrmPrincipal(int IdTutor)
        {
            InitializeComponent();
            Init(Tutor.Select(IdTutor));
        }
        /// <summary>
        /// Actualiza el mensaje de bienvenida con la informacion del tutor
        /// </summary>
        /// <param name="tutor"></param>
        private void Init(Tutor tutor)
        {
            this.tutor = tutor;
            lblMensajeBienvenida.Text = String.Format("Bienvenido, {0}!", tutor.Nombre);

            CargarListaAsesorias();
        }
        /// <summary>
        /// Carga la lista de asesorias activas supervisadas por el tutor
        /// </summary>
        private void CargarListaAsesorias()
        {
            dtListaAsesorias.AutoGenerateColumns = false;
            dtListaAsesorias.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtListaAsesorias.DataSource = Asesoria.Activas(tutor);
        }
        /// <summary>
        /// Abre una nueva ventana para administrar la informacion de los asesores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            (new FrmListaAsesores(tutor.IdTutor)).ShowDialog();
        }
        /// <summary>
        /// Cierra sesion y regresa a la pantalla de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CerrarApp = false;
            this.Close();
        }
        /// <summary>
        /// Cierra la ventana principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CerrarApp)
                Application.Exit();
        }
        /// <summary>
        /// Abre una ventana nueva para ver la lista de asesorias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtListaAsesorias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Asesoria asesoria = (Asesoria)dtListaAsesorias.SelectedRows[0].DataBoundItem;
            (new FrmAsesoria(asesoria)).ShowDialog();
        }
        /// <summary>
        /// Abre una ventana nueva para consultar el estado de las solicitudes realizadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            (new FrmConsultarSolicitudes(tutor)).ShowDialog();
        }
        /// <summary>
        /// Abre una ventana nueva para solicitar una nueva asesoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            (new FrmSolicitarAsesoria(tutor)).ShowDialog();
        }
        /// <summary>
        /// Abre una ventana nueva con las solicitudes de asesorias realizadas por otros tutores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtender_Click(object sender, EventArgs e)
        {
            (new FrmAtenderSolicitudes(tutor)).ShowDialog();
        }
        /// <summary>
        /// Genera un reporte de los asesores a cargo del tutor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReportes_Click(object sender, EventArgs e)
        {
            (new FrmReportes()).ShowDialog();
        }
    }
}
