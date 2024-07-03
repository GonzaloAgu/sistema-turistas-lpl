namespace TurApp.Views {
    partial class FrmFacturar {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FormaPagoCbo = new System.Windows.Forms.ComboBox();
            this.TuristaCbo = new System.Windows.Forms.ComboBox();
            this.factGB = new System.Windows.Forms.GroupBox();
            this.LetraCbo = new System.Windows.Forms.ComboBox();
            this.detallePagoTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nroSerieTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nroFacturaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GenerarBtn = new System.Windows.Forms.Button();
            this.AnadirBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.finalizarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.factGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Forma de pago";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FormaPagoCbo);
            this.groupBox1.Controls.Add(this.TuristaCbo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // FormaPagoCbo
            // 
            this.FormaPagoCbo.DisplayMember = "Forma";
            this.FormaPagoCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormaPagoCbo.Location = new System.Drawing.Point(102, 41);
            this.FormaPagoCbo.Name = "FormaPagoCbo";
            this.FormaPagoCbo.Size = new System.Drawing.Size(153, 21);
            this.FormaPagoCbo.TabIndex = 2;
            this.FormaPagoCbo.ValueMember = "Forma";
            // 
            // TuristaCbo
            // 
            this.TuristaCbo.DisplayMember = "Nombre";
            this.TuristaCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TuristaCbo.FormattingEnabled = true;
            this.TuristaCbo.Location = new System.Drawing.Point(102, 13);
            this.TuristaCbo.Name = "TuristaCbo";
            this.TuristaCbo.Size = new System.Drawing.Size(153, 21);
            this.TuristaCbo.TabIndex = 1;
            this.TuristaCbo.ValueMember = "NroDocumento";
            // 
            // factGB
            // 
            this.factGB.Controls.Add(this.LetraCbo);
            this.factGB.Controls.Add(this.detallePagoTxt);
            this.factGB.Controls.Add(this.label6);
            this.factGB.Controls.Add(this.label5);
            this.factGB.Controls.Add(this.nroSerieTxt);
            this.factGB.Controls.Add(this.label4);
            this.factGB.Controls.Add(this.nroFacturaTxt);
            this.factGB.Controls.Add(this.label3);
            this.factGB.Location = new System.Drawing.Point(12, 107);
            this.factGB.Name = "factGB";
            this.factGB.Size = new System.Drawing.Size(274, 184);
            this.factGB.TabIndex = 3;
            this.factGB.TabStop = false;
            this.factGB.Text = "Datos de factura";
            // 
            // LetraCbo
            // 
            this.LetraCbo.DisplayMember = "Forma";
            this.LetraCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LetraCbo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.LetraCbo.Location = new System.Drawing.Point(102, 80);
            this.LetraCbo.Name = "LetraCbo";
            this.LetraCbo.Size = new System.Drawing.Size(65, 21);
            this.LetraCbo.TabIndex = 6;
            this.LetraCbo.ValueMember = "Letra";
            // 
            // detallePagoTxt
            // 
            this.detallePagoTxt.Location = new System.Drawing.Point(102, 119);
            this.detallePagoTxt.MaxLength = 90;
            this.detallePagoTxt.Multiline = true;
            this.detallePagoTxt.Name = "detallePagoTxt";
            this.detallePagoTxt.Size = new System.Drawing.Size(153, 47);
            this.detallePagoTxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Detalle de pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo (letra)";
            // 
            // nroSerieTxt
            // 
            this.nroSerieTxt.Location = new System.Drawing.Point(102, 51);
            this.nroSerieTxt.Name = "nroSerieTxt";
            this.nroSerieTxt.Size = new System.Drawing.Size(153, 20);
            this.nroSerieTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "N° Serie";
            // 
            // nroFacturaTxt
            // 
            this.nroFacturaTxt.Location = new System.Drawing.Point(102, 25);
            this.nroFacturaTxt.Name = "nroFacturaTxt";
            this.nroFacturaTxt.Size = new System.Drawing.Size(153, 20);
            this.nroFacturaTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "N° Factura";
            // 
            // GenerarBtn
            // 
            this.GenerarBtn.Location = new System.Drawing.Point(84, 306);
            this.GenerarBtn.Name = "GenerarBtn";
            this.GenerarBtn.Size = new System.Drawing.Size(103, 23);
            this.GenerarBtn.TabIndex = 8;
            this.GenerarBtn.Text = "Generar factura...";
            this.GenerarBtn.UseVisualStyleBackColor = true;
            this.GenerarBtn.Click += new System.EventHandler(this.GenerarBtn_Click);
            // 
            // AnadirBtn
            // 
            this.AnadirBtn.Enabled = false;
            this.AnadirBtn.Location = new System.Drawing.Point(193, 306);
            this.AnadirBtn.Name = "AnadirBtn";
            this.AnadirBtn.Size = new System.Drawing.Size(93, 23);
            this.AnadirBtn.TabIndex = 9;
            this.AnadirBtn.Text = "Añadir detalle...";
            this.AnadirBtn.UseVisualStyleBackColor = true;
            this.AnadirBtn.Click += new System.EventHandler(this.AnadirBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(211, 335);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 11;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // finalizarBtn
            // 
            this.finalizarBtn.Enabled = false;
            this.finalizarBtn.Location = new System.Drawing.Point(130, 335);
            this.finalizarBtn.Name = "finalizarBtn";
            this.finalizarBtn.Size = new System.Drawing.Size(75, 23);
            this.finalizarBtn.TabIndex = 10;
            this.finalizarBtn.Text = "Finalizar";
            this.finalizarBtn.UseVisualStyleBackColor = true;
            this.finalizarBtn.Click += new System.EventHandler(this.finalizarBtn_Click);
            // 
            // FrmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 372);
            this.Controls.Add(this.finalizarBtn);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.AnadirBtn);
            this.Controls.Add(this.GenerarBtn);
            this.Controls.Add(this.factGB);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFacturar";
            this.Text = "Generar factura";
            this.Load += new System.EventHandler(this.FrmFacturar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.factGB.ResumeLayout(false);
            this.factGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox FormaPagoCbo;
        private System.Windows.Forms.ComboBox TuristaCbo;
        private System.Windows.Forms.GroupBox factGB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nroSerieTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nroFacturaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GenerarBtn;
        private System.Windows.Forms.Button AnadirBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button finalizarBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox detallePagoTxt;
        private System.Windows.Forms.ComboBox LetraCbo;
    }
}