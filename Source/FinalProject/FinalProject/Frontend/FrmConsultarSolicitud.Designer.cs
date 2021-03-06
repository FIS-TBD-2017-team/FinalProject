﻿namespace FinalProject.Frontend
{
    partial class FrmConsultarSolicitud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarSolicitud));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubAlumnos = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblMateriat = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdt = new System.Windows.Forms.Label();
            this.dtAlumnos = new System.Windows.Forms.DataGridView();
            this.dtcNoControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNotas = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.RichTextBox();
            this.lblHorariot = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.dtAsesores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubAsesores = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDesignar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAsesores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(92, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Solicitud";
            // 
            // lblSubAlumnos
            // 
            this.lblSubAlumnos.AutoSize = true;
            this.lblSubAlumnos.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lblSubAlumnos.Location = new System.Drawing.Point(12, 125);
            this.lblSubAlumnos.Name = "lblSubAlumnos";
            this.lblSubAlumnos.Size = new System.Drawing.Size(145, 25);
            this.lblSubAlumnos.TabIndex = 3;
            this.lblSubAlumnos.Text = "Lista de alumnos";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(75, 67);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(53, 19);
            this.lblMateria.TabIndex = 4;
            this.lblMateria.Text = "Metdos";
            // 
            // lblMateriat
            // 
            this.lblMateriat.AutoSize = true;
            this.lblMateriat.Location = new System.Drawing.Point(13, 67);
            this.lblMateriat.Name = "lblMateriat";
            this.lblMateriat.Size = new System.Drawing.Size(57, 19);
            this.lblMateriat.TabIndex = 5;
            this.lblMateriat.Text = "Materia:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(76, 48);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 19);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "1";
            // 
            // lblIdt
            // 
            this.lblIdt.AutoSize = true;
            this.lblIdt.Location = new System.Drawing.Point(46, 48);
            this.lblIdt.Name = "lblIdt";
            this.lblIdt.Size = new System.Drawing.Size(24, 19);
            this.lblIdt.TabIndex = 7;
            this.lblIdt.Text = "ID:";
            // 
            // dtAlumnos
            // 
            this.dtAlumnos.AllowUserToAddRows = false;
            this.dtAlumnos.AllowUserToDeleteRows = false;
            this.dtAlumnos.AllowUserToResizeRows = false;
            this.dtAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAlumnos.BackgroundColor = System.Drawing.Color.White;
            this.dtAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtAlumnos.ColumnHeadersHeight = 45;
            this.dtAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcNoControl,
            this.dtcNombre,
            this.dtcCarrera,
            this.dtcCorreo});
            this.dtAlumnos.EnableHeadersVisualStyles = false;
            this.dtAlumnos.Location = new System.Drawing.Point(16, 153);
            this.dtAlumnos.MultiSelect = false;
            this.dtAlumnos.Name = "dtAlumnos";
            this.dtAlumnos.ReadOnly = true;
            this.dtAlumnos.RowHeadersVisible = false;
            this.dtAlumnos.RowHeadersWidth = 45;
            this.dtAlumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtAlumnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtAlumnos.Size = new System.Drawing.Size(589, 171);
            this.dtAlumnos.TabIndex = 16;
            this.dtAlumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAlumnos_CellDoubleClick);
            // 
            // dtcNoControl
            // 
            this.dtcNoControl.DataPropertyName = "NoControl";
            this.dtcNoControl.HeaderText = "No. Control";
            this.dtcNoControl.Name = "dtcNoControl";
            this.dtcNoControl.ReadOnly = true;
            // 
            // dtcNombre
            // 
            this.dtcNombre.DataPropertyName = "NombreCompleto";
            this.dtcNombre.HeaderText = "Nombre";
            this.dtcNombre.Name = "dtcNombre";
            this.dtcNombre.ReadOnly = true;
            // 
            // dtcCarrera
            // 
            this.dtcCarrera.DataPropertyName = "NombreCarrera";
            this.dtcCarrera.HeaderText = "Carrera";
            this.dtcCarrera.Name = "dtcCarrera";
            this.dtcCarrera.ReadOnly = true;
            // 
            // dtcCorreo
            // 
            this.dtcCorreo.DataPropertyName = "Correo";
            this.dtcCorreo.HeaderText = "Correo";
            this.dtcCorreo.Name = "dtcCorreo";
            this.dtcCorreo.ReadOnly = true;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(245, 48);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(46, 19);
            this.lblNotas.TabIndex = 18;
            this.lblNotas.Text = "Notas:";
            // 
            // txtNotas
            // 
            this.txtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotas.Enabled = false;
            this.txtNotas.Location = new System.Drawing.Point(297, 48);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(308, 62);
            this.txtNotas.TabIndex = 19;
            this.txtNotas.Text = "";
            // 
            // lblHorariot
            // 
            this.lblHorariot.AutoSize = true;
            this.lblHorariot.Location = new System.Drawing.Point(12, 86);
            this.lblHorariot.Name = "lblHorariot";
            this.lblHorariot.Size = new System.Drawing.Size(57, 19);
            this.lblHorariot.TabIndex = 21;
            this.lblHorariot.Text = "Horario:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(74, 86);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(40, 19);
            this.lblHorario.TabIndex = 20;
            this.lblHorario.Text = "10:00";
            // 
            // dtAsesores
            // 
            this.dtAsesores.AllowUserToAddRows = false;
            this.dtAsesores.AllowUserToDeleteRows = false;
            this.dtAsesores.AllowUserToResizeRows = false;
            this.dtAsesores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtAsesores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAsesores.BackgroundColor = System.Drawing.Color.White;
            this.dtAsesores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtAsesores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtAsesores.ColumnHeadersHeight = 45;
            this.dtAsesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtAsesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dtAsesores.EnableHeadersVisualStyles = false;
            this.dtAsesores.Location = new System.Drawing.Point(15, 355);
            this.dtAsesores.MultiSelect = false;
            this.dtAsesores.Name = "dtAsesores";
            this.dtAsesores.ReadOnly = true;
            this.dtAsesores.RowHeadersVisible = false;
            this.dtAsesores.RowHeadersWidth = 45;
            this.dtAsesores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtAsesores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtAsesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtAsesores.Size = new System.Drawing.Size(589, 171);
            this.dtAsesores.TabIndex = 23;
            this.dtAsesores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAsesores_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoControl";
            this.dataGridViewTextBoxColumn1.HeaderText = "No. Control";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreCompleto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NombreCarrera";
            this.dataGridViewTextBoxColumn3.HeaderText = "Carrera";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // lblSubAsesores
            // 
            this.lblSubAsesores.AutoSize = true;
            this.lblSubAsesores.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lblSubAsesores.Location = new System.Drawing.Point(11, 327);
            this.lblSubAsesores.Name = "lblSubAsesores";
            this.lblSubAsesores.Size = new System.Drawing.Size(177, 25);
            this.lblSubAsesores.TabIndex = 22;
            this.lblSubAsesores.Text = "Asesores propuestos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(15, 539);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 54);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar solicitud";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDesignar
            // 
            this.btnDesignar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesignar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnDesignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesignar.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnDesignar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDesignar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDesignar.Location = new System.Drawing.Point(441, 539);
            this.btnDesignar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDesignar.Name = "btnDesignar";
            this.btnDesignar.Size = new System.Drawing.Size(163, 54);
            this.btnDesignar.TabIndex = 34;
            this.btnDesignar.Text = "Designar asesor";
            this.btnDesignar.UseVisualStyleBackColor = true;
            this.btnDesignar.Click += new System.EventHandler(this.btnDesignar_Click);
            // 
            // FrmConsultarSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 606);
            this.Controls.Add(this.btnDesignar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtAsesores);
            this.Controls.Add(this.lblSubAsesores);
            this.Controls.Add(this.lblHorariot);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.dtAlumnos);
            this.Controls.Add(this.lblIdt);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblMateriat);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblSubAlumnos);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmConsultarSolicitud";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Solicitud";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAsesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubAlumnos;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblMateriat;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdt;
        private System.Windows.Forms.DataGridView dtAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNoControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcCorreo;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.RichTextBox txtNotas;
        private System.Windows.Forms.Label lblHorariot;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.DataGridView dtAsesores;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblSubAsesores;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDesignar;
    }
}