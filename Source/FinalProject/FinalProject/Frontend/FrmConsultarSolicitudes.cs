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
    public partial class FrmConsultarSolicitudes : Form
    {
        private Tutor tutor = null;
        /// <summary>
        /// Constructor de la clase
        /// recibe un tutor como parametrp
        /// </summary>
        /// <param name="tutor"></param>
        public FrmConsultarSolicitudes(Tutor tutor)
        {
            InitializeComponent();

            this.tutor = tutor;

            dtListaSolicitudes.AutoGenerateColumns = false;
            dtListaSolicitudes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CargarSolicitudes();
        }
        /// <summary>
        /// Muestra la lista de solicitudes realizadas por el tutor
        /// </summary>
        public void CargarSolicitudes()
        {
            dtListaSolicitudes.DataSource = null;
            dtListaSolicitudes.DataSource = Solicitud.ConsultasSP(tutor);
        }
        /// <summary>
        /// Muestra la informacion de una solicitud seleccionada de una tabla
        /// en una ventana nueva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtListaSolicitudes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Solicitud solicitud = (Solicitud)dtListaSolicitudes.SelectedRows[0].DataBoundItem;

            if (!solicitud.Estatus.Equals("PENDIENTE")) return;

            (new FrmConsultarSolicitud(solicitud)).ShowDialog();
            CargarSolicitudes();
        }
    }
}
