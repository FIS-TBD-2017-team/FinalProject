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

        /// <summary>
        /// Constructor de la clase
        /// Recibe el número de control de un asesor
        /// </summary>
        /// <param name="nocontrol"></param>
        public FrmAsesor(String nocontrol) 
        {
            InitializeComponent();
            Init(Alumno.Select(nocontrol));
        }
        /// <summary>
        /// Inicializa los parámetros de los campos de la pntalla
        /// </summary>
        /// <param name="asesor"></param>
        public void Init(Alumno asesor)
        {
            this.asesor = asesor;
            CargarInformacion();
            InitCombos();
            CargarHorasLibres();
            CargarMaterias();    
        }
        /// <summary>
        /// Carga la inforación de un asesor en las etiquetas correspondientes
        /// </summary>
        public void CargarInformacion()
        {
            lblNoControl.Text = asesor.NoControl;
            lblNombre.Text = asesor.NombreCompleto;
            lblCarrera.Text = asesor.NombreCarrera;
            lblSemestre.Text = asesor.Semestre.ToString();

            txtCorreo.Text = asesor.Correo;
        }
        /// <summary>
        /// Cambia los combos a sus valores iniciales
        /// </summary>
        public void InitCombos()
        {
            cmbMateria.DataSource = Materia.Select();

            cmbDia.SelectedIndex = 0;
            cmbHora.SelectedIndex = 0;
            cmbMateria.SelectedIndex = 0;
        }
        
        /// <summary>
        /// Carga las horas libres en las qque un asesor
        /// puede impartir asesorias
        /// </summary>
        public void CargarHorasLibres()
        {
            dtHorasLibres.AutoGenerateColumns = false;
            dtcHora.DefaultCellStyle.Format = "hh:mm";

            dtHorasLibres.DataSource = null;
            dtHorasLibres.DataSource = HoraLibre.Select(asesor);
        }

        /// <summary>
        /// Carga las materias impartidas por un asesor
        /// </summary>
        public void CargarMaterias()
        {
            dtMaterias.AutoGenerateColumns = false;
            dtMaterias.DataSource = Materia.Select(asesor);
        }

        /// <summary>
        /// Agrega horas libres en las que el asesor puede
        /// dar asesoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Elimina una hora libre del asesor si ha sido ocupada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitarModulo_Click(object sender, EventArgs e)
        {
            if (dtHorasLibres.SelectedRows.Count == 0)
                return;

            var dr = dtHorasLibres.SelectedRows[0];
            HoraLibre hl = (HoraLibre)dr.DataBoundItem;
            HoraLibre.Delete(hl);
            CargarHorasLibres();
        }

        /// <summary>
        /// Agrega materias a un asesor solo si no han sido registradas previamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            Oferta oferta = new Oferta(-1, asesor.NoControl, (int)cmbMateria.SelectedValue);
            if(!Oferta.Exists(oferta)) {
                Oferta.Insert(oferta);
                CargarMaterias();
            } else
            {
                MessageBox.Show("Esa materia ya está en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnQuitarMateria_Click(object sender, EventArgs e)
        {
            if (dtMaterias.SelectedRows.Count == 0)
                return;

            var dr = dtMaterias.SelectedRows[0];
            Materia materia = (Materia)dr.DataBoundItem;
            Oferta.Delete(new Oferta(-1, asesor.NoControl, materia.IdMateria));
            CargarMaterias();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Asignar el nuevo correo
            asesor.Correo = txtCorreo.Text;

            // Intenta actualizar
            Alumno.Update(asesor);

            // Como se usa un trigger, para validar compara el correo en la caja
            // de texto contra el correo registrado en la base de datos.
            // Si son iguales significa que se pudo actualizar correctamente,
            // de lo contrario significa que no es un correo válido.
            if(Alumno.Select(asesor.NoControl).Correo.Equals(asesor.Correo)) 
                MessageBox.Show("Datos actualizados correctamente.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Datos inválidos.", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);

            txtCorreo.Focus();
        }
    }
}
