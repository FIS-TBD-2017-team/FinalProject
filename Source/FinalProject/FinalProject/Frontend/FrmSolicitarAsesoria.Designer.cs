namespace FinalProject.Frontend
{
    partial class FrmSolicitarAsesoria
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
            this.txtNoControl = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAgregarModulo = new System.Windows.Forms.Button();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoControl
            // 
            this.txtNoControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNoControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoControl.Location = new System.Drawing.Point(97, 15);
            this.txtNoControl.Name = "txtNoControl";
            this.txtNoControl.Size = new System.Drawing.Size(226, 22);
            this.txtNoControl.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(14, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 16);
            this.label20.TabIndex = 34;
            this.label20.Text = "No. Control:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Materia a solicitar:";
            // 
            // txtTema
            // 
            this.txtTema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTema.Location = new System.Drawing.Point(136, 302);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(239, 22);
            this.txtTema.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tema:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGuardar.Location = new System.Drawing.Point(308, 497);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 27);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Solicitar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label10.Location = new System.Drawing.Point(12, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 25);
            this.label10.TabIndex = 44;
            this.label10.Text = "Información de solicitud";
            // 
            // btnAgregarModulo
            // 
            this.btnAgregarModulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarModulo.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.btnAgregarModulo.Location = new System.Drawing.Point(244, 342);
            this.btnAgregarModulo.Name = "btnAgregarModulo";
            this.btnAgregarModulo.Size = new System.Drawing.Size(36, 23);
            this.btnAgregarModulo.TabIndex = 48;
            this.btnAgregarModulo.Text = "+";
            this.btnAgregarModulo.UseVisualStyleBackColor = true;
            this.btnAgregarModulo.Click += new System.EventHandler(this.btnAgregarModulo_Click);
            // 
            // cmbHora
            // 
            this.cmbHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.cmbHora.Location = new System.Drawing.Point(150, 344);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(88, 21);
            this.cmbHora.TabIndex = 47;
            // 
            // cmbDia
            // 
            this.cmbDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes"});
            this.cmbDia.Location = new System.Drawing.Point(32, 344);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(112, 21);
            this.cmbDia.TabIndex = 46;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(17, 371);
            this.txtHoras.Multiline = true;
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(375, 93);
            this.txtHoras.TabIndex = 50;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 128);
            this.dataGridView1.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Lista de alumnos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAgregar.Location = new System.Drawing.Point(330, 13);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(76, 27);
            this.btnAgregar.TabIndex = 53;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(136, 275);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(239, 21);
            this.cmbMateria.TabIndex = 54;
            // 
            // FrmSolicitarAsesoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 537);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.btnAgregarModulo);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNoControl);
            this.Controls.Add(this.label20);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSolicitarAsesoria";
            this.Text = "Solicitar Asesoria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNoControl;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAgregarModulo;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbMateria;
    }
}