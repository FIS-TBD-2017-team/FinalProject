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
    public partial class FrmAtenderSolicitudes : Form
    {
        private Tutor tutor = null;

        /// <summary>
        /// Constructor de la clase
        /// recibe un objeto tipo tutor
        /// </summary>
        /// <param name="tutor"></param>
        public FrmAtenderSolicitudes(Tutor tutor)
        {
            InitializeComponent();

            this.tutor = tutor;

            dtListaSolicitudes.AutoGenerateColumns = false;
            dtListaSolicitudes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CargarSolicitudes();
        }
        /// <summary>
        /// Carga todas las solicitudes de asesoria existentes
        /// </summary>
        public void CargarSolicitudes()
        {
            dtListaSolicitudes.DataSource = null;
            dtListaSolicitudes.DataSource = Solicitud.PendientesSP(tutor);
        }
        /// <summary>
        /// Carga la informacion de una solicitud seleccionada de la tabla
        /// en una ventana nueva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtListaSolicitudes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtListaSolicitudes.RowCount == 0) return;

            Solicitud solicitud = (Solicitud)dtListaSolicitudes.SelectedRows[0].DataBoundItem;

            (new FrmAtenderSolicitud(tutor, solicitud)).ShowDialog();
            CargarSolicitudes();
        }
    }
}
