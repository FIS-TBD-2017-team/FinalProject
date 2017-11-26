namespace FinalProject.Frontend
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRepAsesores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes";
            // 
            // btnRepAsesores
            // 
            this.btnRepAsesores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepAsesores.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnRepAsesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepAsesores.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnRepAsesores.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRepAsesores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRepAsesores.Location = new System.Drawing.Point(17, 59);
            this.btnRepAsesores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRepAsesores.Name = "btnRepAsesores";
            this.btnRepAsesores.Size = new System.Drawing.Size(225, 35);
            this.btnRepAsesores.TabIndex = 32;
            this.btnRepAsesores.Text = "Reporte de asesores";
            this.btnRepAsesores.UseVisualStyleBackColor = true;
            this.btnRepAsesores.Click += new System.EventHandler(this.btnRepAsesores_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(254, 113);
            this.Controls.Add(this.btnRepAsesores);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRepAsesores;
    }
}