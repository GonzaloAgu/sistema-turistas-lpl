namespace TurApp.Views
{
    partial class FrmPaqueteAM
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
            this.NivelTxt = new System.Windows.Forms.ComboBox();
            this.Nivel = new System.Windows.Forms.Label();
            this.CodPaqTxt = new System.Windows.Forms.TextBox();
            this.CodPaq = new System.Windows.Forms.Label();
            this.DniTurTxt = new System.Windows.Forms.ComboBox();
            this.DniTur = new System.Windows.Forms.Label();
            this.FechaTxt = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.CodAgeTxt = new System.Windows.Forms.TextBox();
            this.CodAge = new System.Windows.Forms.Label();
            this.CodTPTxt = new System.Windows.Forms.TextBox();
            this.CodTP = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.ErrorValidaTurista = new System.Windows.Forms.ErrorProvider(this.components);
            this.CodDestino = new System.Windows.Forms.Label();
            this.CodDestinoTxt = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidaTurista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CodDestinoTxt);
            this.groupBox1.Controls.Add(this.CodDestino);
            this.groupBox1.Controls.Add(this.NivelTxt);
            this.groupBox1.Controls.Add(this.Nivel);
            this.groupBox1.Controls.Add(this.CodPaqTxt);
            this.groupBox1.Controls.Add(this.CodPaq);
            this.groupBox1.Controls.Add(this.DniTurTxt);
            this.groupBox1.Controls.Add(this.DniTur);
            this.groupBox1.Controls.Add(this.FechaTxt);
            this.groupBox1.Controls.Add(this.Fecha);
            this.groupBox1.Controls.Add(this.CodAgeTxt);
            this.groupBox1.Controls.Add(this.CodAge);
            this.groupBox1.Controls.Add(this.CodTPTxt);
            this.groupBox1.Controls.Add(this.CodTP);
            this.groupBox1.Location = new System.Drawing.Point(9, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(292, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // NivelTxt
            // 
            this.NivelTxt.DisplayMember = "Nombre";
            this.NivelTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.NivelTxt.FormattingEnabled = true;
            this.NivelTxt.Location = new System.Drawing.Point(84, 183);
            this.NivelTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NivelTxt.Name = "NivelTxt";
            this.NivelTxt.Size = new System.Drawing.Size(80, 21);
            this.NivelTxt.TabIndex = 18;
            this.NivelTxt.Tag = "Nivel";
            this.NivelTxt.ValueMember = "Id";
            // 
            // Nivel
            // 
            this.Nivel.AutoSize = true;
            this.Nivel.Location = new System.Drawing.Point(10, 186);
            this.Nivel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nivel.Name = "Nivel";
            this.Nivel.Size = new System.Drawing.Size(31, 13);
            this.Nivel.TabIndex = 17;
            this.Nivel.Text = "&Nivel";
            // 
            // CodPaqTxt
            // 
            this.CodPaqTxt.Location = new System.Drawing.Point(84, 22);
            this.CodPaqTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CodPaqTxt.MaxLength = 15;
            this.CodPaqTxt.Name = "CodPaqTxt";
            this.CodPaqTxt.Size = new System.Drawing.Size(80, 20);
            this.CodPaqTxt.TabIndex = 0;
            this.CodPaqTxt.Tag = "NroDocumento";
            // 
            // CodPaq
            // 
            this.CodPaq.AutoSize = true;
            this.CodPaq.Location = new System.Drawing.Point(10, 22);
            this.CodPaq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CodPaq.Name = "CodPaq";
            this.CodPaq.Size = new System.Drawing.Size(72, 13);
            this.CodPaq.TabIndex = 16;
            this.CodPaq.Text = "&Cod. Paquete";
            this.CodPaq.Click += new System.EventHandler(this.DniLbl_Click);
            // 
            // DniTurTxt
            // 
            this.DniTurTxt.DisplayMember = "Nombre";
            this.DniTurTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.DniTurTxt.FormattingEnabled = true;
            this.DniTurTxt.Location = new System.Drawing.Point(84, 150);
            this.DniTurTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DniTurTxt.Name = "DniTurTxt";
            this.DniTurTxt.Size = new System.Drawing.Size(166, 21);
            this.DniTurTxt.TabIndex = 4;
            this.DniTurTxt.Tag = "CodPais";
            this.DniTurTxt.ValueMember = "Id";
            // 
            // DniTur
            // 
            this.DniTur.AutoSize = true;
            this.DniTur.Location = new System.Drawing.Point(10, 154);
            this.DniTur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DniTur.Name = "DniTur";
            this.DniTur.Size = new System.Drawing.Size(58, 13);
            this.DniTur.TabIndex = 12;
            this.DniTur.Text = "Dni Turista";
            // 
            // FechaTxt
            // 
            this.FechaTxt.Location = new System.Drawing.Point(84, 119);
            this.FechaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.FechaTxt.Name = "FechaTxt";
            this.FechaTxt.Size = new System.Drawing.Size(80, 20);
            this.FechaTxt.TabIndex = 3;
            this.FechaTxt.Tag = "Telefono";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(10, 120);
            this.Fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(37, 13);
            this.Fecha.TabIndex = 10;
            this.Fecha.Text = "&Fecha";
            // 
            // CodAgeTxt
            // 
            this.CodAgeTxt.Location = new System.Drawing.Point(84, 86);
            this.CodAgeTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CodAgeTxt.Name = "CodAgeTxt";
            this.CodAgeTxt.Size = new System.Drawing.Size(80, 20);
            this.CodAgeTxt.TabIndex = 2;
            this.CodAgeTxt.Tag = "Domicilio";
            // 
            // CodAge
            // 
            this.CodAge.AutoSize = true;
            this.CodAge.Location = new System.Drawing.Point(10, 86);
            this.CodAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CodAge.Name = "CodAge";
            this.CodAge.Size = new System.Drawing.Size(71, 13);
            this.CodAge.TabIndex = 8;
            this.CodAge.Text = "&Cod. Agencia";
            // 
            // CodTPTxt
            // 
            this.CodTPTxt.Location = new System.Drawing.Point(84, 51);
            this.CodTPTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CodTPTxt.MaxLength = 90;
            this.CodTPTxt.Name = "CodTPTxt";
            this.CodTPTxt.Size = new System.Drawing.Size(80, 20);
            this.CodTPTxt.TabIndex = 1;
            this.CodTPTxt.Tag = "Nombre";
            // 
            // CodTP
            // 
            this.CodTP.AutoSize = true;
            this.CodTP.Location = new System.Drawing.Point(10, 51);
            this.CodTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CodTP.Name = "CodTP";
            this.CodTP.Size = new System.Drawing.Size(57, 13);
            this.CodTP.TabIndex = 2;
            this.CodTP.Text = "&Codigo TP";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(185, 273);
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
            this.GuardarBtn.Location = new System.Drawing.Point(53, 273);
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
            // CodDestino
            // 
            this.CodDestino.AutoSize = true;
            this.CodDestino.Location = new System.Drawing.Point(10, 220);
            this.CodDestino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CodDestino.Name = "CodDestino";
            this.CodDestino.Size = new System.Drawing.Size(65, 13);
            this.CodDestino.TabIndex = 19;
            this.CodDestino.Text = "Cod Destino";
            // 
            // CodDestinoTxt
            // 
            this.CodDestinoTxt.DisplayMember = "Nombre";
            this.CodDestinoTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CodDestinoTxt.FormattingEnabled = true;
            this.CodDestinoTxt.Location = new System.Drawing.Point(84, 212);
            this.CodDestinoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CodDestinoTxt.Name = "CodDestinoTxt";
            this.CodDestinoTxt.Size = new System.Drawing.Size(117, 21);
            this.CodDestinoTxt.TabIndex = 20;
            this.CodDestinoTxt.Tag = "Nivel";
            this.CodDestinoTxt.ValueMember = "Id";
            // 
            // FrmPaqueteAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 328);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPaqueteAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidaTurista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.TextBox CodTPTxt;
        private System.Windows.Forms.Label CodTP;
        private System.Windows.Forms.ComboBox DniTurTxt;
        private System.Windows.Forms.Label DniTur;
        private System.Windows.Forms.TextBox FechaTxt;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.TextBox CodAgeTxt;
        private System.Windows.Forms.Label CodAge;
        private System.Windows.Forms.TextBox CodPaqTxt;
        private System.Windows.Forms.Label CodPaq;
        private System.Windows.Forms.ErrorProvider ErrorValidaTurista;
        private System.Windows.Forms.ComboBox NivelTxt;
        private System.Windows.Forms.Label Nivel;
        private System.Windows.Forms.ComboBox CodDestinoTxt;
        private System.Windows.Forms.Label CodDestino;
    }
}