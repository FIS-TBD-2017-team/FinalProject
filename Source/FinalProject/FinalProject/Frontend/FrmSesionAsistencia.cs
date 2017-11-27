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
    public partial class FrmSesionAsistencia : Form
    {
        private Sesion sesion;
        private List<Asistencia> list;

        public FrmSesionAsistencia(Sesion sesion)
        {
            InitializeComponent();

            this.sesion = sesion;
            lblFecha.Text = sesion.Fecha.ToString("dd/MM/yyyy");
            dtAlumnos.AutoGenerateColumns = false;

            CargarAsistencia();
        }
        public void CargarAsistencia()
        {
            list = Asistencia.Select(sesion.IdSesion);

            // Es la primera vez que se usa esta sesión
            if (list.Count == 0)
            {
                foreach (var alm in Asesoria.Integrantes(sesion.IdAsesoria))
                    Asistencia.Insert(new Asistencia(sesion.IdSesion, alm.NoControl, false));
                list = Asistencia.Select(sesion.IdSesion);
            }

            dtAlumnos.DataSource = list;
        }
        /// <summary>
        /// Informa si la información se cargo correctamente o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Asistencia.PasarLista(list))
                MessageBox.Show("Información guardada correctamente.", "Info", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Ocurrió un error.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
