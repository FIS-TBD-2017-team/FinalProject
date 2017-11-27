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

        /// <summary>
        /// Constructor de la clase
        /// Recibe el número de control de un asesor
        /// </summary>
        /// <param name="nocontrol"></param>
        public FrmAsesorHorarios(String nocontrol)
        {
            InitializeComponent();
            Init(Alumno.Select(nocontrol));
        }

        /// <summary>
        /// Inicializa los parámetros de los elementos de la pantalla
        /// </summary>
        /// <param name="asesor"></param>
        public void Init(Alumno asesor)
        {
            this.asesor = asesor;
            CargarInformacion();
            CargarHorasLibres();
        }
        /// <summary>
        /// Carga la informacion del asesor en las etiquetas correspondientes
        /// </summary>
        public void CargarInformacion()
        {
            lblNoControl.Text = asesor.NoControl;
            lblNombre.Text = asesor.NombreCompleto;
            lblCarrera.Text = asesor.NombreCarrera;
            lblSemestre.Text = asesor.Semestre.ToString();
            lblCorreo.Text = asesor.Correo;
        }
        /// <summary>
        /// Carga la informació de las horas en las que un asesor puede
        /// impartir asesorías
        /// </summary>
        public void CargarHorasLibres()
        {
            dtHorasLibres.AutoGenerateColumns = false;
            dtcHora.DefaultCellStyle.Format = "hh:mm";

            dtHorasLibres.DataSource = null;
            dtHorasLibres.DataSource = HoraLibre.Select(asesor);
        }
    }
}
