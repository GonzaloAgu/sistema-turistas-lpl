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
            this.destinosCbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.turistaCbo = new System.Windows.Forms.ComboBox();
            this.agenciaCbo = new System.Windows.Forms.ComboBox();
            this.tipoPaqCbo = new System.Windows.Forms.ComboBox();
            this.CodDestino = new System.Windows.Forms.Label();
            this.NivelTxt = new System.Windows.Forms.ComboBox();
            this.Nivel = new System.Windows.Forms.Label();
            this.DniTur = new System.Windows.Forms.Label();
            this.FechaTxt = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.CodAge = new System.Windows.Forms.Label();
            this.CodTP = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.ErrorValidaTurista = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidaTurista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.destinosCbo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.turistaCbo);
            this.groupBox1.Controls.Add(this.agenciaCbo);
            this.groupBox1.Controls.Add(this.tipoPaqCbo);
            this.groupBox1.Controls.Add(this.CodDestino);
            this.groupBox1.Controls.Add(this.NivelTxt);
            this.groupBox1.Controls.Add(this.Nivel);
            this.groupBox1.Controls.Add(this.DniTur);
            this.groupBox1.Controls.Add(this.FechaTxt);
            this.groupBox1.Controls.Add(this.Fecha);
            this.groupBox1.Controls.Add(this.CodAge);
            this.groupBox1.Controls.Add(this.CodTP);
            this.groupBox1.Location = new System.Drawing.Point(9, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(292, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // destinosCbo
            // 
            this.destinosCbo.DisplayMember = "Codigo";
            this.destinosCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinosCbo.FormattingEnabled = true;
            this.destinosCbo.Location = new System.Drawing.Point(86, 114);
            this.destinosCbo.Name = "destinosCbo";
            this.destinosCbo.Size = new System.Drawing.Size(155, 21);
            this.destinosCbo.TabIndex = 4;
            this.destinosCbo.ValueMember = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "dd/mm/aaaa";
            // 
            // turistaCbo
            // 
            this.turistaCbo.DisplayMember = "Codigo";
            this.turistaCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.turistaCbo.FormattingEnabled = true;
            this.turistaCbo.Location = new System.Drawing.Point(86, 79);
            this.turistaCbo.Name = "turistaCbo";
            this.turistaCbo.Size = new System.Drawing.Size(155, 21);
            this.turistaCbo.TabIndex = 3;
            this.turistaCbo.ValueMember = "NroDocumento";
            // 
            // agenciaCbo
            // 
            this.agenciaCbo.DisplayMember = "Codigo";
            this.agenciaCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agenciaCbo.FormattingEnabled = true;
            this.agenciaCbo.Location = new System.Drawing.Point(86, 49);
            this.agenciaCbo.Name = "agenciaCbo";
            this.agenciaCbo.Size = new System.Drawing.Size(155, 21);
            this.agenciaCbo.TabIndex = 2;
            this.agenciaCbo.ValueMember = "Codigo";
            // 
            // tipoPaqCbo
            // 
            this.tipoPaqCbo.DisplayMember = "Codigo";
            this.tipoPaqCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoPaqCbo.FormattingEnabled = true;
            this.tipoPaqCbo.Location = new System.Drawing.Point(86, 20);
            this.tipoPaqCbo.Name = "tipoPaqCbo";
            this.tipoPaqCbo.Size = new System.Drawing.Size(155, 21);
            this.tipoPaqCbo.TabIndex = 1;
            this.tipoPaqCbo.ValueMember = "Codigo";
            // 
            // CodDestino
            // 
            this.CodDestino.AutoSize = true;
            this.CodDestino.Location = new System.Drawing.Point(25, 117);
            this.CodDestino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CodDestino.Name = "CodDestino";
            this.CodDestino.Size = new System.Drawing.Size(43, 13);
            this.CodDestino.TabIndex = 19;
            this.CodDestino.Text = "Destino";
            // 
            // NivelTxt
            // 
            this.NivelTxt.DisplayMember = "Nombre";
            this.NivelTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.NivelTxt.FormattingEnabled = true;
            this.NivelTxt.Location = new System.Drawing.Point(86, 188);
            this.NivelTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NivelTxt.MaxLength = 5;
            this.NivelTxt.Name = "NivelTxt";
            this.NivelTxt.Size = new System.Drawing.Size(80, 21);
            this.NivelTxt.TabIndex = 6;
            this.NivelTxt.Tag = "Nivel";
            this.NivelTxt.ValueMember = "Id";
            // 
            // Nivel
            // 
            this.Nivel.AutoSize = true;
            this.Nivel.Location = new System.Drawing.Point(37, 191);
            this.Nivel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nivel.Name = "Nivel";
            this.Nivel.Size = new System.Drawing.Size(31, 13);
            this.Nivel.TabIndex = 17;
            this.Nivel.Text = "&Nivel";
            // 
            // DniTur
            // 
            this.DniTur.AutoSize = true;
            this.DniTur.Location = new System.Drawing.Point(29, 82);
            this.DniTur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DniTur.Name = "DniTur";
            this.DniTur.Size = new System.Drawing.Size(39, 13);
            this.DniTur.TabIndex = 12;
            this.DniTur.Text = "Turista";
            // 
            // FechaTxt
            // 
            this.FechaTxt.Location = new System.Drawing.Point(86, 158);
            this.FechaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.FechaTxt.MaxLength = 10;
            this.FechaTxt.Name = "FechaTxt";
            this.FechaTxt.Size = new System.Drawing.Size(80, 20);
            this.FechaTxt.TabIndex = 5;
            this.FechaTxt.Tag = "Telefono";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(31, 161);
            this.Fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(37, 13);
            this.Fecha.TabIndex = 10;
            this.Fecha.Text = "&Fecha";
            // 
            // CodAge
            // 
            this.CodAge.AutoSize = true;
            this.CodAge.Location = new System.Drawing.Point(22, 52);
            this.CodAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CodAge.Name = "CodAge";
            this.CodAge.Size = new System.Drawing.Size(46, 13);
            this.CodAge.TabIndex = 8;
            this.CodAge.Text = "&Agencia";
            // 
            // CodTP
            // 
            this.CodTP.AutoSize = true;
            this.CodTP.Location = new System.Drawing.Point(4, 23);
            this.CodTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CodTP.Name = "CodTP";
            this.CodTP.Size = new System.Drawing.Size(71, 13);
            this.CodTP.TabIndex = 2;
            this.CodTP.Text = "&Tipo Paquete";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(151, 232);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 8;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(242, 232);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 7;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // ErrorValidaTurista
            // 
            this.ErrorValidaTurista.ContainerControl = this;
            // 
            // FrmPaqueteAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 272);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPaqueteAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de paquete...";
            this.Load += new System.EventHandler(this.FrmPaqueteAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidaTurista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Label CodTP;
        private System.Windows.Forms.Label DniTur;
        private System.Windows.Forms.TextBox FechaTxt;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label CodAge;
        private System.Windows.Forms.ErrorProvider ErrorValidaTurista;
        private System.Windows.Forms.ComboBox NivelTxt;
        private System.Windows.Forms.Label Nivel;
        private System.Windows.Forms.Label CodDestino;
        private System.Windows.Forms.ComboBox tipoPaqCbo;
        private System.Windows.Forms.ComboBox agenciaCbo;
        private System.Windows.Forms.ComboBox turistaCbo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox destinosCbo;
    }
}