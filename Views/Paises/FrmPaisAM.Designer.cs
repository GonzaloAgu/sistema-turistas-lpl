namespace TurApp.Views
{
    partial class FrmPaisAM
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
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.NombreLbl = new System.Windows.Forms.Label();
            this.NombrePaisTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(230, 103);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 2;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(137, 103);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 3;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.Location = new System.Drawing.Point(18, 33);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(44, 13);
            this.NombreLbl.TabIndex = 2;
            this.NombreLbl.Text = "Nombre";
            this.NombreLbl.Click += new System.EventHandler(this.NombreLbl_Click);
            // 
            // NombrePaisTxt
            // 
            this.NombrePaisTxt.Location = new System.Drawing.Point(73, 30);
            this.NombrePaisTxt.Name = "NombrePaisTxt";
            this.NombrePaisTxt.Size = new System.Drawing.Size(196, 20);
            this.NombrePaisTxt.TabIndex = 1;
            this.NombrePaisTxt.Tag = "Nombre";
            this.NombrePaisTxt.TextChanged += new System.EventHandler(this.NombrePaisTxt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombrePaisTxt);
            this.groupBox1.Controls.Add(this.NombreLbl);
            this.groupBox1.Location = new System.Drawing.Point(19, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // FrmPaisAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 147);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Name = "FrmPaisAM";
            this.Text = "Ingreso de país...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Label NombreLbl;
        private System.Windows.Forms.TextBox NombrePaisTxt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}