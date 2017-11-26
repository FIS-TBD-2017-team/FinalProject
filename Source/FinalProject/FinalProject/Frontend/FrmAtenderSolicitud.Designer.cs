namespace FinalProject.Frontend
{
    partial class FrmAtenderSolicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtenderSolicitud));
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
            this.dtcProponer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblSubAsesores = new System.Windows.Forms.Label();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnDesignar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.lblTitulo.Size = new System.Drawing.Size(170, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Atender solicitud";
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
            this.lblMateria.Location = new System.Drawing.Point(85, 67);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(53, 19);
            this.lblMateria.TabIndex = 4;
            this.lblMateria.Text = "Metdos";
            // 
            // lblMateriat
            // 
            this.lblMateriat.AutoSize = true;
            this.lblMateriat.Location = new System.Drawing.Point(23, 67);
            this.lblMateriat.Name = "lblMateriat";
            this.lblMateriat.Size = new System.Drawing.Size(57, 19);
            this.lblMateriat.TabIndex = 5;
            this.lblMateriat.Text = "Materia:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(86, 48);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 19);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "1";
            // 
            // lblIdt
            // 
            this.lblIdt.AutoSize = true;
            this.lblIdt.Location = new System.Drawing.Point(56, 48);
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
            this.dtAlumnos.Enabled = false;
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
            this.dtAlumnos.Size = new System.Drawing.Size(572, 171);
            this.dtAlumnos.TabIndex = 16;
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
            this.txtNotas.Size = new System.Drawing.Size(291, 62);
            this.txtNotas.TabIndex = 19;
            this.txtNotas.Text = "";
            // 
            // lblHorariot
            // 
            this.lblHorariot.AutoSize = true;
            this.lblHorariot.Location = new System.Drawing.Point(22, 86);
            this.lblHorariot.Name = "lblHorariot";
            this.lblHorariot.Size = new System.Drawing.Size(57, 19);
            this.lblHorariot.TabIndex = 21;
            this.lblHorariot.Text = "Horario:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(84, 86);
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
            this.dataGridViewTextBoxColumn4,
            this.dtcProponer});
            this.dtAsesores.EnableHeadersVisualStyles = false;
            this.dtAsesores.Location = new System.Drawing.Point(16, 355);
            this.dtAsesores.MultiSelect = false;
            this.dtAsesores.Name = "dtAsesores";
            this.dtAsesores.RowHeadersVisible = false;
            this.dtAsesores.RowHeadersWidth = 45;
            this.dtAsesores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtAsesores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtAsesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtAsesores.Size = new System.Drawing.Size(572, 171);
            this.dtAsesores.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoControl";
            this.dataGridViewTextBoxColumn1.HeaderText = "No. Control";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreCompleto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NombreCarrera";
            this.dataGridViewTextBoxColumn3.HeaderText = "Carrera";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dtcProponer
            // 
            this.dtcProponer.HeaderText = "Proponer";
            this.dtcProponer.Name = "dtcProponer";
            this.dtcProponer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtcProponer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblSubAsesores
            // 
            this.lblSubAsesores.AutoSize = true;
            this.lblSubAsesores.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lblSubAsesores.Location = new System.Drawing.Point(12, 327);
            this.lblSubAsesores.Name = "lblSubAsesores";
            this.lblSubAsesores.Size = new System.Drawing.Size(159, 25);
            this.lblSubAsesores.TabIndex = 22;
            this.lblSubAsesores.Text = "Proponer asesores";
            // 
            // btnRechazar
            // 
            this.btnRechazar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazar.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnRechazar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRechazar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRechazar.Location = new System.Drawing.Point(16, 533);
            this.btnRechazar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(163, 54);
            this.btnRechazar.TabIndex = 33;
            this.btnRechazar.Text = "Rechazar solicitud";
            this.btnRechazar.UseVisualStyleBackColor = true;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // btnDesignar
            // 
            this.btnDesignar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesignar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnDesignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesignar.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnDesignar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDesignar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDesignar.Location = new System.Drawing.Point(425, 532);
            this.btnDesignar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDesignar.Name = "btnDesignar";
            this.btnDesignar.Size = new System.Drawing.Size(163, 54);
            this.btnDesignar.TabIndex = 34;
            this.btnDesignar.Text = "Designar asesores";
            this.btnDesignar.UseVisualStyleBackColor = true;
            this.btnDesignar.Click += new System.EventHandler(this.btnDesignar_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(205, 586);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 10);
            this.panel2.TabIndex = 35;
            this.panel2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(209, 532);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 10);
            this.panel1.TabIndex = 36;
            // 
            // FrmAtenderSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDesignar);
            this.Controls.Add(this.btnRechazar);
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
            this.Name = "FrmAtenderSolicitud";
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
        private System.Windows.Forms.Label lblSubAsesores;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnDesignar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtcProponer;
    }
}