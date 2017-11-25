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

        public FrmAtenderSolicitudes(Tutor tutor)
        {
            InitializeComponent();

            this.tutor = tutor;

            dtListaSolicitudes.AutoGenerateColumns = false;
            dtListaSolicitudes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CargarSolicitudes();
        }

        public void CargarSolicitudes()
        {
            dtListaSolicitudes.DataSource = null;
            dtListaSolicitudes.DataSource = Solicitud.Pendientes(tutor);
        }

        private void dtListaSolicitudes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtListaSolicitudes.RowCount == 0) return;

            Solicitud solicitud = (Solicitud)dtListaSolicitudes.SelectedRows[0].DataBoundItem;

            (new FrmAtenderSolicitud(tutor, solicitud)).ShowDialog();
            CargarSolicitudes();
        }
    }
}
