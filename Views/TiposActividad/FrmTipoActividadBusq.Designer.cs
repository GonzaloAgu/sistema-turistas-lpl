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
            this.SuspendLayout();
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(215, 78);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(100, 22);
            this.nombretxt.TabIndex = 1;
            // 
            // buscarbtn
            // 
            this.buscarbtn.Location = new System.Drawing.Point(240, 167);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Size = new System.Drawing.Size(75, 23);
            this.buscarbtn.TabIndex = 2;
            this.buscarbtn.Text = "Buscar";
            this.buscarbtn.UseVisualStyleBackColor = true;
            this.buscarbtn.Click += new System.EventHandler(this.buscarbtn_Click_1);
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.Location = new System.Drawing.Point(47, 167);
            this.cancelarbtn.Name = "cancelarbtn";
            this.cancelarbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarbtn.TabIndex = 3;
            this.cancelarbtn.Text = "Cancelar";
            this.cancelarbtn.UseVisualStyleBackColor = true;
            // 
            // nombreChk
            // 
            this.nombreChk.AutoSize = true;
            this.nombreChk.Location = new System.Drawing.Point(47, 80);
            this.nombreChk.Name = "nombreChk";
            this.nombreChk.Size = new System.Drawing.Size(80, 21);
            this.nombreChk.TabIndex = 4;
            this.nombreChk.Text = "Nombre";
            this.nombreChk.UseVisualStyleBackColor = true;
            // 
            // FrmTipoActividadBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 309);
            this.Controls.Add(this.nombreChk);
            this.Controls.Add(this.cancelarbtn);
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.nombretxt);
            this.Name = "FrmTipoActividadBusq";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.FrmTipoActividadBusq_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.Button buscarbtn;
        private System.Windows.Forms.Button cancelarbtn;
        private System.Windows.Forms.CheckBox nombreChk;
    }
}