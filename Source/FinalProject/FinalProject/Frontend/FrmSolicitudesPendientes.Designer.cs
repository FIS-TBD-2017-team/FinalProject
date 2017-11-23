﻿namespace FinalProject.Frontend
{
    partial class FrmSolicitudesPendientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtListaSolicitudes = new System.Windows.Forms.DataGridView();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.dtcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNoControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNombreAsesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitudes pendientes";
            // 
            // dtListaSolicitudes
            // 
            this.dtListaSolicitudes.AllowUserToAddRows = false;
            this.dtListaSolicitudes.AllowUserToDeleteRows = false;
            this.dtListaSolicitudes.AllowUserToResizeRows = false;
            this.dtListaSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtListaSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtListaSolicitudes.BackgroundColor = System.Drawing.Color.White;
            this.dtListaSolicitudes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtListaSolicitudes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtListaSolicitudes.ColumnHeadersHeight = 45;
            this.dtListaSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtListaSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcId,
            this.dtcMateria,
            this.dtcNoControl,
            this.dtcNombreAsesor,
            this.dtcHorario,
            this.dtcNotas});
            this.dtListaSolicitudes.EnableHeadersVisualStyles = false;
            this.dtListaSolicitudes.Location = new System.Drawing.Point(12, 73);
            this.dtListaSolicitudes.Name = "dtListaSolicitudes";
            this.dtListaSolicitudes.ReadOnly = true;
            this.dtListaSolicitudes.RowHeadersVisible = false;
            this.dtListaSolicitudes.RowHeadersWidth = 45;
            this.dtListaSolicitudes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtListaSolicitudes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtListaSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListaSolicitudes.Size = new System.Drawing.Size(668, 276);
            this.dtListaSolicitudes.TabIndex = 2;
            // 
            // cmbMateria
            // 
            this.cmbMateria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(12, 42);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(170, 25);
            this.cmbMateria.TabIndex = 23;
            // 
            // dtcId
            // 
            this.dtcId.DataPropertyName = "IdSolicitud";
            this.dtcId.FillWeight = 126.9036F;
            this.dtcId.HeaderText = "Id";
            this.dtcId.Name = "dtcId";
            this.dtcId.ReadOnly = true;
            // 
            // dtcMateria
            // 
            this.dtcMateria.DataPropertyName = "NombreMateria";
            this.dtcMateria.FillWeight = 93.27411F;
            this.dtcMateria.HeaderText = "Materia";
            this.dtcMateria.Name = "dtcMateria";
            this.dtcMateria.ReadOnly = true;
            // 
            // dtcNoControl
            // 
            this.dtcNoControl.DataPropertyName = "NoControl";
            this.dtcNoControl.FillWeight = 93.27411F;
            this.dtcNoControl.HeaderText = "No. Control";
            this.dtcNoControl.Name = "dtcNoControl";
            this.dtcNoControl.ReadOnly = true;
            // 
            // dtcNombreAsesor
            // 
            this.dtcNombreAsesor.DataPropertyName = "NombreAsesor";
            this.dtcNombreAsesor.FillWeight = 93.27411F;
            this.dtcNombreAsesor.HeaderText = "Nombre del asesor";
            this.dtcNombreAsesor.Name = "dtcNombreAsesor";
            this.dtcNombreAsesor.ReadOnly = true;
            // 
            // dtcHorario
            // 
            this.dtcHorario.DataPropertyName = "Horario";
            this.dtcHorario.HeaderText = "Horario";
            this.dtcHorario.Name = "dtcHorario";
            this.dtcHorario.ReadOnly = true;
            // 
            // dtcNotas
            // 
            this.dtcNotas.DataPropertyName = "Notas";
            this.dtcNotas.HeaderText = "Notas";
            this.dtcNotas.Name = "dtcNotas";
            this.dtcNotas.ReadOnly = true;
            // 
            // FrmSolicitudesPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 361);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.dtListaSolicitudes);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSolicitudesPendientes";
            this.Text = "FrmAsesoriasPendientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtListaSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtListaSolicitudes;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNoControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNombreAsesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNotas;
    }
}