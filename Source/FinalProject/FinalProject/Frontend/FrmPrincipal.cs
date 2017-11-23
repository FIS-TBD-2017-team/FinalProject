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

        public FrmPrincipal(int IdTutor)
        {
            InitializeComponent();
            Init(Tutor.Select(IdTutor));
        }

        private void Init(Tutor tutor)
        {
            this.tutor = tutor;
            lblMensajeBienvenida.Text = String.Format("Bienvenido, {0}!", tutor.Nombre);

            CargarListaAsesorias();
        }
        private void CargarListaAsesorias()
        {
            dtListaAsesorias.AutoGenerateColumns = false;
            dtListaAsesorias.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtListaAsesorias.DataSource = Asesoria.Activas(tutor);
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            (new FrmListaAsesores(tutor.IdTutor)).ShowDialog();
        }
        private void lnkSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CerrarApp = false;
            this.Close();
        }
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CerrarApp)
                Application.Exit();
        }

        private void dtListaAsesorias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String NoControl = dtListaAsesorias[e.ColumnIndex, e.RowIndex].Value.ToString();
            (new FrmAsesoria(NoControl)).ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            (new FrmSolicitudesPendientes(tutor)).ShowDialog();
        }
    }
}
