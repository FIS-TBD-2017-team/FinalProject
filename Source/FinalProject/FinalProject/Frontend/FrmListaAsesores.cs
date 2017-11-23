﻿using FinalProject.Backend;
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

        public FrmListaAsesores(int IdTutor)
        {
            InitializeComponent();
            dtListaAsesorias.AutoGenerateColumns = false;
            dtListaAsesorias.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Init(Tutor.Select(IdTutor));
        }

        private void Init(Tutor tutor)
        {
            this.tutor = tutor;
            CargarDatos();
        }

        private void CargarDatos()
        {
            dtListaAsesorias.DataSource = null;
            dtListaAsesorias.DataSource = Alumno.SelectAsesor(tutor);
        }

        private void dtListaAsesorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String NoControl = dtListaAsesorias[0, e.RowIndex].Value.ToString();
            (new FrmAsesor(NoControl)).ShowDialog();
            CargarDatos();
        }
    }
}
