﻿namespace FinalProject.Frontend
{
    partial class FrmConsultarSolicitudes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarSolicitudes));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtListaSolicitudes = new System.Windows.Forms.DataGridView();
            this.dtcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(148, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mis solicitudes";
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
            this.dtcHorario,
            this.dtcNotas,
            this.dtcEstatus});
            this.dtListaSolicitudes.EnableHeadersVisualStyles = false;
            this.dtListaSolicitudes.Location = new System.Drawing.Point(12, 42);
            this.dtListaSolicitudes.Name = "dtListaSolicitudes";
            this.dtListaSolicitudes.ReadOnly = true;
            this.dtListaSolicitudes.RowHeadersVisible = false;
            this.dtListaSolicitudes.RowHeadersWidth = 45;
            this.dtListaSolicitudes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtListaSolicitudes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtListaSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListaSolicitudes.Size = new System.Drawing.Size(668, 307);
            this.dtListaSolicitudes.TabIndex = 2;
            this.dtListaSolicitudes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListaSolicitudes_CellDoubleClick);
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
            // dtcEstatus
            // 
            this.dtcEstatus.DataPropertyName = "Estatus";
            this.dtcEstatus.HeaderText = "Estatus";
            this.dtcEstatus.Name = "dtcEstatus";
            this.dtcEstatus.ReadOnly = true;
            // 
            // FrmConsultarSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 361);
            this.Controls.Add(this.dtListaSolicitudes);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmConsultarSolicitudes";
            this.Text = "Consultar mis solicitudes";
            ((System.ComponentModel.ISupportInitialize)(this.dtListaSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dtListaSolicitudes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcEstatus;
    }
}