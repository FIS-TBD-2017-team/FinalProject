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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Valida que se hayan ingresado los parametros necesarios
        /// </summary>
        /// <returns></returns>
        private bool ValidarDatos()
        {
            bool val = true;
            String e_msg = "";

            if (txtUser.Text.Length == 0)
            {
                val = false;
                e_msg += "\n - Usuario";
            }
            if (txtPass.Text.Length == 0)
            {
                val = false;
                e_msg += "\n - Contraseña";
            }

            if(!val)
            {
                MessageBox.Show("Faltan los campos:" + e_msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return val;
        }
        /// <summary>
        /// Limpia la información de los campos ingresados
        /// </summary>
        private void LimpiarDatos()
        {
            txtUser.Text = "";
            txtPass.Text = "";   
        }
        /// <summary>
        /// Valida las credenciales de los campos correspondientes
        /// Si son incorrectas manda un mensaje de error
        /// Si son correctas inicia una sesion y permite al usuario ingresar 
        /// a la pantalla principal
        /// </summary>
        /// <returns></returns>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            Tutor tutor = Tutor.Login(txtUser.Text, txtPass.Text);

            if (tutor == null)
            {
                MessageBox.Show("Credenciales incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            LimpiarDatos();
            (new FrmPrincipal(tutor.IdTutor)).ShowDialog();
            this.Show();
            txtUser.Focus();
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnIngresar_Click(sender, e);
        }
    }
}
