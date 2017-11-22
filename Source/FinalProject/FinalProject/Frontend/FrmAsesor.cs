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
    public partial class FrmAsesor : Form
    {
        private Alumno asesor = null;

        public FrmAsesor(String nocontrol) 
        {
            InitializeComponent();
            Init(Alumno.SelectAsesor(nocontrol));
        }
        public void Init(Alumno asesor)
        {
            this.asesor = asesor;
            CargarInformacion();
            InitCombos();
            CargarHorasLibres();
            CargarMaterias();    
        }
        public void CargarInformacion()
        {
            lblNoControl.Text = asesor.NoControl;
            lblNombre.Text = asesor.NombreCompleto;
            lblCarrera.Text = asesor.NombreCarrera;
            lblSemestre.Text = asesor.Semestre.ToString();

            txtCorreo.Text = asesor.Correo;
        }
        public void InitCombos()
        {
            cmbMateria.DataSource = Materia.Select();

            cmbDia.SelectedIndex = 0;
            cmbHora.SelectedIndex = 0;
            cmbMateria.SelectedIndex = 0;
        }
        public void CargarHorasLibres()
        {
            dtHorasLibres.AutoGenerateColumns = false;
            dtcHora.DefaultCellStyle.Format = "hh:mm";

            dtHorasLibres.DataSource = null;
            dtHorasLibres.DataSource = HoraLibre.Select(asesor);
        }
        public void CargarMaterias()
        {
            dtMaterias.AutoGenerateColumns = false;
            //dtMaterias.DataSource = Alumno.Materias(asesor.NoControl);
        }

        private void btnAgregarModulo_Click(object sender, EventArgs e)
        {
            String dia = "";
            switch (cmbDia.SelectedIndex)
            {
                case 0:
                    dia = "LUN";
                    break;
                case 1:
                    dia = "MAR";
                    break;
                case 2:
                    dia = "MIE";
                    break;
                case 3:
                    dia = "JUE";
                    break;
                case 4:
                    dia = "VIE";
                    break;
            }
            String hora = cmbHora.SelectedItem + ":00";
            HoraLibre hl = new HoraLibre(asesor.NoControl, dia, hora);
            if (!HoraLibre.Exists(hl))
            {
                HoraLibre.Insert(hl);
                InitCombos();
                CargarHorasLibres();
            } else
            {
                MessageBox.Show("Ese módulo ya está enlistado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
