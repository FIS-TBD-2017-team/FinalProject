namespace FinalProject.Frontend
{
    partial class FrmSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSesion));
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblFechat = new System.Windows.Forms.Label();
            this.lblHorat = new System.Windows.Forms.Label();
            this.lblLugart = new System.Windows.Forms.Label();
            this.lblNotast = new System.Windows.Forms.Label();
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.txtNotas = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sesión";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(13, 50);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(51, 19);
            this.lblEstatus.TabIndex = 1;
            this.lblEstatus.Text = "Estatus:";
            // 
            // lblFechat
            // 
            this.lblFechat.AutoSize = true;
            this.lblFechat.Location = new System.Drawing.Point(18, 110);
            this.lblFechat.Name = "lblFechat";
            this.lblFechat.Size = new System.Drawing.Size(46, 19);
            this.lblFechat.TabIndex = 2;
            this.lblFechat.Text = "Fecha:";
            // 
            // lblHorat
            // 
            this.lblHorat.AutoSize = true;
            this.lblHorat.Location = new System.Drawing.Point(23, 138);
            this.lblHorat.Name = "lblHorat";
            this.lblHorat.Size = new System.Drawing.Size(41, 19);
            this.lblHorat.TabIndex = 3;
            this.lblHorat.Text = "Hora:";
            // 
            // lblLugart
            // 
            this.lblLugart.AutoSize = true;
            this.lblLugart.Location = new System.Drawing.Point(18, 79);
            this.lblLugart.Name = "lblLugart";
            this.lblLugart.Size = new System.Drawing.Size(45, 19);
            this.lblLugart.TabIndex = 4;
            this.lblLugart.Text = "Lugar:";
            // 
            // lblNotast
            // 
            this.lblNotast.AutoSize = true;
            this.lblNotast.Location = new System.Drawing.Point(226, 50);
            this.lblNotast.Name = "lblNotast";
            this.lblNotast.Size = new System.Drawing.Size(46, 19);
            this.lblNotast.TabIndex = 8;
            this.lblNotast.Text = "Notas:";
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Items.AddRange(new object[] {
            "REALIZADA",
            "CANCELADA"});
            this.cmbEstatus.Location = new System.Drawing.Point(70, 47);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(150, 25);
            this.cmbEstatus.TabIndex = 23;
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(278, 47);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(314, 110);
            this.txtNotas.TabIndex = 24;
            this.txtNotas.Text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGuardar.Location = new System.Drawing.Point(429, 164);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(163, 54);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(70, 76);
            this.txtLugar.MaxLength = 32;
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(150, 25);
            this.txtLugar.TabIndex = 34;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(70, 104);
            this.dtpFecha.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(150, 25);
            this.dtpFecha.TabIndex = 36;
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(70, 132);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(150, 25);
            this.dtpHora.TabIndex = 37;
            this.dtpHora.Value = new System.DateTime(2017, 11, 24, 15, 54, 0, 0);
            // 
            // FrmSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 226);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.cmbEstatus);
            this.Controls.Add(this.lblNotast);
            this.Controls.Add(this.lblLugart);
            this.Controls.Add(this.lblHorat);
            this.Controls.Add(this.lblFechat);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSesion";
            this.Text = "Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label lblFechat;
        private System.Windows.Forms.Label lblHorat;
        private System.Windows.Forms.Label lblLugart;
        private System.Windows.Forms.Label lblNotast;
        private System.Windows.Forms.ComboBox cmbEstatus;
        private System.Windows.Forms.RichTextBox txtNotas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHora;
    }
}