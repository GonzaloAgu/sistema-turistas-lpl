namespace TurApp.Views
{
    partial class FrmPaqueteBusq
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
            this.CodigoTxt = new System.Windows.Forms.TextBox();
            this.CodigoChk = new System.Windows.Forms.CheckBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.turistaCbo = new System.Windows.Forms.ComboBox();
            this.agenciaCbo = new System.Windows.Forms.ComboBox();
            this.tipoPaqCbo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tipoPaqChk = new System.Windows.Forms.CheckBox();
            this.agenciaChk = new System.Windows.Forms.CheckBox();
            this.turistaChk = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodigoTxt
            // 
            this.CodigoTxt.Enabled = false;
            this.CodigoTxt.Location = new System.Drawing.Point(100, 27);
            this.CodigoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CodigoTxt.Name = "CodigoTxt";
            this.CodigoTxt.Size = new System.Drawing.Size(114, 20);
            this.CodigoTxt.TabIndex = 5;
            // 
            // CodigoChk
            // 
            this.CodigoChk.AutoSize = true;
            this.CodigoChk.Location = new System.Drawing.Point(5, 27);
            this.CodigoChk.Margin = new System.Windows.Forms.Padding(2);
            this.CodigoChk.Name = "CodigoChk";
            this.CodigoChk.Size = new System.Drawing.Size(59, 17);
            this.CodigoChk.TabIndex = 4;
            this.CodigoChk.Text = "Codigo";
            this.CodigoChk.UseVisualStyleBackColor = true;
            this.CodigoChk.CheckedChanged += new System.EventHandler(this.CodigoChk_CheckedChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(212, 169);
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
            this.BuscarBtn.Location = new System.Drawing.Point(110, 169);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 8;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // turistaCbo
            // 
            this.turistaCbo.DisplayMember = "Codigo";
            this.turistaCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.turistaCbo.Enabled = false;
            this.turistaCbo.FormattingEnabled = true;
            this.turistaCbo.Location = new System.Drawing.Point(100, 111);
            this.turistaCbo.Name = "turistaCbo";
            this.turistaCbo.Size = new System.Drawing.Size(146, 21);
            this.turistaCbo.TabIndex = 23;
            this.turistaCbo.ValueMember = "NroDocumento";
            // 
            // agenciaCbo
            // 
            this.agenciaCbo.DisplayMember = "Codigo";
            this.agenciaCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agenciaCbo.Enabled = false;
            this.agenciaCbo.FormattingEnabled = true;
            this.agenciaCbo.Location = new System.Drawing.Point(100, 81);
            this.agenciaCbo.Name = "agenciaCbo";
            this.agenciaCbo.Size = new System.Drawing.Size(146, 21);
            this.agenciaCbo.TabIndex = 22;
            this.agenciaCbo.ValueMember = "Codigo";
            // 
            // tipoPaqCbo
            // 
            this.tipoPaqCbo.DisplayMember = "Codigo";
            this.tipoPaqCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoPaqCbo.Enabled = false;
            this.tipoPaqCbo.FormattingEnabled = true;
            this.tipoPaqCbo.Location = new System.Drawing.Point(100, 52);
            this.tipoPaqCbo.Name = "tipoPaqCbo";
            this.tipoPaqCbo.Size = new System.Drawing.Size(146, 21);
            this.tipoPaqCbo.TabIndex = 20;
            this.tipoPaqCbo.ValueMember = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.turistaChk);
            this.groupBox1.Controls.Add(this.agenciaChk);
            this.groupBox1.Controls.Add(this.tipoPaqChk);
            this.groupBox1.Controls.Add(this.turistaCbo);
            this.groupBox1.Controls.Add(this.agenciaCbo);
            this.groupBox1.Controls.Add(this.tipoPaqCbo);
            this.groupBox1.Controls.Add(this.CodigoTxt);
            this.groupBox1.Controls.Add(this.CodigoChk);
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 157);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // tipoPaqChk
            // 
            this.tipoPaqChk.AutoSize = true;
            this.tipoPaqChk.Location = new System.Drawing.Point(5, 57);
            this.tipoPaqChk.Margin = new System.Windows.Forms.Padding(2);
            this.tipoPaqChk.Name = "tipoPaqChk";
            this.tipoPaqChk.Size = new System.Drawing.Size(90, 17);
            this.tipoPaqChk.TabIndex = 25;
            this.tipoPaqChk.Text = "Tipo Paquete";
            this.tipoPaqChk.UseVisualStyleBackColor = true;
            this.tipoPaqChk.CheckedChanged += new System.EventHandler(this.tipoPaqChk_CheckedChanged);
            // 
            // agenciaChk
            // 
            this.agenciaChk.AutoSize = true;
            this.agenciaChk.Location = new System.Drawing.Point(5, 86);
            this.agenciaChk.Margin = new System.Windows.Forms.Padding(2);
            this.agenciaChk.Name = "agenciaChk";
            this.agenciaChk.Size = new System.Drawing.Size(65, 17);
            this.agenciaChk.TabIndex = 26;
            this.agenciaChk.Text = "Agencia";
            this.agenciaChk.UseVisualStyleBackColor = true;
            this.agenciaChk.CheckedChanged += new System.EventHandler(this.agenciaChk_CheckedChanged);
            // 
            // turistaChk
            // 
            this.turistaChk.AutoSize = true;
            this.turistaChk.Location = new System.Drawing.Point(5, 116);
            this.turistaChk.Margin = new System.Windows.Forms.Padding(2);
            this.turistaChk.Name = "turistaChk";
            this.turistaChk.Size = new System.Drawing.Size(58, 17);
            this.turistaChk.TabIndex = 27;
            this.turistaChk.Text = "Turista";
            this.turistaChk.UseVisualStyleBackColor = true;
            this.turistaChk.CheckedChanged += new System.EventHandler(this.turistaChk_CheckedChanged);
            // 
            // FrmPaqueteBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 212);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPaqueteBusq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Paquete...";
            this.Activated += new System.EventHandler(this.FrmTuristaBusq_Activated);
            this.Load += new System.EventHandler(this.FrmActividadBusq_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CodigoTxt;
        private System.Windows.Forms.CheckBox CodigoChk;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.ComboBox turistaCbo;
        private System.Windows.Forms.ComboBox agenciaCbo;
        private System.Windows.Forms.ComboBox tipoPaqCbo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox turistaChk;
        private System.Windows.Forms.CheckBox agenciaChk;
        private System.Windows.Forms.CheckBox tipoPaqChk;
    }
}