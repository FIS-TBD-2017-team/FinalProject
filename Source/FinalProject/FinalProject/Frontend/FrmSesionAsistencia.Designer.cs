namespace FinalProject.Frontend
{
    partial class FrmSesionAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSesionAsistencia));
            this.dtAlumnos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechat = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtcNoControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcAsistio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtAlumnos
            // 
            this.dtAlumnos.AllowUserToAddRows = false;
            this.dtAlumnos.AllowUserToDeleteRows = false;
            this.dtAlumnos.AllowUserToResizeRows = false;
            this.dtAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.dtcAsistio});
            this.dtAlumnos.EnableHeadersVisualStyles = false;
            this.dtAlumnos.Location = new System.Drawing.Point(12, 64);
            this.dtAlumnos.MultiSelect = false;
            this.dtAlumnos.Name = "dtAlumnos";
            this.dtAlumnos.RowHeadersVisible = false;
            this.dtAlumnos.RowHeadersWidth = 45;
            this.dtAlumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtAlumnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtAlumnos.Size = new System.Drawing.Size(348, 203);
            this.dtAlumnos.TabIndex = 26;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(106, 30);
            this.lblTitulo.TabIndex = 27;
            this.lblTitulo.Text = "Asistencia";
            // 
            // lblFechat
            // 
            this.lblFechat.AutoSize = true;
            this.lblFechat.Location = new System.Drawing.Point(13, 42);
            this.lblFechat.Name = "lblFechat";
            this.lblFechat.Size = new System.Drawing.Size(46, 19);
            this.lblFechat.TabIndex = 28;
            this.lblFechat.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(65, 42);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(75, 19);
            this.lblFecha.TabIndex = 30;
            this.lblFecha.Text = "00/00/0000";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGuardar.Location = new System.Drawing.Point(197, 274);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(163, 54);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.dtcNombre.DataPropertyName = "NombreAlumno";
            this.dtcNombre.HeaderText = "Nombre";
            this.dtcNombre.Name = "dtcNombre";
            this.dtcNombre.ReadOnly = true;
            // 
            // dtcAsistio
            // 
            this.dtcAsistio.DataPropertyName = "Asistio";
            this.dtcAsistio.HeaderText = "Asistencia";
            this.dtcAsistio.Name = "dtcAsistio";
            this.dtcAsistio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtcAsistio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmSesionAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 341);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblFechat);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dtAlumnos);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSesionAsistencia";
            this.Text = "Asistencia";
            ((System.ComponentModel.ISupportInitialize)(this.dtAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtAlumnos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechat;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNoControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtcAsistio;
    }
}