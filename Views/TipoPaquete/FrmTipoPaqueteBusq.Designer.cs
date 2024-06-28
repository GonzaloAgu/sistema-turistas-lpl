namespace TurApp.Views
{
    partial class FrmTipoPaqueteBusq
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
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.NombreChk = new System.Windows.Forms.CheckBox();
            this.CodigoTxt = new System.Windows.Forms.TextBox();
            this.CodigoChk = new System.Windows.Forms.CheckBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.NivelChk = new System.Windows.Forms.CheckBox();
            this.NivelTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NombreTxt
            // 
            this.NombreTxt.Enabled = false;
            this.NombreTxt.Location = new System.Drawing.Point(296, 19);
            this.NombreTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(182, 20);
            this.NombreTxt.TabIndex = 3;
            // 
            // NombreChk
            // 
            this.NombreChk.AutoSize = true;
            this.NombreChk.Location = new System.Drawing.Point(220, 19);
            this.NombreChk.Margin = new System.Windows.Forms.Padding(2);
            this.NombreChk.Name = "NombreChk";
            this.NombreChk.Size = new System.Drawing.Size(63, 17);
            this.NombreChk.TabIndex = 2;
            this.NombreChk.Text = "Nombre";
            this.NombreChk.UseVisualStyleBackColor = true;
            this.NombreChk.CheckedChanged += new System.EventHandler(this.NombreChk_CheckedChanged);
            // 
            // CodigoTxt
            // 
            this.CodigoTxt.Enabled = false;
            this.CodigoTxt.Location = new System.Drawing.Point(74, 19);
            this.CodigoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CodigoTxt.Name = "CodigoTxt";
            this.CodigoTxt.Size = new System.Drawing.Size(123, 20);
            this.CodigoTxt.TabIndex = 5;
            // 
            // CodigoChk
            // 
            this.CodigoChk.AutoSize = true;
            this.CodigoChk.Location = new System.Drawing.Point(9, 18);
            this.CodigoChk.Margin = new System.Windows.Forms.Padding(2);
            this.CodigoChk.Name = "CodigoChk";
            this.CodigoChk.Size = new System.Drawing.Size(59, 17);
            this.CodigoChk.TabIndex = 4;
            this.CodigoChk.Text = "Código";
            this.CodigoChk.UseVisualStyleBackColor = true;
            this.CodigoChk.CheckedChanged += new System.EventHandler(this.CodigoChk_CheckedChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(373, 80);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 9;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(267, 80);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 8;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // NivelChk
            // 
            this.NivelChk.AutoSize = true;
            this.NivelChk.Location = new System.Drawing.Point(9, 57);
            this.NivelChk.Margin = new System.Windows.Forms.Padding(2);
            this.NivelChk.Name = "NivelChk";
            this.NivelChk.Size = new System.Drawing.Size(50, 17);
            this.NivelChk.TabIndex = 10;
            this.NivelChk.Text = "Nivel";
            this.NivelChk.UseVisualStyleBackColor = true;
            this.NivelChk.CheckedChanged += new System.EventHandler(this.NivelChk_CheckedChanged);
            // 
            // NivelTxt
            // 
            this.NivelTxt.Enabled = false;
            this.NivelTxt.Location = new System.Drawing.Point(74, 55);
            this.NivelTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NivelTxt.Name = "NivelTxt";
            this.NivelTxt.Size = new System.Drawing.Size(123, 20);
            this.NivelTxt.TabIndex = 11;
            // 
            // FrmTipoPaqueteBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 136);
            this.Controls.Add(this.NivelTxt);
            this.Controls.Add(this.NivelChk);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.CodigoTxt);
            this.Controls.Add(this.CodigoChk);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.NombreChk);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipoPaqueteBusq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Turista...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.CheckBox NombreChk;
        private System.Windows.Forms.TextBox CodigoTxt;
        private System.Windows.Forms.CheckBox CodigoChk;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.CheckBox NivelChk;
        private System.Windows.Forms.TextBox NivelTxt;
    }
}