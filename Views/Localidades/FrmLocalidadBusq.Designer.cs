namespace TurApp.Views
{
    partial class FrmLocalidadBusq
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
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.CodPostalTxt = new System.Windows.Forms.TextBox();
            this.CodPostalChk = new System.Windows.Forms.CheckBox();
            this.NombreLocalidadTxt = new System.Windows.Forms.TextBox();
            this.NombreLocalidadChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(444, 81);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 17;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click_1);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(355, 81);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 16;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // CodPostalTxt
            // 
            this.CodPostalTxt.Enabled = false;
            this.CodPostalTxt.Location = new System.Drawing.Point(107, 19);
            this.CodPostalTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CodPostalTxt.Name = "CodPostalTxt";
            this.CodPostalTxt.Size = new System.Drawing.Size(123, 20);
            this.CodPostalTxt.TabIndex = 15;
            // 
            // CodPostalChk
            // 
            this.CodPostalChk.AutoSize = true;
            this.CodPostalChk.Location = new System.Drawing.Point(12, 19);
            this.CodPostalChk.Margin = new System.Windows.Forms.Padding(2);
            this.CodPostalChk.Name = "CodPostalChk";
            this.CodPostalChk.Size = new System.Drawing.Size(91, 17);
            this.CodPostalChk.TabIndex = 14;
            this.CodPostalChk.Text = "Codigo Postal";
            this.CodPostalChk.UseVisualStyleBackColor = true;
            this.CodPostalChk.CheckedChanged += new System.EventHandler(this.CodPostalChk_CheckedChanged);
            // 
            // NombreLocalidadTxt
            // 
            this.NombreLocalidadTxt.Enabled = false;
            this.NombreLocalidadTxt.Location = new System.Drawing.Point(355, 20);
            this.NombreLocalidadTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombreLocalidadTxt.Name = "NombreLocalidadTxt";
            this.NombreLocalidadTxt.Size = new System.Drawing.Size(182, 20);
            this.NombreLocalidadTxt.TabIndex = 13;
            // 
            // NombreLocalidadChk
            // 
            this.NombreLocalidadChk.AutoSize = true;
            this.NombreLocalidadChk.Location = new System.Drawing.Point(280, 20);
            this.NombreLocalidadChk.Margin = new System.Windows.Forms.Padding(2);
            this.NombreLocalidadChk.Name = "NombreLocalidadChk";
            this.NombreLocalidadChk.Size = new System.Drawing.Size(63, 17);
            this.NombreLocalidadChk.TabIndex = 12;
            this.NombreLocalidadChk.Text = "Nombre";
            this.NombreLocalidadChk.UseVisualStyleBackColor = true;
            this.NombreLocalidadChk.CheckedChanged += new System.EventHandler(this.NombreLocalidadChk_CheckedChanged);
            // 
            // FrmLocalidadBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 133);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.CodPostalTxt);
            this.Controls.Add(this.CodPostalChk);
            this.Controls.Add(this.NombreLocalidadTxt);
            this.Controls.Add(this.NombreLocalidadChk);
            this.Name = "FrmLocalidadBusq";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.TextBox CodPostalTxt;
        private System.Windows.Forms.CheckBox CodPostalChk;
        private System.Windows.Forms.TextBox NombreLocalidadTxt;
        private System.Windows.Forms.CheckBox NombreLocalidadChk;
    }
}