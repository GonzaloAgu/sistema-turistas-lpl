namespace TurApp.Views
{
    partial class FrmTipoPaqueteAM
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NivelTxt = new System.Windows.Forms.TextBox();
            this.CodigoTxt = new System.Windows.Forms.TextBox();
            this.CodigoLbl = new System.Windows.Forms.Label();
            this.NivelLbl = new System.Windows.Forms.Label();
            this.DuracionTxt = new System.Windows.Forms.TextBox();
            this.DuracionLbl = new System.Windows.Forms.Label();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.DescripcionLbl = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.NombreLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.ErrorValidaTurista = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidaTurista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NivelTxt);
            this.groupBox1.Controls.Add(this.CodigoTxt);
            this.groupBox1.Controls.Add(this.CodigoLbl);
            this.groupBox1.Controls.Add(this.NivelLbl);
            this.groupBox1.Controls.Add(this.DuracionTxt);
            this.groupBox1.Controls.Add(this.DuracionLbl);
            this.groupBox1.Controls.Add(this.DescripcionTxt);
            this.groupBox1.Controls.Add(this.DescripcionLbl);
            this.groupBox1.Controls.Add(this.NombreTxt);
            this.groupBox1.Controls.Add(this.NombreLbl);
            this.groupBox1.Location = new System.Drawing.Point(9, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(292, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // NivelTxt
            // 
            this.NivelTxt.Location = new System.Drawing.Point(74, 151);
            this.NivelTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NivelTxt.Name = "NivelTxt";
            this.NivelTxt.Size = new System.Drawing.Size(166, 20);
            this.NivelTxt.TabIndex = 17;
            this.NivelTxt.Tag = "Nivel";
            // 
            // CodigoTxt
            // 
            this.CodigoTxt.Location = new System.Drawing.Point(74, 22);
            this.CodigoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CodigoTxt.MaxLength = 15;
            this.CodigoTxt.Name = "CodigoTxt";
            this.CodigoTxt.Size = new System.Drawing.Size(80, 20);
            this.CodigoTxt.TabIndex = 0;
            this.CodigoTxt.Tag = "Codigo";
            this.CodigoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DniTxt_KeyPress);
            // 
            // CodigoLbl
            // 
            this.CodigoLbl.AutoSize = true;
            this.CodigoLbl.Location = new System.Drawing.Point(10, 22);
            this.CodigoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CodigoLbl.Name = "CodigoLbl";
            this.CodigoLbl.Size = new System.Drawing.Size(40, 13);
            this.CodigoLbl.TabIndex = 16;
            this.CodigoLbl.Text = "&Código";
            // 
            // NivelLbl
            // 
            this.NivelLbl.AutoSize = true;
            this.NivelLbl.Location = new System.Drawing.Point(10, 154);
            this.NivelLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NivelLbl.Name = "NivelLbl";
            this.NivelLbl.Size = new System.Drawing.Size(31, 13);
            this.NivelLbl.TabIndex = 12;
            this.NivelLbl.Text = "Nivel";
            // 
            // DuracionTxt
            // 
            this.DuracionTxt.Location = new System.Drawing.Point(74, 119);
            this.DuracionTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DuracionTxt.Name = "DuracionTxt";
            this.DuracionTxt.Size = new System.Drawing.Size(166, 20);
            this.DuracionTxt.TabIndex = 3;
            this.DuracionTxt.Tag = "Duracion";
            // 
            // DuracionLbl
            // 
            this.DuracionLbl.AutoSize = true;
            this.DuracionLbl.Location = new System.Drawing.Point(10, 120);
            this.DuracionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DuracionLbl.Name = "DuracionLbl";
            this.DuracionLbl.Size = new System.Drawing.Size(50, 13);
            this.DuracionLbl.TabIndex = 10;
            this.DuracionLbl.Text = "Duración";
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(74, 86);
            this.DescripcionTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(166, 20);
            this.DescripcionTxt.TabIndex = 2;
            this.DescripcionTxt.Tag = "Descripcion";
            // 
            // DescripcionLbl
            // 
            this.DescripcionLbl.AutoSize = true;
            this.DescripcionLbl.Location = new System.Drawing.Point(10, 86);
            this.DescripcionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescripcionLbl.Name = "DescripcionLbl";
            this.DescripcionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescripcionLbl.TabIndex = 8;
            this.DescripcionLbl.Text = "Descripción";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(74, 51);
            this.NombreTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombreTxt.MaxLength = 90;
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(166, 20);
            this.NombreTxt.TabIndex = 1;
            this.NombreTxt.Tag = "Nombre";
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.Location = new System.Drawing.Point(10, 51);
            this.NombreLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(44, 13);
            this.NombreLbl.TabIndex = 2;
            this.NombreLbl.Text = "No&mbre";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(233, 207);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 12;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(145, 207);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 11;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // ErrorValidaTurista
            // 
            this.ErrorValidaTurista.ContainerControl = this;
            // 
            // FrmTipoPaqueteAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 251);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipoPaqueteAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Deactivate += new System.EventHandler(this.FrmTuristaAM_Deactivate);
            this.Load += new System.EventHandler(this.FrmpTipoPaqueteaAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidaTurista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Label NombreLbl;
        private System.Windows.Forms.Label NivelLbl;
        private System.Windows.Forms.TextBox DuracionTxt;
        private System.Windows.Forms.Label DuracionLbl;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.Label DescripcionLbl;
        private System.Windows.Forms.TextBox CodigoTxt;
        private System.Windows.Forms.Label CodigoLbl;
        private System.Windows.Forms.ErrorProvider ErrorValidaTurista;
        private System.Windows.Forms.TextBox NivelTxt;
    }
}