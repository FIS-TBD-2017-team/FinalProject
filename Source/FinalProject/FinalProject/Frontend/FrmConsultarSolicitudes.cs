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

        public FrmConsultarSolicitudes(Tutor tutor)
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
            dtListaSolicitudes.DataSource = Solicitud.Select(tutor);
        }

        private void dtListaSolicitudes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Solicitud solicitud = (Solicitud)dtListaSolicitudes.SelectedRows[0].DataBoundItem;

            if (!solicitud.Estatus.Equals("PENDIENTE")) return;

            (new FrmConsultarSolicitud(solicitud)).ShowDialog();
            CargarSolicitudes();
        }
    }
}
