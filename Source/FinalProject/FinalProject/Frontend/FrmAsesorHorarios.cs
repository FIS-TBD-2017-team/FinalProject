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
    public partial class FrmAsesorHorarios : Form
    {
        private Alumno asesor = null;

        public FrmAsesorHorarios(String nocontrol)
        {
            InitializeComponent();
            Init(Alumno.Select(nocontrol));
        }

        public void Init(Alumno asesor)
        {
            this.asesor = asesor;
            CargarInformacion();
            CargarHorasLibres();
        }

        public void CargarInformacion()
        {
            lblNoControl.Text = asesor.NoControl;
            lblNombre.Text = asesor.NombreCompleto;
            lblCarrera.Text = asesor.NombreCarrera;
            lblSemestre.Text = asesor.Semestre.ToString();
            lblCorreo.Text = asesor.Correo;
        }

        public void CargarHorasLibres()
        {
            dtHorasLibres.AutoGenerateColumns = false;
            dtcHora.DefaultCellStyle.Format = "hh:mm";

            dtHorasLibres.DataSource = null;
            dtHorasLibres.DataSource = HoraLibre.Select(asesor);
        }
    }
}
