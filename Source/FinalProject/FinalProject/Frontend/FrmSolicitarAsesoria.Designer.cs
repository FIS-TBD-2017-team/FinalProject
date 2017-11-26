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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lnkSalir = new System.Windows.Forms.LinkLabel();
            this.txtNoControl = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoControlt = new System.Windows.Forms.Label();
            this.lblNoControl = new System.Windows.Forms.Label();
            this.lblNombret = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCarrerat = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblSemestret = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNoSemestre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlTop.Controls.Add(this.lnkSalir);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(418, 34);
            this.pnlTop.TabIndex = 2;
            // 
            // lnkSalir
            // 
            this.lnkSalir.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.lnkSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSalir.AutoSize = true;
            this.lnkSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSalir.LinkColor = System.Drawing.Color.White;
            this.lnkSalir.Location = new System.Drawing.Point(316, 9);
            this.lnkSalir.Name = "lnkSalir";
            this.lnkSalir.Size = new System.Drawing.Size(103, 16);
            this.lnkSalir.TabIndex = 1;
            this.lnkSalir.TabStop = true;
            this.lnkSalir.Text = "Asesoría grupal";
            // 
            // txtNoControl
            // 
            this.txtNoControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNoControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoControl.Location = new System.Drawing.Point(95, 55);
            this.txtNoControl.Name = "txtNoControl";
            this.txtNoControl.Size = new System.Drawing.Size(226, 22);
            this.txtNoControl.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 16);
            this.label20.TabIndex = 34;
            this.label20.Text = "No. Control:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAlumno.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnBuscarAlumno.Location = new System.Drawing.Point(327, 54);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(63, 23);
            this.btnBuscarAlumno.TabIndex = 36;
            this.btnBuscarAlumno.Text = "Buscar";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.btnBuscarAlumno_Click);
            // 
            // cmbMateria
            // 
            this.cmbMateria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes"});
            this.cmbMateria.Location = new System.Drawing.Point(154, 297);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(236, 21);
            this.cmbMateria.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Materia a solicitar:";
            // 
            // txtTema
            // 
            this.txtTema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTema.Location = new System.Drawing.Point(151, 324);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(239, 22);
            this.txtTema.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 327);
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
            this.btnGuardar.Location = new System.Drawing.Point(305, 363);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 30);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Solicitar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button1.Location = new System.Drawing.Point(198, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 42;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label5.Location = new System.Drawing.Point(17, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Información personal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Correo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNoControlt
            // 
            this.lblNoControlt.AutoSize = true;
            this.lblNoControlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoControlt.Location = new System.Drawing.Point(41, 125);
            this.lblNoControlt.Name = "lblNoControlt";
            this.lblNoControlt.Size = new System.Drawing.Size(77, 16);
            this.lblNoControlt.TabIndex = 1;
            this.lblNoControlt.Text = "No. Control:";
            this.lblNoControlt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNoControl
            // 
            this.lblNoControl.AutoSize = true;
            this.lblNoControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoControl.Location = new System.Drawing.Point(123, 125);
            this.lblNoControl.Name = "lblNoControl";
            this.lblNoControl.Size = new System.Drawing.Size(12, 16);
            this.lblNoControl.TabIndex = 2;
            this.lblNoControl.Text = "-";
            // 
            // lblNombret
            // 
            this.lblNombret.AutoSize = true;
            this.lblNombret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombret.Location = new System.Drawing.Point(58, 150);
            this.lblNombret.Name = "lblNombret";
            this.lblNombret.Size = new System.Drawing.Size(60, 16);
            this.lblNombret.TabIndex = 3;
            this.lblNombret.Text = "Nombre:";
            this.lblNombret.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(123, 150);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(12, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "-";
            // 
            // lblCarrerat
            // 
            this.lblCarrerat.AutoSize = true;
            this.lblCarrerat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrerat.Location = new System.Drawing.Point(62, 175);
            this.lblCarrerat.Name = "lblCarrerat";
            this.lblCarrerat.Size = new System.Drawing.Size(56, 16);
            this.lblCarrerat.TabIndex = 5;
            this.lblCarrerat.Text = "Carrera:";
            this.lblCarrerat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(123, 175);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(12, 16);
            this.lblCarrera.TabIndex = 6;
            this.lblCarrera.Text = "-";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestre.Location = new System.Drawing.Point(124, 201);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(15, 16);
            this.lblSemestre.TabIndex = 8;
            this.lblSemestre.Text = "5";
            // 
            // lblSemestret
            // 
            this.lblSemestret.AutoSize = true;
            this.lblSemestret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestret.Location = new System.Drawing.Point(49, 201);
            this.lblSemestret.Name = "lblSemestret";
            this.lblSemestret.Size = new System.Drawing.Size(69, 16);
            this.lblSemestret.TabIndex = 7;
            this.lblSemestret.Text = "Semestre:";
            this.lblSemestret.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Semestre:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNoSemestre
            // 
            this.lblNoSemestre.AutoSize = true;
            this.lblNoSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSemestre.Location = new System.Drawing.Point(124, 201);
            this.lblNoSemestre.Name = "lblNoSemestre";
            this.lblNoSemestre.Size = new System.Drawing.Size(12, 16);
            this.lblNoSemestre.TabIndex = 8;
            this.lblNoSemestre.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Correo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(123, 227);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(12, 16);
            this.lblCorreo.TabIndex = 11;
            this.lblCorreo.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label10.Location = new System.Drawing.Point(17, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 25);
            this.label10.TabIndex = 44;
            this.label10.Text = "Información de solicitud";
            // 
            // FrmSolicitarAsesoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 406);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNoSemestre);
            this.Controls.Add(this.lblSemestre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNoControlt);
            this.Controls.Add(this.lblSemestret);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNoControl);
            this.Controls.Add(this.lblNombret);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCarrerat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.btnBuscarAlumno);
            this.Controls.Add(this.txtNoControl);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSolicitarAsesoria";
            this.Text = "Solicitar Asesoria";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.LinkLabel lnkSalir;
        private System.Windows.Forms.TextBox txtNoControl;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNoControlt;
        private System.Windows.Forms.Label lblNoControl;
        private System.Windows.Forms.Label lblNombret;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCarrerat;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblSemestret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNoSemestre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label label10;
    }
}