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
    public partial class FrmSesion : Form
    {
        private int IdAsesoria;

        public FrmSesion(int IdAsesoria)
        {
            InitializeComponent();

            this.IdAsesoria = IdAsesoria;

            cmbEstatus.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
        }

        private bool ValidarDatos()
        {
            if (txtLugar.Text.Length == 0) {
                MessageBox.Show("Falta el campo:\n - Lugar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            Sesion sesion = new Sesion(
                -1, 
                IdAsesoria, 
                cmbEstatus.SelectedItem.ToString(), 
                txtLugar.Text,
                dtpFecha.Value, 
                dtpHora.Value.ToString("HH:mm:ss"), 
                txtNotas.Text
            );
            Sesion.Insert(sesion);
            Close();
        }
    }
}
