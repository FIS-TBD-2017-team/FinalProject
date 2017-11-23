namespace FinalProject.Frontend
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lnkSalir = new System.Windows.Forms.LinkLabel();
            this.lblMensajeBienvenida = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dtListaAsesorias = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaAsesorias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlLeft.Controls.Add(this.btnAdministrar);
            this.pnlLeft.Controls.Add(this.btnAtender);
            this.pnlLeft.Controls.Add(this.btnConsultar);
            this.pnlLeft.Controls.Add(this.btnSolicitar);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(152, 467);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdministrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdministrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrar.ForeColor = System.Drawing.Color.White;
            this.btnAdministrar.Location = new System.Drawing.Point(10, 394);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(130, 60);
            this.btnAdministrar.TabIndex = 3;
            this.btnAdministrar.Text = "Administrar asesores";
            this.btnAdministrar.UseVisualStyleBackColor = true;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtender.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtender.ForeColor = System.Drawing.Color.White;
            this.btnAtender.Location = new System.Drawing.Point(10, 144);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(130, 60);
            this.btnAtender.TabIndex = 1;
            this.btnAtender.Text = "Atender solicitudes";
            this.btnAtender.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(10, 79);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(130, 60);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar solicitudes";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolicitar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitar.ForeColor = System.Drawing.Color.White;
            this.btnSolicitar.Location = new System.Drawing.Point(10, 13);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(130, 60);
            this.btnSolicitar.TabIndex = 0;
            this.btnSolicitar.Text = "&Solicitar asesoría";
            this.btnSolicitar.UseVisualStyleBackColor = true;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlTop.Controls.Add(this.lnkSalir);
            this.pnlTop.Controls.Add(this.lblMensajeBienvenida);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(864, 34);
            this.pnlTop.TabIndex = 1;
            // 
            // lnkSalir
            // 
            this.lnkSalir.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.lnkSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSalir.AutoSize = true;
            this.lnkSalir.LinkColor = System.Drawing.Color.White;
            this.lnkSalir.Location = new System.Drawing.Point(775, 10);
            this.lnkSalir.Name = "lnkSalir";
            this.lnkSalir.Size = new System.Drawing.Size(86, 19);
            this.lnkSalir.TabIndex = 1;
            this.lnkSalir.TabStop = true;
            this.lnkSalir.Text = "Cerrar sesión";
            this.lnkSalir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSalir_LinkClicked);
            // 
            // lblMensajeBienvenida
            // 
            this.lblMensajeBienvenida.AutoSize = true;
            this.lblMensajeBienvenida.Location = new System.Drawing.Point(10, 10);
            this.lblMensajeBienvenida.Name = "lblMensajeBienvenida";
            this.lblMensajeBienvenida.Size = new System.Drawing.Size(138, 19);
            this.lblMensajeBienvenida.TabIndex = 0;
            this.lblMensajeBienvenida.Text = "Bienvenido: Persona X";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlMain);
            this.pnlBottom.Controls.Add(this.pnlLeft);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 34);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(864, 467);
            this.pnlBottom.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dtListaAsesorias);
            this.pnlMain.Controls.Add(this.lblTitulo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(152, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(712, 467);
            this.pnlMain.TabIndex = 2;
            // 
            // dtListaAsesorias
            // 
            this.dtListaAsesorias.AllowUserToAddRows = false;
            this.dtListaAsesorias.AllowUserToDeleteRows = false;
            this.dtListaAsesorias.AllowUserToResizeRows = false;
            this.dtListaAsesorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtListaAsesorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtListaAsesorias.BackgroundColor = System.Drawing.Color.White;
            this.dtListaAsesorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtListaAsesorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtListaAsesorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtListaAsesorias.ColumnHeadersHeight = 45;
            this.dtListaAsesorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtListaAsesorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtListaAsesorias.EnableHeadersVisualStyles = false;
            this.dtListaAsesorias.Location = new System.Drawing.Point(13, 53);
            this.dtListaAsesorias.Name = "dtListaAsesorias";
            this.dtListaAsesorias.ReadOnly = true;
            this.dtListaAsesorias.RowHeadersVisible = false;
            this.dtListaAsesorias.RowHeadersWidth = 45;
            this.dtListaAsesorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtListaAsesorias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtListaAsesorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListaAsesorias.Size = new System.Drawing.Size(687, 401);
            this.dtListaAsesorias.TabIndex = 1;
            this.dtListaAsesorias.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListaAsesorias_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdAsesoria";
            this.Column1.FillWeight = 126.9036F;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NombreMateria";
            this.Column2.FillWeight = 93.27411F;
            this.Column2.HeaderText = "Materia";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NoControl";
            this.Column3.FillWeight = 93.27411F;
            this.Column3.HeaderText = "No. Control del asesor";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NombreAsesor";
            this.Column4.FillWeight = 93.27411F;
            this.Column4.HeaderText = "Nombre del asesor";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.lblTitulo.Location = new System.Drawing.Point(6, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Asesorías en curso";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 501);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.pnlLeft.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaAsesorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Button btnAdministrar;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblMensajeBienvenida;
        private System.Windows.Forms.LinkLabel lnkSalir;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dtListaAsesorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}