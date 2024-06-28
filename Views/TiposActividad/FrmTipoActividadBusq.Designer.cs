namespace TurApp.Views
{
    partial class FrmTipoActividadBusq
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
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.buscarbtn = new System.Windows.Forms.Button();
            this.cancelarbtn = new System.Windows.Forms.Button();
            this.nombreChk = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombretxt
            // 
            this.nombretxt.Enabled = false;
            this.nombretxt.Location = new System.Drawing.Point(84, 15);
            this.nombretxt.Margin = new System.Windows.Forms.Padding(2);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(186, 20);
            this.nombretxt.TabIndex = 3;
            // 
            // buscarbtn
            // 
            this.buscarbtn.Location = new System.Drawing.Point(215, 72);
            this.buscarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Size = new System.Drawing.Size(75, 23);
            this.buscarbtn.TabIndex = 5;
            this.buscarbtn.Text = "Buscar";
            this.buscarbtn.UseVisualStyleBackColor = true;
            this.buscarbtn.Click += new System.EventHandler(this.buscarbtn_Click_1);
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.Location = new System.Drawing.Point(136, 72);
            this.cancelarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelarbtn.Name = "cancelarbtn";
            this.cancelarbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarbtn.TabIndex = 4;
            this.cancelarbtn.Text = "Cancelar";
            this.cancelarbtn.UseVisualStyleBackColor = true;
            this.cancelarbtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // nombreChk
            // 
            this.nombreChk.AutoSize = true;
            this.nombreChk.Location = new System.Drawing.Point(16, 18);
            this.nombreChk.Margin = new System.Windows.Forms.Padding(2);
            this.nombreChk.Name = "nombreChk";
            this.nombreChk.Size = new System.Drawing.Size(63, 17);
            this.nombreChk.TabIndex = 2;
            this.nombreChk.Text = "Nombre";
            this.nombreChk.UseVisualStyleBackColor = true;
            this.nombreChk.CheckedChanged += new System.EventHandler(this.NombreChk_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nombreChk);
            this.groupBox1.Controls.Add(this.nombretxt);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // FrmTipoActividadBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 109);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelarbtn);
            this.Controls.Add(this.buscarbtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTipoActividadBusq";
            this.Text = "Búsqueda de Tipo Actividad...";
            this.Activated += new System.EventHandler(this.FrmTipoActividadBusq_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.Button buscarbtn;
        private System.Windows.Forms.Button cancelarbtn;
        private System.Windows.Forms.CheckBox nombreChk;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}