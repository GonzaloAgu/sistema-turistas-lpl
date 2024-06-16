namespace TurApp.Views {
    partial class FrmFormaPagoAM {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.formaTxt = new System.Windows.Forms.TextBox();
            this.formaLbl = new System.Windows.Forms.Label();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(41, 96);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 6;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.formaTxt);
            this.groupBox1.Controls.Add(this.formaLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 79);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // formaTxt
            // 
            this.formaTxt.Location = new System.Drawing.Point(70, 32);
            this.formaTxt.Name = "formaTxt";
            this.formaTxt.Size = new System.Drawing.Size(167, 20);
            this.formaTxt.TabIndex = 7;
            this.formaTxt.Tag = "Forma";
            // 
            // formaLbl
            // 
            this.formaLbl.AutoSize = true;
            this.formaLbl.Location = new System.Drawing.Point(26, 35);
            this.formaLbl.Name = "formaLbl";
            this.formaLbl.Size = new System.Drawing.Size(36, 13);
            this.formaLbl.TabIndex = 5;
            this.formaLbl.Text = "Forma";
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(174, 97);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 4;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // FrmFormaPagoAM
            // 
            this.AccessibleDescription = "Alta forma de pago";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GuardarBtn);
            this.Name = "FrmFormaPagoAM";
            this.Text = "Alta forma de pago";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox formaTxt;
        private System.Windows.Forms.Label formaLbl;
        private System.Windows.Forms.Button GuardarBtn;
    }
}