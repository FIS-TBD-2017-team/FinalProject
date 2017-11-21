namespace FinalProject.Frontend
{
    partial class FrmListaAsesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaAsesores));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtListaAsesorias = new System.Windows.Forms.DataGridView();
            this.dtcNoControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaAsesorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.lblTitulo.Location = new System.Drawing.Point(5, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(204, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Lista de asesores";
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
            this.dtcNoControl,
            this.dtcNombre,
            this.dtcCarrera,
            this.dtcCorreo,
            this.dtcTelefono});
            this.dtListaAsesorias.EnableHeadersVisualStyles = false;
            this.dtListaAsesorias.Location = new System.Drawing.Point(12, 49);
            this.dtListaAsesorias.MultiSelect = false;
            this.dtListaAsesorias.Name = "dtListaAsesorias";
            this.dtListaAsesorias.ReadOnly = true;
            this.dtListaAsesorias.RowHeadersVisible = false;
            this.dtListaAsesorias.RowHeadersWidth = 45;
            this.dtListaAsesorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtListaAsesorias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtListaAsesorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListaAsesorias.Size = new System.Drawing.Size(516, 332);
            this.dtListaAsesorias.TabIndex = 2;
            this.dtListaAsesorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListaAsesorias_CellDoubleClick);
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
            this.dtcCarrera.DataPropertyName = "Carrera";
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
            // dtcTelefono
            // 
            this.dtcTelefono.DataPropertyName = "Telefono";
            this.dtcTelefono.HeaderText = "Teléfono";
            this.dtcTelefono.Name = "dtcTelefono";
            this.dtcTelefono.ReadOnly = true;
            // 
            // FrmListaAsesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 393);
            this.Controls.Add(this.dtListaAsesorias);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmListaAsesores";
            this.Text = "Administrar asesores";
            ((System.ComponentModel.ISupportInitialize)(this.dtListaAsesorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dtListaAsesorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNoControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTelefono;
    }
}