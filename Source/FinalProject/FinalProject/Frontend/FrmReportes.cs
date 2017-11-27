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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Carga la información de los asesores a cargo del tutor y
        /// abre una ventana nueva para visualizarlos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRepAsesores_Click(object sender, EventArgs e)
        {
            DataTable dt = Backend.Reportes.RepAsesores();
            (new Reportes.FrmRepAsesores(dt)).ShowDialog();
        }
    }
}
