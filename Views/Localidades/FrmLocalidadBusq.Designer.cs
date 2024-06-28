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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(151, 97);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 6;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click_1);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(231, 97);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 5;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // CodPostalTxt
            // 
            this.CodPostalTxt.Enabled = false;
            this.CodPostalTxt.Location = new System.Drawing.Point(109, 18);
            this.CodPostalTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CodPostalTxt.Name = "CodPostalTxt";
            this.CodPostalTxt.Size = new System.Drawing.Size(89, 20);
            this.CodPostalTxt.TabIndex = 2;
            this.CodPostalTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodPostalTxt_KeyPress);
            // 
            // CodPostalChk
            // 
            this.CodPostalChk.AutoSize = true;
            this.CodPostalChk.Location = new System.Drawing.Point(14, 21);
            this.CodPostalChk.Margin = new System.Windows.Forms.Padding(2);
            this.CodPostalChk.Name = "CodPostalChk";
            this.CodPostalChk.Size = new System.Drawing.Size(91, 17);
            this.CodPostalChk.TabIndex = 1;
            this.CodPostalChk.Text = "Codigo Postal";
            this.CodPostalChk.UseVisualStyleBackColor = true;
            this.CodPostalChk.CheckedChanged += new System.EventHandler(this.CodPostalChk_CheckedChanged);
            // 
            // NombreLocalidadTxt
            // 
            this.NombreLocalidadTxt.Enabled = false;
            this.NombreLocalidadTxt.Location = new System.Drawing.Point(109, 51);
            this.NombreLocalidadTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombreLocalidadTxt.Name = "NombreLocalidadTxt";
            this.NombreLocalidadTxt.Size = new System.Drawing.Size(164, 20);
            this.NombreLocalidadTxt.TabIndex = 4;
            // 
            // NombreLocalidadChk
            // 
            this.NombreLocalidadChk.AutoSize = true;
            this.NombreLocalidadChk.Location = new System.Drawing.Point(14, 51);
            this.NombreLocalidadChk.Margin = new System.Windows.Forms.Padding(2);
            this.NombreLocalidadChk.Name = "NombreLocalidadChk";
            this.NombreLocalidadChk.Size = new System.Drawing.Size(63, 17);
            this.NombreLocalidadChk.TabIndex = 3;
            this.NombreLocalidadChk.Text = "Nombre";
            this.NombreLocalidadChk.UseVisualStyleBackColor = true;
            this.NombreLocalidadChk.CheckedChanged += new System.EventHandler(this.NombreLocalidadChk_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CodPostalTxt);
            this.groupBox1.Controls.Add(this.CodPostalChk);
            this.groupBox1.Controls.Add(this.NombreLocalidadTxt);
            this.groupBox1.Controls.Add(this.NombreLocalidadChk);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // FrmLocalidadBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 133);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Name = "FrmLocalidadBusq";
            this.Text = "Búsqueda de localidades...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.TextBox CodPostalTxt;
        private System.Windows.Forms.CheckBox CodPostalChk;
        private System.Windows.Forms.TextBox NombreLocalidadTxt;
        private System.Windows.Forms.CheckBox NombreLocalidadChk;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}