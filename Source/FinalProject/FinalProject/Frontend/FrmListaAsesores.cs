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
    public partial class FrmListaAsesores : Form
    {
        private Tutor tutor = null;
        /// <summary>
        /// Constructor de la clase
        /// Recibe el id de un tutor como parametro
        /// </summary>
        /// <param name="IdTutor"></param>
        public FrmListaAsesores(int IdTutor)
        {
            InitializeComponent();
            dtListaAsesorias.AutoGenerateColumns = false;
            dtListaAsesorias.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Init(Tutor.Select(IdTutor));
        }
        /// <summary>
        /// Carga los datos del tutor y de la lista de asesores
        /// </summary>
        /// <param name="tutor"></param>
        private void Init(Tutor tutor)
        {
            this.tutor = tutor;
            CargarDatos();
        }
        /// <summary>
        /// Carga la informacion de los asesores a cargo del tutor
        /// </summary>
        private void CargarDatos()
        {
            dtListaAsesorias.DataSource = null;
            dtListaAsesorias.DataSource = Alumno.SelectAsesor(tutor);
        }
        /// <summary>
        /// Carga la informacion de un asesor seleccionado de una tabla
        /// en una ventana nueva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtListaAsesorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String NoControl = dtListaAsesorias[0, e.RowIndex].Value.ToString();
            (new FrmAsesor(NoControl)).ShowDialog();
            CargarDatos();
        }
    }
}
