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
    public partial class FrmSolicitudesPendientes : Form
    {
        private Tutor tutor = null;
        public FrmSolicitudesPendientes(Tutor tutor)
        {
            InitializeComponent();
            this.tutor = tutor;
            dtListaSolicitudes.AutoGenerateColumns = false;
            dtListaSolicitudes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CargarSolicitud();
        }

        public void CargarSolicitud()
        {
            dtListaSolicitudes.DataSource = null;
            dtListaSolicitudes.DataSource = Solicitud.Select(tutor);
        }
    }
}
